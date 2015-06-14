/*
    Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
    The bits are counted from right to left, starting from bit #0.
    The result of the expression should be either 1 or 0.
 */

function thirdBit(number) {
    var mask = 1;
    mask <<= 3;
    var result = number & mask;
    result >>= 3;

    return result;
}

console.log(thirdBit(5));
console.log(thirdBit(8));
console.log(thirdBit(0));
console.log(thirdBit(15));
console.log(thirdBit(5343));
console.log(thirdBit(62241));
