// Write a script that finds the most frequent number in an array.

var numbers = [3, 2, 3, 4, 2, 2, 4, 5, 6, 7, 6, 6, 6, 6, 6, 6, 6, 6];
var i,
    j,
    count = 0,
    maxCount = 0,
    element,
    mostElement;

for (i = 0; i < numbers.length; i += 1) {
    element = numbers[i];
    count = 0;
    for (j = i; j < numbers.length; j += 1) {
        if (element === numbers[j]) {
            count += 1;

            if (count > maxCount) {
                maxCount = count;
                mostElement = element;
            }
        }
    }
}

console.log(maxCount);
