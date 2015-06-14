/* Write a script that prints all the numbers from 1 to N. */

function printNumbersToN(n) {
    var i = 1;

    for (i; i <= n; i += 1) {
        console.log(i);
    }
}

console.log('Number to 5 :');
printNumbersToN(5);

console.log('Numbers to 11 :');
printNumbersToN(11);