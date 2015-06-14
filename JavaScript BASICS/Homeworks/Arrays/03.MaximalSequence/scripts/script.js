/* Write a script that finds the maximal sequence of equal elements in an array. */

var numbers = [4, 2, 1, 8, 8, 8, 8, 10, 10, 10];

var sequence = 1,
    maxSequence = 1,
    element = 0,
    i = 0,
    j = 0;

for (i; i < numbers.length - 1; i += 1) {
    if (numbers[i] === numbers[i + 1]) {
        sequence++;

        if (sequence > maxSequence) {
            maxSequence = sequence;
            element = numbers[i];
        }
    }
    else {
        sequence = 1;
    }
}

for (j; j < maxSequence; j += 1) {
    console.log(element);
}

