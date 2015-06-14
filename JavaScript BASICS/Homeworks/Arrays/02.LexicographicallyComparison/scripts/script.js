/* Write a script that compares two char arrays lexicographically (letter by letter). */

var isEqual = true;
var i = 0;

function compareTwoString(firstArray, secondArray) {
    for (i; i < Math.min(firstArray.length, secondArray.length) ; i += 1) {
        if (firstArray[i] > secondArray[i]) {
            isEqual = false;
            console.log('The first array ' + '"' + firstArray + '"' + ' is greater than the second one ' + '"' + secondArray + '"');
            break;
        }
        else if (firstArray[i] < secondArray[i]) {
            isEqual = false;
            console.log('The second array ' + '"' + secondArray + '"' + ' is greater than the first one ' + '"' + firstArray + '"');
            break;
        }
    }

    if (isEqual === true) {
        if (firstArray.length > secondArray.length) {
            console.log('The first array ' + '"' + firstArray + '"' + 'is greater than the second one ' + '"' + secondArray + '"');
        }
        else if (firstArray.length < secondArray.length) {
            console.log('The second array ' + '"' + secondArray + '"' + ' is greater than the first one ' + '"' + firstArray + '"');
        }
        else {
            console.log('The first array ' + '"' + firstArray + '"' + ' and the second array ' + '"' + secondArray + '"' + ' are equal');
        }
    }
}

var firstArray = 'c';
var secondArray = 'b';

compareTwoString(firstArray, secondArray);
