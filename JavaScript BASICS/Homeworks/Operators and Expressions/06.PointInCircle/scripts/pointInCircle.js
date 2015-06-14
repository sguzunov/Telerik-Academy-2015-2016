/* Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius */

function isInCircle(a, b) {
    var diameter = Math.sqrt(a * a + b * b);

    return diameter <= 5 ? true : false;
}

console.log(isInCircle(0, 1));
console.log(isInCircle(-5, 0));
console.log(isInCircle(-4, 5));
console.log(isInCircle(1.5, -3));
console.log(isInCircle(-4, -3.5));
console.log(isInCircle(100, -30));
console.log(isInCircle(0, 0));
console.log(isInCircle(0.2, -0.8));
console.log(isInCircle(0.9, -4.93));
console.log(isInCircle(2, 2.656));
