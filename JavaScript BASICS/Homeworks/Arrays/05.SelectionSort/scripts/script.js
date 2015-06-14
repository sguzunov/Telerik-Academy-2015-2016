/*  Sorting an array means to arrange its elements in increasing order.
    Write a script to sort an array.
    Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
*/
var numbers = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1];
var i, j, temp;

for (i = 0; i < numbers.length - 1; i += 1) {
    for (j = i + 1; j < numbers.length; j += 1) {
        if (numbers[i] > numbers[j]) {
            temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
    }
}

console.log(numbers.join(','));


