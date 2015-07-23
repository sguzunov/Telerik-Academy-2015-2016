(function () {
    function getRandomNumber(min, max) {
        var result = 0;
        result = (Math.random() * (max - min) + min) | 0;

        return result;
    }

    function getRandomColor() {
        var color = '(' + getRandomNumber(0, 255) + ',' + getRandomNumber(0, 255) + ',' + getRandomNumber(0, 255) + ')';

        return color;
    }

    function createMassOfDivs() {
        var count = getRandomNumber(50, 100),
            container = document.createDocumentFragment(),
            i,
            newDiv = document.createElement('div'),
            strongItem = document.createElement('strong'),
            root = document.getElementById('root');

        strongItem.innerText = 'div';

        for (i = 0; i < count; i += 1) {

            newDiv.style.width = getRandomNumber(20, 40) + 'px';
            newDiv.style.height = getRandomNumber(20, 40) + 'px';
            newDiv.style.background = getRandomColor();
            newDiv.style.color = getRandomColor();
            newDiv.style.position = getRandomNumber(1, 3) > 1 ? 'absolute' : 'relative';
            newDiv.style.borderRadius = getRandomNumber(1, 10) + 'px';
            newDiv.style.borderColor = getRandomColor();
            newDiv.style.borderWidth = getRandomNumber(1, 20) + 'px';
            newDiv.appendChild(strongItem);
            container.appendChild(newDiv.cloneNode(true));
        }

        root.appendChild(container);
    }

    createMassOfDivs();
}());












