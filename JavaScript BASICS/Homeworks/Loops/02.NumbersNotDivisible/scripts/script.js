/* Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time */

function notDivisible(n) {
    var i = 0;

    for (i; i <= n; i += 1) {
        if (!(i % 3 === 0 && i % 7 === 0)) {
            console.log(i);
        }
    }
}

notDivisible(100);