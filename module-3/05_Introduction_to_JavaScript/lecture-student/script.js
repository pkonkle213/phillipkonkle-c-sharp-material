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

// Console.WriteLine won't work here


// TODO: Or will it?



// --------------------------------------------------------------------
// Code below is for: CONST, LET, VAR & NAMED FUNCTIONS
// --------------------------------------------------------------------

/**
 * Functions start with the word function.
 * They don't have a return type and the naming convention is camel-case.
 */
function variables() {
  // TODO: Declares a variable where the value cannot be changed
  // TODO: Declares a variable those value can be changed
  // TODO: Declares a variable that will always be an array
  // TODO: Demonstrate console logging
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

function add(num1, num2, num3) {
  return num1 + num2 + num3;
}



// --------------------------------------------------------------------
// Code below is for: EQUALITY & TRUTHY
// --------------------------------------------------------------------

// TODO: Discuss equality, == vs ===, and typeof

// TODO: Discuss truthy / falsy
// false, 0, '', null, undefined, and NaN are always falsy everything else is truthy




// --------------------------------------------------------------------
// Code below is for JS DATA TYPES
// --------------------------------------------------------------------

// Common data types are:

// - strings

// - numbers

// - arrays

// - undefined

// - object

// - functions


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

  // TODO: Log the first and last name

  // TODO: Log each employee

  return person;
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

  /*
    Other Methods
        - split(string)
        - substr(number, number)
        - substring(number, number)
        - toLowerCase()
        - trim()
        - https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String
    */
}









// --------------------------------------------------------------------
// Code below is for JS ARRAYS
// --------------------------------------------------------------------

// TODO: Add a function to filter out a specific value from an array
// TODO: Cover Array indexers
// TODO: Cover Array.Push - Appends to an array
// TODO: Cover Array.Splice
// TODO: Cover Array.Shift
// TODO: Cover Array.Unshift
// TODO: Cover Array.Slice
// TODO: Cover Array.Concat
