/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
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
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
    return function(selector) {
        var $buttons = $('.button');

        if (typeof(selector) !== 'string' || $(selector).size() === 0) {
            throw new Error('Invalid selector.');
        }

        if (typeof(selector) === 'string') {
            selector = $(selector);
        }

        $buttons.each(function() {
            $(this).html('hide');
        });

        $(selector).on('click', function(ev) {
            if ($(ev.target).hasClass('button')) {
                changeVisibility(ev.target);
            }
        });

        function changeVisibility(clickedBtn) {
            var $element = $(clickedBtn).next(),
                isContentValid = false,
                $topMostContent;

            while ($element) {
                if ($element.hasClass('content')) {
                    $topMostContent = $element;
                    $element = $element.next();
                    while ($element) {
                        if ($element.hasClass('button')) {
                            isContentValid = true;
                            break;
                        } else {
                            $element = $element.next();
                        }
                    }

                    break;
                } else {
                    $element = $element.next();
                }
            }

            if (isContentValid) {
                if ($topMostContent.css('display') === 'none') {
                    $topMostContent.css('display', '');
                    $(clickedBtn).html('hide');
                } else {
                    $topMostContent.css('display', 'none');
                    $(clickedBtn).html('show');
                }
            }
        }
    };
}

module.exports = solve;
