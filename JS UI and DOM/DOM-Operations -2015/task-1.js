/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id) +
  * Any of the function params is missing +
  * Any of the function params is not as described +
  * Any of the contents is neither `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function() {
    function areValidContents(contents) {
        var i,
            len;
        for (i = 0, len = contents.length; i < len; i += 1) {
            if (typeof(contents[i]) !== 'string' && isNaN(contents[i])) {
                return false;
            }
        }

        return true;
    }

    return function(element, contents) {
        var i,
            len,
            item = document.createElement('div'),
            container = document.createDocumentFragment();

        if (arguments.length < 2) {
            throw new Error('Number of arguments must be 2.');
        }

        if (!element || !contents) {
            throw new Error('Arguments cannot be null or undefined.');
        }

        if (typeof(element) === 'string') {
            element = document.getElementById(element);
        }

        if (typeof(element) !== 'string' && !(element instanceof(HTMLElement))) {
            throw new Error('Element is a correct format.');
        }

        if (!areValidContents(contents)) {
            throw new Error('Invalid contents.');
        }

        if (!element) {
            throw new Error('The is no element with this id.');
        }


        for (i = 0, len = contents.length; i < len; i += 1) {
            item.innerHTML = contents[i];

            container.appendChild(item.cloneNode(true));
        }

        element.innerHTML = '';
        element.appendChild(container);


    };
};
