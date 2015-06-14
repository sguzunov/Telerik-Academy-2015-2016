/*
 Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
 Use a sequence of if operators.
 */

function checkSign(a, b, c) {
    if (a === 0 || b === 0 || c === 0) {
        console.log(0);
    }
    else if (a > 0) {
        if (b > 0 && c > 0) {
            console.log('+');
        }
        else if (b > 0 && c < 0) {
            console.log('-');
        }
        else if (b < 0 && c > 0) {
            console.log('-');
        }
        else if (b < 0 && c < 0) {
            console.log('+');
        }
    }
    else if (a < 0) {
        if (b > 0 && c > 0) {
            console.log('-');
        }
        else if (b > 0 && c < 0) {
            console.log('+');
        }
        else if (b < 0 && c > 0) {
            console.log('+');
        }
        else if (b < 0 && c < 0) {
            console.log('-');
        }
    }
}

console.log(checkSign(-1, -0.5,-5.1));