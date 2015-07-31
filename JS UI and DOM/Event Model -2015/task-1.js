/* globals $ */

/* 
Create a function that takes an id or DOM element and:
* If an id is provided, select the element +
* Finds all elements with class `button` or `content` within the provided element +
  * Change the content of all `.button` elements with "hide" +
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and: 
    * If the `.content` is visible: 
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided DOM element is non-existant
  * The id is either not a string or does not select any DOM element
*/

function solve() {
    function onButtonsClicked(ev) {
        if (ev.target.className === 'button') {
            changeVisibility(ev.target);
        }
    }

    function changeVisibility(button) {
        var nextElement = button.nextElementSibling;
        while (nextElement && nextElement.className !== 'content') {
            nextElement = nextElement.nextElementSibling;
        }

        if (nextElement.style.display === '') {
            nextElement.style.display = 'none';
            button.innerHTML = 'show';
        } else if (nextElement.style.display === 'none') {
            nextElement.style.display = '';
            button.innerHTML = 'hide';
        }
    }

    return function(selector) {
        var selectorContents,
            i,
            len,
            currentItem;

        // Validation of parameter
        if (selector === undefined) {
            throw new Error('Undefined cannot be an argument.');
        }

        if (typeof(selector) !== 'string' && !(selector instanceof(HTMLElement))) {
            throw new Error('Invalid type of argument.');
        }

        if (typeof(selector) === 'string') {
            selector = document.getElementById(selector);
        }

        if (selector === null) {
            throw new Error('The ID selects nothing');
        }

        selectorContents = document.querySelectorAll('.button, .content');

        for (i = 0, len = selectorContents.length; i < len; i += 1) {
            currentItem = selectorContents[i];

            if (currentItem.className === 'button') {
                currentItem.innerHTML = 'hide';
            }
        }

        selector.addEventListener('click', onButtonsClicked, false);
    };
}

module.exports = solve;
