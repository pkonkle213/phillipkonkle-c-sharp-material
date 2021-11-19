let allItemsIncomplete = true;
const pageTitle = 'My Shopping List';
const groceries = [
  { id: 1, name: 'Oatmeal', completed: false },
  { id: 2, name: 'Milk', completed: false },
  { id: 3, name: 'Banana', completed: false },
  { id: 4, name: 'Strawberries', completed: false },
  { id: 5, name: 'Lunch Meat', completed: false },
  { id: 6, name: 'Bread', completed: false },
  { id: 7, name: 'Grapes', completed: false },
  { id: 8, name: 'Steak', completed: false },
  { id: 9, name: 'Salad', completed: false },
  { id: 10, name: 'Tea', completed: false }
];

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  const title = document.getElementById('title');
  title.innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  const ul = document.querySelector('ul');
  groceries.forEach((item) => {
    const li = document.createElement('li');
    li.innerText = item.name;
    const checkCircle = document.createElement('i');
    checkCircle.setAttribute('class', 'far fa-check-circle');
    li.appendChild(checkCircle);
    ul.appendChild(li);
  });
}

function updateList() {
  let list = document.querySelectorAll('li');
  for (let i = 0; i < list.length; i++) {
    if (groceries[i].completed) {
      list[i].classList.add('completed');
      list[i].lastChild.classList.add('completed');
    } else {
      list[i].classList.remove('completed');
      list[i].lastChild.classList.remove('completed');
    }
  }
}

function clicked(event) {
  const target = event.target;
  const name = target.outerText;

  for(let i = 0;i < groceries.length; i++) {
    if (groceries[i].name===name) {
      groceries[i].completed = true;
    }
  }

  updateList()
}

function doubleClicked(event) {
  const target = event.target;
  const name = target.outerText;

  for(let i = 0;i < groceries.length; i++) {
    if (groceries[i].name===name) {
      groceries[i].completed = false;
    }
  }

  updateList()
}

function initialize() {
  setPageTitle();
  displayGroceries();

  let listSelect = document.querySelectorAll('li');
  listSelect.forEach((element) => {
    element.addEventListener('click', event => {
      clicked(event);
    });

    element.addEventListener('dblclick', event => {
      doubleClicked(event);
    });
  });

  let completeAll = document.querySelector('#toggleAll');
  completeAll.addEventListener('click', event => {
      completeAll.innerText=markAll();
  });
}

function markAll() {
  let returnString;
  if (allItemsIncomplete===true) {
    allItemsIncomplete=false;
    returnString="Mark All Incomplete";
  } else {
    allItemsIncomplete=true;
    returnString="Mark All Complete";
  }

  groceries.forEach((item) => {
    item.completed = !allItemsIncomplete;
  });
  updateList()
  return returnString;
}

document.addEventListener("DOMContentLoaded", event => {
  initialize();
});