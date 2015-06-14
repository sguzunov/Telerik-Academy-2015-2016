/* Write a script that finds the max and min number from a sequence of numbers. */

var numbers = [];

for (var i = 0; i < 10; i += 1) {
    numbers[i] = (Math.random() * 1000) | 0;
}

console.log('All the numbers:' + ' ' + numbers.join(','));

var maxNumber = numbers[0];
var minNumber = numbers[0];

for (var i = 0; i < numbers.length; i += 1) {
    if (maxNumber <= numbers[i]) {
        maxNumber = numbers[i];
    }
    if (minNumber >= numbers[i]) {
        minNumber = numbers[i];
    }
}

console.log(maxNumber);
console.log(minNumber);