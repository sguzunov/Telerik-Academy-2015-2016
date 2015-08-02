/* globals $ */

/* 

Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:   
  * The UL must have a class `items-list`
  * Each of the LIs must:
    * have a class `list-item`
    * content "List item #INDEX"
      * The indices are zero-based
  * If the provided selector does not selects anything, do nothing
  * Throws if
    * COUNT is a `Number`, but is less than 1
    * COUNT is **missing**, or **not convertible** to `Number`
      * _Example:_
        * Valid COUNT values:
          * 1, 2, 3, '1', '4', '1123'
        * Invalid COUNT values:
          * '123px' 'John', {}, [] 
*/

function solve() {
    function isValidCount(count) {
        return !isNaN(count) && count > 0;
    }

    return function(selector, count) {
        var $list = $('<ul>').addClass('items-list'),
            i;

        if (!selector || !count) {
            throw new Error('Argument cannot be undefined');
        }

        if (typeof(selector) !== 'string') {
            throw new Error('Selector must be a string');
        }

        if (!isValidCount(count)) {
            throw new Error('Count is not valid.');
        }

        for (i = 0; i < count; i += 1) {
            var $item = $('<li>').addClass('list-item').html('List item #' + i);
            $item.appendTo($list);
        }

        $list.appendTo(selector);
    };
}

module.exports = solve;
