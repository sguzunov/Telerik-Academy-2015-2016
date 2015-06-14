/*
 Write a script that finds the greatest of given 5 variables.
 Use nested if statements.
 */

function theBiggestOfFive(a, b, c, d, e) {
    if (a >= b && a >= c && a >= d && a >= e) {
        console.log(a);
    }
    else if (b >= a && b >= c && b >= d && b >= e) {
        console.log(b);
    }
    else if (c >= a && c >= b && c >= d && c >= e) {
        console.log(c);
    }
    else if (d >= a && d >= b && d >= c && d >= e) {
        console.log(d);
    }
    else if (e >= a && e >= b && e >= c && e >= d) {
        console.log(e);
    }
}

theBiggestOfFive(5, 2, 2, 4, 1);
theBiggestOfFive(-2, -22, 1, 0, 0);
theBiggestOfFive(-2, 4, 3, 2, 0);
theBiggestOfFive(0, -2.5, 0, 5, 5);
theBiggestOfFive(-3, -0.5, -1.1, -2, -0.1);