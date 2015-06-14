/*
 Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.
 */

var arr1 = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'];
var arr2 = ['ten', 'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen'];
var arr3 = ['twenty', 'thirty', 'fourty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety'];

function sayNumber(number) {
    var i = 0;
    var allDigits = [];

    if (number === 0) {
        console.log(arr1[0]);
    }
    else {
        while (number !== 0) {
            allDigits[i] = number % 10;
            number = (number / 10) | 0;
            i += 1;
        }
        if (i === 1) {
            console.log(arr1[allDigits[0]]);
        }
        else if (i === 2) {
            if (allDigits[1] === 1) {
                console.log(arr2[allDigits[0]]);
            }
            else if (allDigits[1] !== 1 && allDigits[0] === 0) {
                console.log(arr3[allDigits[1] - 2]);
            }
            else {
                console.log(arr3[allDigits[1] - 2] + ' ' + arr1[allDigits[0]]);
            }
        }
        else if (i === 3) {
            if (allDigits[0] === 0 && allDigits[1] === 0) {
                console.log(arr1[allDigits[2]] + ' ' + 'hundred');
            }
            else if (allDigits[1] === 0 && allDigits[0] !== 0) {
                console.log(arr1[allDigits[2]] + ' ' + 'hundred and ' + arr1[allDigits[0]]);
            }
            else if (allDigits[1] === 1 && allDigits[0] === 0) {
                console.log(arr1[allDigits[2]] + ' ' + 'hundred and ' + arr2[0]);
            }
            else if (allDigits[1] === 1 && allDigits[0] !== 0) {
                console.log(arr1[allDigits[2]] + ' ' + 'hundred and ' + arr2[allDigits[0]]);
            }
            else if (allDigits[1] !== 1 && allDigits[0] === 0) {
                console.log(arr1[allDigits[2]] + ' ' + 'hundred and ' + arr3[allDigits[1] - 2]);
            }
            else {
                console.log(arr1[allDigits[2]] + ' ' + 'hundred and ' + arr3[allDigits[1] - 2] + ' ' + arr1[allDigits[0]]);
            }
        }
    }
}

sayNumber(0);
sayNumber(9);
sayNumber(10);
sayNumber(12);
sayNumber(19);
sayNumber(25);
sayNumber(98);
sayNumber(89)
sayNumber(273);
sayNumber(400);
sayNumber(501);
sayNumber(617);
sayNumber(711);
sayNumber(999);