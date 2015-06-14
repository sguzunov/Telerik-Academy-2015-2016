/* Write a script that finds the lexicographically min and max property in document, window and navigator objects. */

function findProperty(obj) {
    var min = '';
    var max = '';

    for (var prop in obj) {
        if (!min) {
            min = prop;
        }

        if (!max) {
            max = prop;
        }

        if (min > prop) {
            min = prop;
        }

        if (max < prop) {
            max = prop;
        }
    }

    console.log('min: ' + min);
    console.log('max: ' + max);
}


console.log('document');
findProperty(document);
console.log('window');
findProperty(window);
console.log('navigator');
findProperty(navigator);