// We start with some initial data that we won't need to change
const name = 'Cigar Parties for Dummies';
const description = 'Host and plan the perfect cigar party for all of your squirrelly friends.';
const reviews = [
  {
    reviewer: 'Malcolm Gladwell',
    title: 'What a book!',
    review:
      "It certainly is a book. I mean, I can see that. Pages kept together with glue (I hope that's glue) and there's writing on it, in some language.",
    rating: 3
  },
  {
    reviewer: 'Tim Ferriss',
    title: 'Had a cigar party started in less than 4 hours.',
    review:
      "It should have been called the four hour cigar party. That's amazing. I have a new idea for muse because of this.",
    rating: 4
  },
  {
    reviewer: 'Clippy',
    title: 'Because things are awesome',
    review: 'This is stressful',
    rating: 5
  },
  {
    reviewer: 'Ramit Sethi',
    title: 'What every new entrepreneurs needs. A door stop.',
    review:
      "When I sell my courses, I'm always telling people that if a book costs less than $20, they should just buy it. If they only learn one thing from it, it was worth it. Wish I learned something from this book.",
    rating: 1
  },
  {
    reviewer: 'Gary Vaynerchuk',
    title: 'And I thought I could write',
    review:
      "There are a lot of good, solid tips in this book. I don't want to ruin it, but prelighting all the cigars is worth the price of admission alone.",
    rating: 3
  }
];

// First, let's look over the functions already here

// Next let's talk about the 3 different ways of querying the document for elements

// document.getElementById('someId'); no # - Matt doesn't like this one
// document.querySelector('#someSelector'); gets the first matching element
// document.querySelectorAll('li'); gets an array-like thing containing all matching nodes or an empty array - this needs to be looped over

/**
 * Add our product name to the page title
 */
function setPageTitle() {
  // Get our page page title by the id and the query the .name selector
  // wrong - document.getElementById('page-title');
  let span = document.querySelector('h2 span.name');

  // Add the product name to the span.

  span.innerText = name;

}

/**
 * Add our product description to the page.
 */
function setPageDescription() {
  // Get the description paragraph
  let p = document.querySelector('p.description');

  // console.log(p)
  // Set the description paragraph's contents
  p.innerText = description;
}

/**
 * I will display all of the reviews on the page.
 * I will loop over the array of reviews and use some helper functions
 * to create the elements needed for our markup and add them to the DOM
 */
function displayReviews() {
  // Grab the main area of the application
  let main = document.querySelector('div#main');

  // For each review, build out HTML by:
  reviews.forEach((review) => {
        
    // ... creating a new HTML element (a div (ew))
    let div = document.createElement('div');
    
    // ... add the review class to that div
    div.classList.add('review');
    
    // ... addReviewer
    addReviewer(div, review.reviewer);
    
    // ... addRating
    addRating(div, review.rating);

    // ... addTitle
    addTitle(div, review.title);

    // ... addReview
    addReview(div, review.review);
    
    // ... add the div to the application area
    main.appendChild(div);
  });
    // Now that we've added these divs, let's find the rating divs
    let divs = document.querySelectorAll('.review div');
    // With these divs, add the rating class to them
    divs.forEach(div => div.classList.add('rating'));
    // divs.classList.add('rating'); doesn't work because divs is an array
}

/**
 * I will creating a new h4 element with the name of the reviewer and append it to
 * the parent element that is passed to me.
 *
 * @param {HTMLElement} parent: The element to append the reviewer to
 * @param {string} name The name of the reviewer
 */
function addReviewer(parent, name) {
  // Create an element that looks something like <h4>name</h4>
  let h4 = document.createElement('h4');
  h4.innerText = name;
  
  // Add this element to the parent
  parent.appendChild(h4);
}

/**
 * I will add an h3 element along with the review title
 * @param {HTMLElement} parent
 * @param {string} title
 */
function addTitle(parent, title) {
  // Create an element that looks something like <h3>title</h3>
  let h3 = document.createElement('h3');
  h3.innerText = title;
  
  // Add this element to the parent
  parent.appendChild(h3);
}

/**
 * I will add the product review
 * @param {HTMLElement} parent
 * @param {string} review
 */
function addReview(parent, review) {
  // Create an element that looks something like <p>review</p>
  // Note that this element may contain HTML content
  let p = document.createElement('p');
  p.innerHTML = review;

  // Add this element to the parent  
  parent.appendChild(p);
}

/**
 * I will add the rating div along with a star image for the number of ratings 1-5
 * @param {HTMLElement} parent
 * @param {Number} numberOfStars
 */
function addRating(parent, numberOfStars) {
  // Create a div to hold the number of stars
let div = document.createElement('div');

  // For each star:
  // ... create an image using 'img/star.png'
  // ... add that star to the parent
  for (let i=0;i<numberOfStars;i++) {
    let img = document.createElement('img');
    img.src = 'img/star.png';
    img.alt = 'a glowing, beautiful gold star';
    div.appendChild(img);
  }

  // Add the stars div to the parent
  parent.appendChild(div);
}

// Code to start up our application. This will change tomorrow:

// set the product reviews page title
setPageTitle();
// set the product reviews page description
setPageDescription();
// display all of the product reviews on our page
displayReviews();
