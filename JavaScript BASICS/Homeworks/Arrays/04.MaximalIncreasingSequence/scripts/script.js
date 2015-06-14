/* Write a script that finds the maximal increasing sequence in an array. */

var numbers = [3, 2, 3, 4, 2, 2, 5, 6, 7, 9, 10];
var i = 1,
    sequence = 1,
    maxSequence = 1,
    endIndex,
    startIndex;
var result = [];

for (i; i < numbers.length; i += 1) {
    if (numbers[i] > numbers[i - 1]) {
        sequence += 1;
    }
    else {
        sequence = 1;
    }

    if (sequence > maxSequence) {
        maxSequence = sequence;
        endIndex = i;
    }
}

result = numbers.splice(endIndex - maxSequence + 1, maxSequence);

console.log(result.join(','));
