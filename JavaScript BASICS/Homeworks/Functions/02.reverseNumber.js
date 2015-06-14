// Write a function that reverses the digits of given decimal number

function reverseDigits(number){
	var numberAsString=number.toString();
	var reversedNumber='';

	for (var i = numberAsString.length - 1; i >= 0; i--) {
		reversedNumber+=numberAsString[i];
	}

	return parseInt(reversedNumber,10);
}

var result=reverseDigits(123);
console.log(result);