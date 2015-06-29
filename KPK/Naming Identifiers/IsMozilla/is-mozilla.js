var IsMozillaBrowser = (function() {
    function IsMozilla(event, parameters) {
        var myWindow = window,
            browser,
            isMozilla;
        browser = myWindow.navigator.appCodeName;
        isMozilla = (browser === 'Mozilla');

        if (isMozilla) {
            alert('Yes');
        } else {
            alert('No');
        }
    }
    
    return IsMozilla;
})();