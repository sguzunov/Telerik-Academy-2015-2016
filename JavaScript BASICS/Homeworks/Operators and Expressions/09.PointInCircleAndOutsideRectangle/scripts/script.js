/* Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2). */

function isInsideCircle(x, y, cx, cy, r) {
    return (x - cx) * (x - cx) + (y - cy) * (y - cy) < r * r;
}

function isOutsideRectangle(x, y, top, bottom, left, right) {
    return !(x >= left && x <= right && y <= top && y >= bottom);
}

console.log(isInsideCircle(1, 2, 1, 1, 3) && isOutsideRectangle(1, 2, 1, -1, -1, 5) ? true : false);
console.log(isInsideCircle(2.5, 2, 1, 1, 3) && isOutsideRectangle(2.5, 2, 1, -1, -1, 5) ? true : false);
console.log(isInsideCircle(0, 1, 1, 1, 3) && isOutsideRectangle(0, 1, 1, -1, -1, 5) ? true : false);
console.log(isInsideCircle(2, 1.5, 1, 1, 3) && isOutsideRectangle(2, 1.5, 1, -1, -1, 5) ? true : false);
console.log(isInsideCircle(-100, -100, 1, 1, 3) && isOutsideRectangle(-100, -100, 1, -1, -1, 5) ? true : false);
