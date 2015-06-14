/* Write an expression that checks for given integer if its third digit (right-to-left) is 7 */

var a = 3710;
var b = 5;
var c = 1234;
var d = 577;
var e = 706;

function isThirdDigitSeven(number) {
    number = number / 100 | 0;
    var x = number % 10;

    return x === 7 ? true : false;
}

console.log(isThirdDigitSeven(a));
console.log(isThirdDigitSeven(b));
console.log(isThirdDigitSeven(c));
console.log(isThirdDigitSeven(d));
console.log(isThirdDigitSeven(e));