(function () {
    'use strict';
    var tags = ["cms", "javascript", "js", "ASP.NET MVC", ".net", ".net",
        "css", "wordpress", "xaml", "js", "http", "web", "asp.net", "asp.net MVC",
        "ASP.NET MVC", "wp", "javascript", "js", "cms", "html", "javascript", "http", "http", "CMS"];


    function getRandomNumber(min, max, tagOccur) {
        var result = 0;
        result = ((Math.random() * (max - min) + min) * tagOccur) | 0;

        return result;
    }

    function getTagsOccurences(tags) {
        var i,
            j,
            len = tags.length,
            result = [],
            count = 0,
            currentTag;

        for (i = 0; i < len; i += 1) {
            currentTag = tags[i].toLowerCase();

            if (!result[currentTag]) {
                for (j = 0; j < len; j += 1) {
                    if (currentTag === tags[j].toLowerCase()) {
                        count += 1;
                    }
                }

                result[currentTag] = count;
                count = 0;
            }
        }

        return result;
    }

    function generateTagCloud(tags) {
        var tagOcuurences = getTagsOccurences(tags),
            ulItem = document.createElement('ul'),
            liItem = document.createElement('li'),
            count,
            tag;

        liItem.style.listStyleType = 'none';

        for (tag in tagOcuurences) {
            count = tagOcuurences[tag];
            liItem.style.fontSize = getRandomNumber(10, 20, count) + 'px';
            liItem.innerHTML = tag;
            ulItem.appendChild(liItem.cloneNode(true));
        }

        console.log(ulItem.childNodes[0]);
        document.body.appendChild(ulItem);
    }

    generateTagCloud(tags);
}());






















