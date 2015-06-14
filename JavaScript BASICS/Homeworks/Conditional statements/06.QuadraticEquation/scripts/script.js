/*
 Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
Calculates and prints its real roots.
 */

function calculateEquation(a, b, c) {
    var D = (b * b) - (4 * a * c);

    if (D < 0) {
        console.log('no real roots');
    }
    else if (D === 0) {
        var x = -b / (2 * a);

        console.log('x1=x2=' + ' ' + x);
    }
    else if (D > 0) {
        var x1 = (-b + Math.sqrt(D)) / (2 * a);
        var x2 = (-b - Math.sqrt(D)) / (2 * a);

        console.log('x1=' + ' ' + x1 + ' ; ' + 'x2=' + ' ' + x2);
    }
}


calculateEquation(2, 5, -3);
calculateEquation(-1, 3, 0);
calculateEquation(-0.5, 4, -8);
calculateEquation(5, 2, 8);