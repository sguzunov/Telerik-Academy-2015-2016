/* Write an expression that checks if given positive integer number n (n ≤ 100) is prime. */

function isPrumeNumber(number) {
    var i = 2;

    if (number > 1) {
        for (i; i < number; i += 1) {
            if (number % i === 0) {
                return false;
            }
        }
    }
    else {
        return false;
    }

    return true;
}

var numbers = [1, 2, 3, 4, 9, 37, 97, 51, -3, 0];

var i = 0;
for (i; i < numbers.length; i += 1) {
    console.log(isPrumeNumber(numbers[i]));
}