/*
 Write a script that finds the biggest of three numbers.
 Use nested if statements.
 */


function theBiggestOfThreeNumbers(a, b, c) {
    if (a >= b) {
        if (a >= c) {
            console.log(a);
        }
        else {
            console.log(c);
        }
    }
    else if (b >= a) {
        if (b >= c) {
            console.log(b);
        }
        else {
            console.log(c);
        }
    }
}

theBiggestOfThreeNumbers(-0.1, -0.5, -1.1);