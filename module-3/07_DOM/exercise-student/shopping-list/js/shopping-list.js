// add pageTitle
const pageTitle = 'My Shopping List';

// add groceries
const groceries = ['Dr Pepper Cream Soda',
  'Milk',
  'Orange Juice',
  'Eggs',
  'Ham',
  'Pack of Magic cards',
  'Chocolate',
  'Dog treats',
  'Ice cream',
  'Starbucks' 
]

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  let h1 = document.querySelector('h1');
  h1.innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  let ul = document.getElementById('groceries');

  groceries.forEach((grocery) => {
    let li = document.createElement('li');
    li.innerText = grocery;
    ul.appendChild(li);
  });
}

/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */
function markCompleted() {
  let li = document.querySelectorAll('li');
  li.forEach((item) => {
    item.classList.add('completed');
  });
}

setPageTitle();

displayGroceries();

// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});
