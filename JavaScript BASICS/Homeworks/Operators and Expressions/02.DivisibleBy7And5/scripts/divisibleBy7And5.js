/* Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. */

var numbers = [5, 7, 35, 40, 54];

function isDivisible(number) {
    var isTrue = true;

    return ((number % 5 === 0) && (number % 7 === 0)) ? isTrue : !isTrue;
}

var i = 0;
for (i; i < numbers.length; i += 1) {
    console.log(isDivisible(numbers[i]));
}