// Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).

function searchSubString(text,string){
	text=text.toLowerCase();
	string=string.toLowerCase();

	textLength=text.length;
	stringLength=string.length;

	var i=0,
	counter=0;

	for(i;i<textLength-stringLength;i+=1){
		if(text.substr(i,stringLength)===string){
			counter+=1;
		}
	}

	return counter;
}

var text='We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.',
 string='in';

console.log(searchSubString(text,string));