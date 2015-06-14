// Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.

var numbers = [3, 12, 3, 4, 22, 2, 55, 5, 6, 7, 87, 76, 56, 62, 13, 11, 1, 250, 55, 101];
var indMin = 0,
    indMax = numbers.length - 1;
element = 56;

function orderBy(a, b) {
    return a - b;
}

numbers.sort(orderBy);

function binarySearch(numbers, indMin, indMax, element) {
    while (indMin <= indMax) {
        var indMid = (indMax + indMin) / 2 | 0;
        if (numbers[indMid] === element) {
            return indMid;
        }
        else if (numbers[indMid] < element) {
            indMin = indMid + 1;
        }
        else {
            indMax = indMid - 1;
        }
    }
}

var result = binarySearch(numbers, indMin, indMax, element);

console.log('Sorted array: ' + numbers.join(','));
console.log(result);