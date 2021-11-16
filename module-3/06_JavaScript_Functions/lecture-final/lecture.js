/**
 * All named functions will have the function keyword and
 * a name followed by parentheses.
 * 
 * @returns {number} 1
 */
function returnOne() {
  return 1;
}

returnOne(1, 2, 3);

/**
 * Functions can also take parameters. These are just variables that are filled
 * in by whoever is calling the function.
 *
 * Also, we don't *have* to return anything from the actual function.
 *
 * @param {any} value the value to print to the console
 */
function printToConsole(value) {
  console.log(value);
}

/**
 * Takes an array and returns a new array of only numbers that are
 * multiples of 3
 *
 * @param {number[]} numbersToFilter numbers to filter through
 * @returns {number[]} a new array with only those numbers that are
 *   multiples of 3
 */
function allDivisibleByThree(numbersToFilter) {
  let result = [];

  for (let num of numbersToFilter) {
    // Only accept nums divisible by 3
    if (num % 3 === 0) {
      result.push(num);
    }
  }

  return result;
}

function allDivisibleByTwo(numbers) {
  return numbers.filter((num) => num % 2 === 0);
}

/**
 * Functions can return earlier before the end of the function. This could be useful
 * in circumstances where you may not need to perform additional instructions or have to
 * handle a particular situation.
 * In this example, if the firstParameter is equal to 0, we return secondParameter times 2.
 * Observe what's printed to the console in both situations.
 * 
 * @param {number} firstParameter the first parameter
 * @param {number} secondParameter the second parameter
 * @returns {number} the result of the operation
 */
function returnBeforeEnd(firstParameter, secondParameter) {
  console.log("This will always fire.");

  if (firstParameter == 0) {
    console.log("Returning secondParameter times two.");
    return secondParameter * 2;
  }

  //this only runs if firstParameter is NOT 0
  console.log("Returning firstParameter + secondParameter.");
  return firstParameter + secondParameter;
}

/**
 * Scope is defined as where a variable is available to be used.
 *
 * If a variable is declare inside of a block, it will only exist in
 * that block and any block underneath it. Once the block that the
 * variable was defined in ends, the variable disappears.
 */
function scopeTest() {
  // This variable will always be in scope in this function
  let inScopeInScopeTest = true;

  if (true) {
    // this variable lives inside this block and doesn't
    // exist outside of the block
    let scopedToBlock = inScopeInScopeTest;
  }

  // scopedToBlock doesn't exist here so an error will be thrown
  if (inScopeInScopeTest && scopedToBlock) {
    console.log("This won't print!");
  }
}

/**
 * Create an addThings method that takes in any number of number 
 * parameters and returns their total
 */
function addThings(...otherArgs) {

  console.log(arguments); // Don't recommend this
  console.warn(otherArgs);

  let argsArray = Array.from(arguments);

  let sum = 0;

  for (let num of otherArgs) {
    sum += num;
  }

  return sum;
}






/**
 * This version makes sure that no parameters are ever missing. If
 * someone calls this function without parameters, we default the
 * values to 0. However, it is impossible in JavaScript to prevent
 * someone from calling this function with data that is not a number.
 * Call this function multiplyNoUndefined
 *
 * @param {number} [firstParameter=0] the first parameter to multiply
 * @param {number} [secondParameter=0] the second parameter to multiply
 * @returns {number} the result of the multiplication
 */
function multiplyNoUndefined(firstParameter = 0, secondParameter = 0) {
  return firstParameter * secondParameter;
}



 // Let's document this function

/**
 * Builds a descriptive sentence about the user in the parameters.
 * @param {string} name the name of user. Probably Kevin.
 * @param {number} age the age of the user.
 * @param {string[]} [listOfQuirks=[]] an array of quirks about this person. Defaults to an empty array.
 * @param {string} [separator=', '] how to separate individual quirks. Defaults to a comma.
 * @returns {string} a descriptive sentence
 */
function createSentenceFromUser(name, age, listOfQuirks = [], separator = ', ') {

  if (!name) {
    throw 'YOU FOOL! I NEED A NAME';
  }

  let description = `${name} is currently ${age} years old. Their quirks are: `;
  return description + listOfQuirks.join(separator);
}


/**
 * Write a function called multiplyTogether that multiplies two 
 * numbers together. But 
 * what happens if we don't pass a value in? What happens if the 
 * value is not a number?
 *
 * @param {number} firstParameter the first parameter to multiply
 * @param {number} secondParameter the second parameter to multiply
 * @returns {number} the result of the multiplication
 */
