/*
Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
*/

function replaceTags(text){
	text=text.replace(/<a href="/g, ' [URL=');
	text=text.replace(/">/g, ']');
	text=text.replace(/<\/a>/g, '/URL]');

	return text;
}

var text='<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

console.log(replaceTags(text));

