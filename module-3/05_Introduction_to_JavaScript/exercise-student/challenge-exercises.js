/*
1. **iqTest** Bob is preparing to pass an IQ test. The most frequent task in this test 
    is to find out which one of the given numbers differs from the others. Bob observed
    that one number usually differs from the others in evenness. Help Bob — to check his 
    answers, he needs a program that among the given numbers finds one that is different in 
    evenness, and return the position of this number. _Keep in mind that your task is to help 
    Bob solve a real IQ test, which means indexes of the elements start from 1 (not 0)_

		iqTest("2 4 7 8 10") → 3 //third number is odd, while the rest are even
		iqTest("1 2 1 1") → 2 // second number is even, while the rest are odd
		iqTest("") → 0 // there are no numbers in the given set
        iqTest("2 2 4 6") → 0 // all numbers are even, therefore there is no position of an odd number
*/

function iqTest(stringOfNumbers) {
    if (stringOfNumbers.length < 3) {
        return 0;
    }

    let arrayOfNumbers = stringOfNumbers.split(" ");
    let even=0;
    let odd=0;

    for (let i=0;i<arrayOfNumbers.length;i++) {

        if (arrayOfNumbers[i]%2==0) {
            even++;
        }
        if (arrayOfNumbers[i]%2==1) {
            odd++;
        }
    }

    for (let i=0;i<arrayOfNumbers.length;i++) {
        if (even==1 && arrayOfNumbers[i]%2==0) {
            return i+1;
        }

        if (odd==1 && arrayOfNumbers[i]%2==1) {
            return i+1;
        }
    }

    return 0;
}

/*
2. **titleCase** Write a function that will convert a string into title case, given an optional 
    list of exceptions (minor words). The list of minor words will be given as a string with each 
    word separated by a space. Your function should ignore the case of the minor words string -- 
    it should behave in the same way even if the case of the minor word string is changed.


* First argument (required): the original string to be converted.
* Second argument (optional): space-delimited list of minor words that must always be lowercase
except for the first word in the string. The JavaScript tests will pass undefined when this 
argument is unused.

		titleCase('a clash of KINGS', 'a an the of') // should return: 'A Clash of Kings'
		titleCase('THE WIND IN THE WILLOWS', 'The In') // should return: 'The Wind in the Willows'
        titleCase('the quick brown fox') // should return: 'The Quick Brown Fox'
*/

function titleCase(title, ignore) {
    // split the title into an array of words
    let titleWords = title.split(" ");
    
    // capitalize the first letter of the first word
    titleWords[0] = titleWords[0].substr(0,1).toUpperCase() + titleWords[0].substr(1,titleWords[0].length-1).toLowerCase();
    
    // check to see if there is an ignore list
    if (ignore) {
    
        // split the ignore words into an array of words
        let ignoreWords = ignore.split(" ");
    
        // if there is an ignore list, cycle through the words in the title to see if they're on the ignore list
        for (let i=1;i<titleWords.length;i++) {
            let onTheList = false;
            for (let u=0;u<ignoreWords.length;u++) {
                // check to see if the word is on the list
                if (titleWords[i].toUpperCase()===ignoreWords[u].toUpperCase()) {
                    onTheList = true;
                }
            }
            // if on the list, lowercase the word
            if (onTheList) {
                titleWords[i] = titleWords[i].toLowerCase();
            } else {
            // if they're not on the list, capitalize the first letter and lowercase the rest
                titleWords[i] = titleWords[i].substr(0,1).toUpperCase() + titleWords[i].substr(1,titleWords[i].length-1).toLowerCase();
            }
            
        }
    } else {
        // if there is no ignore list, each word should have its first letter capitalized
        for (let i=1;i<titleWords.length;i++) {
            titleWords[i] = titleWords[i].substr(0,1).toUpperCase() + titleWords[i].substr(1,titleWords[i].length-1);   
        }
    }

    let answer = "";
    for (let i=0;i<titleWords.length-1;i++) {
        answer += titleWords[i] + " ";
    }

    answer += titleWords[titleWords.length-1];

    return answer;

}