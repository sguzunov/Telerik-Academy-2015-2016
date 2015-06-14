/*
 Sort 3 real values in descending order.
 Use nested if statements.
 */

function sortThreeNumbers(a, b, c) {
    if (a >= b && a >= c) {
        if (b >= c) {
            console.log(a, b, c);
        }
        else {
            console.log(a, c, b);
        }
    }
    else if (b >= a && b >= c) {
        if (a >= c) {
            console.log(b, a, c);
        }
        else {
            console.log(b, c, a);
        }
    }
    else if (c >= a && c >= b) {
        if (a >= b) {
            console.log(c, a, b);
        }
        else {
            console.log(c, b, a);
        }
    }
}

sortThreeNumbers(5, 1, 2);
sortThreeNumbers(-2, -2, 1);
sortThreeNumbers(-2, 4, 3);
sortThreeNumbers(0, -2.5, 5);
sortThreeNumbers(-1.1, -0.5, -0.1);
sortThreeNumbers(10, 20, 30);
sortThreeNumbers(1, 1, 1);