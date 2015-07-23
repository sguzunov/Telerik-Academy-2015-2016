(function () {
    'use strict';
    var button = document.getElementById('the-button');

    function changeColors() {
        var fontColor = document.getElementById('font-color').value,
            bgColor = document.getElementById('bg-color').value,
            field = document.getElementById('text-field');

        field.style.color = fontColor;
        field.style.background = bgColor;
    }

    button.addEventListener('click', changeColors);
}());