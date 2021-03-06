/** Write a function called isAdmitted. It will check entrance
 * scores and return true if the student is admitted and
 * false if rejected. It takes three parameters:
 *
 *     * gpa
 *     * satScore (optional)
 *     * recommendation (optional)
 *
 * Admit them--return true--if:
 * gpa is above 4.0 OR
 * SAT score is above 1300 OR
 * gpa is above 3.0 and they have a recommendation OR
 * SAT score is above 1200 and they have a recommendation
 * OTHERWISE reject it
 *
 * @param {number} gpa the GPA of the student, between 4.2 and 1.0
 * @param {number} [satScore=0] the student's SAT score
 * @param {boolean} [recommendation=false] does the student have a recommendation
 * @returns {boolean} true if they are admitted
 */

 function isAdmitted(gpa,satScore=0,recommendation=false) {
     if (gpa>4 || satScore>1300 || (gpa > 3 && recommendation===true) || (satScore > 1200 && recommendation===true)) {
         return true;
     }

     return false;
 }

let unfilteredArray = [1, 2, 3, 4, 5, 6];
/**
 * Write a function called useParameterToFilterArray that takes an anonymous
 * function and uses that in the `unfilteredArray` filter function. Return the result.
 *
 * @param {function} filterFunction the function to filter with
 * @returns {number[]} the filtered array
 */

let useParameterToFilterArray = function(filterFunction) {
    let number = unfilteredArray.filter((num) => filterFunction(num));
    return number;
}

/**
 * Write a function called makeNumber that takes two strings
 * of digits, concatenates them together, and returns
 * the value as a number.
 *
 * So if two strings are passed in "42293" and "443", then this function
 * returns the number 42293443.
 *
 * @param {string} first the first string of digits to concatenate
 * @param {string} [second=''] the second string of digits to concatenate
 * @returns {number} the resultant number
 */

 function makeNumber(string1, string2='') {
     return parseInt(string1 + string2);
 }

/**
 * Write a function called addAll that takes an unknown number of parameters
 * and adds all of them together. Return the sum.
 *
 * @param {...number} num a series of numbers to add together
 * @returns {number} the sum of all the parameters (or arguments)
 */

function addAll(...num) {
    let sum = 0;
    for (let number of num) {
        sum += number;
    }
    return sum;
}

/*
 * Write and document a function called makeHappy that takes
 * an array and prepends 'Happy ' to the beginning of all the
 * words and returns them as a new array. Use the `map` function.
 */

 /**
  * Takes in an array of words, adds 'Happy ' to the beginning of each word,
  * and returns the resulting array
  * @param  {string[]} words a series of words to add 'Happy ' to
  * @returns {string[]} the resulting array of Happy words
  */
 function makeHappy(words) {
    let happyWords = words.map(word => 'Happy ' + word);
    return happyWords;
 }

/*
 * Write and document a function called getFullAddressesOfProperties
 * that takes an array of JavaScript objects containing the
 * following keys:
 *     * streetNumber
 *     * streetName
 *     * streetType
 *     * city
 *     * state
 *     * zip
 *
 * and returns an array of strings that turns the JavaScript objects
 * into a mailing address in the form of:
 *     streetNumber streetName streetType city state zip
 *
 * Use `map` and an anonymous function.
 */

 /**
  * Takes in an array of address objects and turns them into an array of a mailing address string
  * @param {address[]} arrayOfAddresses an array of address objects
  * @return {string[]} the resulting array of string street addresses
  */
function getFullAddressesOfProperties(arrayOfAddresses) {
    let fullAddresses = arrayOfAddresses.map(
        (currentAddress) => (currentAddress.streetNumber + " " +
            currentAddress.streetName + " " +
            currentAddress.streetType + " " +
            currentAddress.city + " " +
            currentAddress.state + " " +
            currentAddress.zip)
    );
    return fullAddresses;
}

/*
 * Write and document a function called findLargest.
 *
 * Using `forEach`, find the largest element in an array.
 * It must work for strings and numbers.
 */

/**
 * From an array, this finds the largest number or the latest in the alphabet string
 * @param {string[], number[]} arrayOfStuff array of numbers or strings
 * @return {string, number} returns the greatest number or the string the is last in the alphabet
 */
function findLargest(arrayOfStuff) {
    let greatest = arrayOfStuff[0];
    arrayOfStuff.forEach((thing) => {
        if (thing > greatest) {
            greatest = thing;
        }
    })
return greatest;
}

/*
 * CHALLENGE
 * Write and document a function called getSumOfSubArrayValues.
 *
 * Take an array of arrays, adds up all sub values, and returns
 * the sum. For example, if you got this array as a parameter:
 * [
 *   [1, 2, 3],
 *   [2, 4, 6],
 *   [5, 10, 15]
 * ];
 *
 * The function returns 48. To do this, you will use two nested `reduce`
 * calls with two anonymous functions.
 *
 * Read the tests to verify you have the correct behavior.
 */

 function getSumOfSubArrayValues(arrayOfArrays) {

}