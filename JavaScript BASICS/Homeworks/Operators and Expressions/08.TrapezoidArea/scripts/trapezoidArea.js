/* Write an expression that calculates trapezoid's area by given sides a and b and height h. */

function area(a, b, h) {
    if (checkForPositiveNumbers(a, b, h)) {
        return (a + b) / 2 * h;
    }
    else {
        var error = 'Incorrect input data!';
        return error;
    }
}

function checkForPositiveNumbers(a, b, c) {
    if (a > 0 && b > 0 && c > 0) {
        return true;
    }
    else return false;
}

console.log(area(5, 7, 12));
console.log(area(2, 1, 33));
console.log(area(8.5, 4.3, 2.7));
console.log(area(100, 200, 300));
console.log(area(0.222, 0.333, 0.555));