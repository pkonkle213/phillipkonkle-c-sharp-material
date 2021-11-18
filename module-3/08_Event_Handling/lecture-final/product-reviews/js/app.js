// Data  ------------------------------------------------------------------------------------------

const name = 'Cigar Parties for Dummies';
let description = 'Host and plan the perfect cigar party for all of your squirrelly friends.';
let reviews = [
  {
    reviewer: 'Malcolm Gladwell',
    title: 'What a book!',
    review:
      "It certainly is a book. I mean, I can see that. Pages kept together with glue (I hope that's glue) and there's writing on it, in some language.",
    rating: 3
  }
];

// Pre-Built Functions ---------------------------------------------------------------------------

/**
 * Add our product name to the page title
 * Get our page page title by the id and the query the .name selector
 * once you have the element you can add the product name to the span.
 */
function setPageTitle() {
  //const pageTitle = document.getElementById('page-title');
  document.querySelector('#page-title .name').innerHTML = name;
}

/**
 * Add our product description to the page.
 */
function setPageDescription() {
  document.querySelector('.description').innerHTML = description;
}

/**
 * Displays all of the reviews in the reviews array
 */
function displayReviews() {
  if ('content' in document.createElement('template')) {
    reviews.forEach((review) => displayReview(review)); // This could also be written reviews.forEach(displayReview);
  } else {
    console.error('Your browser does not support templates');
  }
}

/**
 * Displays all reviews on the page
 * @param {Object} review The review to display
 */
function displayReview(review) {
  const main = document.getElementById('main');

  // This grabs a template out of the HTML and clones it, then selects the template to customize it
  const clonedNode = document.getElementById('review-template').content.cloneNode(true);
  clonedNode.querySelector('h4').innerText = review.reviewer;
  clonedNode.querySelector('h3').innerText = review.title;
  clonedNode.querySelector('p').innerText = review.review;

  // there will always be 1 star because it is a part of the template
  for (let i = 1; i < review.rating; ++i) {
    const img = clonedNode.querySelector('img').cloneNode();
    clonedNode.querySelector('.rating').appendChild(img);
  }
  
  main.appendChild(clonedNode);
}

/**
 * Shows / hides the add review form
 * @param {Event} event the event that occurred in the browser
 */
function showHideForm(event) {
  console.log('showHideForm', event);

  const form = document.querySelector('form');
  const btn = document.getElementById('btnToggleForm');

  if (form.classList.contains('d-none')) {
    form.classList.remove('d-none');
    btn.innerText = 'Hide Form';
    document.getElementById('name').focus();
  } else {
    resetFormValues();
    form.classList.add('d-none');
    btn.innerText = 'Add Review';
  }
}

/**
 * Resets all of the values in the form.
 */
function resetFormValues() {
  const form = document.querySelector('form');
  const inputs = form.querySelectorAll('input');
  inputs.forEach((input) => {
    input.value = '';
  });
  document.getElementById('rating').value = 1;
  document.getElementById('review').value = '';
}

/**
 * Take an event on the description and swap out the description for a text box.
 * @param {Event} event the event that occurred in the browser
 */
function showDescriptionEdit(event) {
  console.log('Show Description Edit', event);

  const target = event.target; // p

  const textBox = target.nextElementSibling; // ew (input#inputDesc)
  textBox.value = description; // description is the variable at the top of the file
  textBox.classList.remove('d-none'); // show the text box

  target.classList.add('d-none'); // hide the paragraph

  textBox.focus();
}

/**
 * Take an event on the text box and set the description to the contents
 * of the text box and then hide the text box and show the description.
 *
 * @param {Event} event the event object representing the description we're editing
 * @param {Boolean} save should we save the description text
 */
function exitDescriptionEdit(event, save) {
  const target = event.target;

  if (!target) return; // this line can go once target is set

  const desc = target.previousElementSibling; // ew, p.description

  // If we're saving, get the new value and set that into description and desc
  if (save) {
    let newText = target.value;
    description = newText;
    desc.innerText = newText;
  }

  // Hide the input, show the paragraph
  target.classList.add('d-none');
  desc.classList.remove('d-none');
}

// LECTURE STARTS HERE ---------------------------------------------------------------

function initialize() {
  // set the product reviews page title
  setPageTitle();

  // set the product reviews page description
  setPageDescription();

  // display all of the product reviews on our page
  displayReviews();

  // -----------------------------------------------

  // Step 2: When the user clicks on btnToggleForm, call showHideForm
  let btnForm = document.querySelector('#btnToggleForm');
  //console.log(btnForm);
  btnForm.addEventListener('click', event => {
    console.log("Button clicked!", event);
    showHideForm();
  });

  // Step 3: When the user clicks btnSaveReview, call saveReview
  document.getElementById("btnSaveReview").addEventListener("click", event => saveReview(event));

  // -----------------------------------------------

  // Step 4: When the user double clicks the description paragraph, 
  // call showDescriptionEdit and pass it the event
  let p = document.querySelector('p.description');
  p.addEventListener('dblclick', event => {
    showDescriptionEdit(event);
  });

  // Step 5: When the user presses a key on inputDesc, 
  // check for enter and escape and call exitDescriptionEdit
  let desc = document.getElementById("inputDesc");
  /*
  desc.addEventListener('keydown', event => {
    console.log("Key Down event", event);
  });
  */
  desc.addEventListener('keyup', event => {
    console.log("Key Up event", event);
    if (event.key === "Enter") {
      exitDescriptionEdit(event, true);
    } else if (event.key === "Escape") {
      exitDescriptionEdit(event, false);
    }
  });
  /*
  desc.addEventListener('keypress', event => {
    console.log("Key Press event", event);
  });
  */

  // ------------------------------------------------

  // Step 6: Add a click listener for when the user clicks the body element and talk bubbling
}


/**
 * I will save the review that was added using the add review from
 * @param {Event} event the event that occurred in the browser
 */
function saveReview(event) {

  event.preventDefault(); // Preventing the form from refreshing the page

  console.log('Saving Review', event);

  // Get the value of the name, title, review, and rating controls (these are their ids)
  const nameInput = document.querySelector('#name');
  const titleInput = document.querySelector('#title');
  const reviewInput = document.querySelector('#review');
  const ratingInput = document.querySelector('#rating');

  console.debug(nameInput, titleInput, reviewInput, ratingInput);

  // Create a new review object with these values for reviewer, 
  // title, review, and rating
  let newReview = {
    reviewer: nameInput.value,
    title: titleInput.value,
    rating: ratingInput.value,
    review: reviewInput.value
  };

  // Add the new object to reviews
  reviews.push(newReview);
  console.log(newReview, reviews);

  // Call displayReview with the new review as a parameter
  displayReview(newReview);

  // Call showHideForm to toggle the form visibility
  showHideForm();
}

// Step 1: Call initialize when the DOM is ready
document.addEventListener("DOMContentLoaded", event => {
  //event.buttercup = "Phil";
  console.log(event);

  initialize();
});