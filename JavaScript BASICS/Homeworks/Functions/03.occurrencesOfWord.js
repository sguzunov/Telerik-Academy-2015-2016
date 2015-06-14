 /*	Write a function that finds all the occurrences of word in a text.
	The search can be case sensitive or case insensitive.
	Use function overloading.    .split(/[\s,]+/)
 */

function allOccurances(text,word,sensitivity){
	var allWords=[],
	counter=0;

	if(sensitivity==='sensitive'){
		allWords=text.split(/[\s,]+/);
	}
	else if (sensitivity==='insensitive'){
		word=word.toLowerCase();
		text=text.toLowerCase();
		allWords=text.split(/[\s,]+/);
	}

	for(var ind in allWords){
		if(word===allWords[ind]){
			counter+=1;
		}
	}

	return counter;
}

var str='The dog is hungry.My dog needs rest';

var result1=allOccurances(str,'Dog','insensitive');
var result2=allOccurances(str,'Dog','sensitive');
var result3=allOccurances(str,'dog','sensitive');

console.log(result1);
console.log(result2);
console.log(result3);