function multiplyTogether(firstParameter, secondParameter) {
  return firstParameter * secondParameter;
}

// Store our existing multiplyTogether function into a variable
let multFunc0 = multiplyTogether;

// Create a multiply function and store it in a variable
let multFunc = function multiplyThings(x, y) {
  return x * y;
}

console.log(multFunc(6, 7));

// Create an anonymous multiply function and store it in a variable
let multFunc2 = function(x,y) {
  return x * y;
}
 
// Create an arrow multiply function and store it in a variable
let multFunc3 = (x,y) => {
  let total = 0;
  total = x * y;
  return total;
}

// Create a single line arrow multiply function and store it in a variable
let multFunc4 = (x,y) => x * y;



function performMath(x, y, mathFunc) {
  let result = mathFunc(x, y);

  return result;
}

performMath(5, 2, multFunc4);

performMath(5, 2, (x,y) => x ** y);

function isEven(num) {
  return num % 2 === 0;
}

let myNums = [1,2,3,4,5];
console.log("Even numbers", myNums.filter(isEven));


// Create an array of movies
let movies = [
  {
    name: 'Jurassic Park',
    year: 1993,
    rating: 'PG-13',
    isAwesome: true,
    deaths: 14,
    summary: 'Pay your developers or dinos get loose'
  },
  {
    name: 'Coming to America',
    year: 1990,
    rating: 'R',
    isAwesome: true,
    deaths: 33,
    summary: 'Pterodactyls take Eddie Murphy to America (as a prince)'
  },
  {
    name: 'Office Space',
    year: 2042,
    rating: 'R',
    isAwesome: true,
    summary: 'Printer suck',
    deaths: 1,
    piecesOfFlair: 12,
  },
  {
    name: 'The Fourth Kind of Room',
    year: 1944,
    rating: 'G',
    isAwesome: false,
    deaths: 0,
    summary: 'Kevin discovers a room where they store four things. One is missing'
  }
];

// forEach - Loop over something
let movieDisplayFunc = function(someMovie) {
  console.log(someMovie.name + ' (' + someMovie.year + ')');
}

/*
let movieArrowFunc = (m) => {
  console.log(m.name + ' (' + m.year + ')');
}
*/

//movies.forEach(movieDisplayFunc);

movies.forEach((m) => console.log(m.name + ' (' + m.year + ')'));

// Find - Find a specific movie
let dvd = movies.find(m => m.rating === 'PG');
console.log('Here Kevin, you can borrow', dvd);

// FindIndex - Find a movie by its index
let index = movies.findIndex(m => m.name === 'Office Space');
console.log('Office Space is at index ' + index);

// Filter - Only get movies of a certain rating
let acceptableMovies = movies.filter((movie) => movie.rating !== 'R' && movie.rating != 'XXX');
console.log('Your movie choices are', acceptableMovies);

// Map - Select all movie titles
let movieNames = [];
for (let movie of movies) {
  movieNames.push(movie.name);
}
console.log('My movie names are', movieNames);

let names = movies.map((movie) => movie.year);
console.log('Movie names 2', names);

// Reduce - Pull together the total runtime of all movies
let totalKillCount = 0;
for (let movie of movies) {
  totalKillCount += movie.deaths;
}
console.log('The total kill count is', totalKillCount);

let total2 = movies.reduce(
  // Function to use. Gets called once per movie, with a running total and a current movie
  (totalDeaths, currentMovie) => totalDeaths + currentMovie.deaths, 
  // Initial total
  0
);
console.log('The reduced total is ', total2);

/**
 * Takes an array and, using the power of anonymous functions, generates
 * their sum.
 *
 * @param {number[]} numbersToSum numbers to add up
 * @returns {number} sum of all the numbers
 */
function sumAllNumbers(numbersToSum) {
  
}

// Create a function that gets movies that match a specific function
function findMoviesOfInterest(movies, filterFunc) {
  let filteredMovies = movies.filter((movie) => filterFunc(movie));
  // Equivalent: let filteredMovies = movies.filter(filterFunc);

  return filteredMovies;
}

console.log(findMoviesOfInterest(movies, (m) => m.deaths > 5));
console.log(findMoviesOfInterest(movies, (m) => m.year <= 1990));
console.log(findMoviesOfInterest(movies, (m) => m.isAwesome));

