// TODO: Install the TODO Highlight extension

// --------------------------------------------------------------------
// Code below is for LOCATIONS OF JS CODE
// --------------------------------------------------------------------

/*
    Example of a multi-line comment just like in C#
*/

// Single line comment

console.debug("Debug message from our JavaScript file!");
console.log("Log message from our JavaScript file!");
console.info("Info message from our JavaScript file!");
console.warn("Warning message from our JavaScript file!");
console.error("Error message from our JavaScript file!");

let week = 10;

// Console.WriteLine won't work here
// console.WriteLine("Matt thinks he is in C#");

console.log("Another log statement");


// TODO: Or will it?
let loggingFunction = console.debug; // Store the entire log function into loggingFunction
loggingFunction("This is so weird");

console.WriteLine = loggingFunction;
console.WriteLine("Matt should not hack JavaScript");

// --------------------------------------------------------------------
// Code below is for: CONST, LET, VAR & NAMED FUNCTIONS
// --------------------------------------------------------------------

var oldWay = 1;
let newWay = 2; // THIS IS THE ONE YOU WANT
const wontChange = 3; // Cannot change the value of wontChange now

oldWay += 10;
newWay += 10;
// CAN'T DO THIS: wontChange += 10;

/**
 * Functions start with the word function.
 * They don't have a return type and the naming convention is camel-case.
 */
function variables() {
  // TODO: Declares a variable where the value cannot be changed
  const thisWontChange = "War. War never changes";

  // TODO: Declares a variable those value can be changed
  let dayOfWeek = 'Monday';
  dayOfWeek = "Sunday"; // TIME TRAVEL!

  // TODO: Declares a variable that will always be an array
  const pizzas = ["Glass Shards", "Arugula", "Pepperoni"];

  // TODO: Demonstrate console logging
  console.log(pizzas);
  console.log(dayOfWeek);
  console.log(thisWontChange, dayOfWeek, pizzas);
}

// NOTE: Everything in JavaScript is camelCase except ClassNames

/**
 * Functions can also accept parameters.
 * Notice the parameters do not have types.
 * @param {Number} param1 The first number to display
 * @param {Number} param2 The second number to display
 */
function printParameters(param1, param2) {
  // TODO: Discuss this
  console.log(`The value of param1 is ${param1}`);
  console.log(`The value of param2 is ${param2}`);
}

/*
########################
Function Overloading
########################

Function Overloading is not available in Javascript. 
*/

function add(num1, num2) {
  return num1 + num2 + 1000;
}

function add(num1, num2, num3) { // REPLACES the version on line 89
  return num1 + num2 + num3;
}



// --------------------------------------------------------------------
// Code below is for: EQUALITY & TRUTHY
// --------------------------------------------------------------------

// TODO: Discuss equality, == vs ===, and typeof

// TODO: Discuss truthy / falsy
// false, 0, '', null, undefined, and NaN are always falsy everything else is truthy

function testIsTruthy(value) {
  /*
  if (value != null && value != undefined) {

  }
  */

  if (value) {
    return "That is truthy";
  }
  return "That is falsy";
}



// --------------------------------------------------------------------
// Code below is for JS DATA TYPES
// --------------------------------------------------------------------

// Common data types are:

// - strings
let currentPresident = "Joe Biden";

// - numbers
let numStates = 50; // + other territories

// - arrays
let modules = ["C#", "Data & APIs", "JS enjoys your tears"];

// - object
let academicFellow = {
  first: 'Kevin',
  last: 'Teos',
  isAwesome: true,
  nicknames: ['Jevin', 'Waterboy', 'Matt WHY???']
};

// - undefined
let undefined1 = undefined;
let undefined2 = academicFellow.mistakes;
let undefined3 = academicFellow.isawesome;
let undefined4;
let nullValue = null;

// - functions
let addFunc = function addNumbers(x, y) {
  return x + y;
}

/**
 *  Objects are simple key-value pairs
    - values can be primitive data types
    - values can be arrays
    - or they can be functions
*/
function objects() {

  // Create an object
  const person = {
    firstName: "Bill",
    lastName: "Lumbergh",
    age: 42,
    employees: [
      "Peter Gibbons",
      "Milton Waddams",
      "Samir Nagheenanajar",
      "Michael Bolton",
    ],
  };

  // TODO: Log the object
  console.log(person);

  // TODO: Log the first and last name
  console.log(person.firstName, person.lastName);
  console.log(person.firstName + " " + person.lastName);

  // TODO: Log each employee
  for (let i = 0; i < person.employees.length; i++) {
    console.log(person.employees[i]);
  }

  return person;
}

function hoistingDemo() {
  var variable2; // undefined
  console.log(variable2);

  let variable1 = 10;
  // var variable2 = 20;
  variable2 = 20;

  console.log(variable1, variable2);
}








// --------------------------------------------------------------------
// Code below is for MATH AND STRINGS
// --------------------------------------------------------------------

/*
########################
Math Library
########################

A built-in `Math` object has properties and methods for mathematical constants and functions.
*/

function mathFunctions() {
  // TODO: Discuss this
  console.log("Math.PI : " + Math.PI);
  console.log("Math.LOG10E : " + Math.LOG10E);
  console.log("Math.abs(-10) : " + Math.abs(-10));
  console.log("Math.floor(1.99) : " + Math.floor(1.99));
  console.log("Math.ceil(1.01) : " + Math.ceil(1.01));
  console.log("Math.random() : " + Math.random());
}

/*
########################
String Methods
########################

The string data type has a lot of properties and methods similar to strings in Java/C#
*/

function stringFunctions(value) {
  // TODO: Discuss this
  console.log(`.length -  ${value.length}`);
  console.log(`.endsWith('World') - ${value.endsWith("World")}`);
  console.log(`.startsWith('Hello') - ${value.startsWith("Hello")}`);
  console.log(`.indexOf('Hello') - ${value.indexOf("Hello")}`);

  let text = "Hello World";
  console.log(text.substr(2, 5)); // start at 0, length 5
  console.log(text.substring(2, 5));

  /*
    Other Methods
        - split(string)
        - substr(number, number)
        - substring(number, number)
        - toLowerCase()
        - trim()
        - https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String
    */

    return true;
}









// --------------------------------------------------------------------
// Code below is for JS ARRAYS
// --------------------------------------------------------------------

let nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

// TODO: Add a function to filter out a specific value from an array
/**
 * Takes in an array of numbers and returns an array of all 
 * numbers but 5's
 * @param {Number[]} values the numbers to filter
 * @returns {Number[]} all numbers but 5's
 */
function allButFive(values) {
  let returnValues = [];

  for (let i = 0; i < values.length; i++) {
    if (values[i] != 5) {
      returnValues.push(values[i]);
    }
  }

  return returnValues;
}


// TODO: Cover Array indexers
// TODO: Cover Array.Push - Appends to an array

/**
 * 
 * @param {Number[]} values 
 */
function allButEven(values) {
  let returnValues = values.slice(); // Clone the entire array

  for (let i = 0; i < values.length; i++) {
    if (returnValues[i] % 2 == 0) { // If it's even
      returnValues.splice(i, 1, 'REMOVED');
    }
  }

  return returnValues;
}

// TODO: Cover Array.Splice
// TODO: Cover Array.Shift
// TODO: Cover Array.Unshift

let instructors = ['John', 'Brian', 'Steve', 'Rachelle', 'Matt', 'Jevin', 'Andrew'];

// TODO: Cover Array.Slice
// TODO: Cover Array.Concat
let piff = instructors.concat(['Voldemort', 'Hercules', 'Biff Tannen']);

// addNumbers(4,2);