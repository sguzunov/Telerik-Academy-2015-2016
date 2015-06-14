/* Write an expression that checks if given integer is odd or even. */

for (var i = 0; i < 10; i += 1) {
    console.log("Number" + " " + i + " " + "is" + " " + isOddOrEven(i));
}

function isOddOrEven(number) {
    var rest = number % 2;

    return (rest === 0) ? "Even" : "Odd";
}