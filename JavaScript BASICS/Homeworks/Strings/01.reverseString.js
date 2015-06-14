// Write a JavaScript function that reverses a string and returns it.

function reverseString(string){
	var reversedString='',
	i=0;

	for(i;i<string.length;i+=1){
		reversedString+=string[string.length-1-i];
	}

	return reversedString;
}

var result=reverseString('lebed');
console.log(result);