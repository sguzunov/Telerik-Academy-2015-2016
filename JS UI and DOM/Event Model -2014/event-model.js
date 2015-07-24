(function () {
    'use strict';
    var inputField = document.querySelector('#new-input'),
        addBtn = document.querySelector('#add-btn'),
        deleteBtn = document.querySelector('#delete-btn'),
        visibilityBtn = document.querySelector('#visibility-btn'),
        list = document.getElementById('list'),
        listItem = document.createElement('li');

    addBtn.addEventListener('click', function () {
        var inputInfo = inputField.value;
        listItem.innerHTML = inputInfo;
        list.appendChild(listItem.cloneNode(true));
    });

    deleteBtn.addEventListener('click', function () {
        var lastItem = list.lastElementChild;
        lastItem.parentNode.removeChild(lastItem);
    });

    visibilityBtn.addEventListener('click', function () {
        if (this.value === 'Hide') {
            list.style.visibility = 'hidden';
            this.value = 'Show';
        } else if (this.value === 'Show') {
            list.style.visibility = 'visible';
            this.value = 'Hide';
        }
    });
}());