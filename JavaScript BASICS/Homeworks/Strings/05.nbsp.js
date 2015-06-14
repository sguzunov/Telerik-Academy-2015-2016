// Write a function that replaces non breaking white-spaces in a text with &nbsp;

function replaceEmptySpaces(text) {			
			text = text.replace(/ /g, '&nbsp');
			return text;
}

console.log(replaceEmptySpaces('We all love music and i have some fun    yesterday.'));