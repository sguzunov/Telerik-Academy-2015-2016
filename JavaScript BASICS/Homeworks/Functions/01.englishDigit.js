// Write a function that returns the last digit of given integer as an English word. 

function findLastDigit(number){
	var digits=['zero','one','two','three','four','five','six','seven','eight','nine'];
	var lastDigit;

	lastDigit=number%10;	

	return digits[lastDigit];
}

var a=findLastDigit(735);
var b=findLastDigit(182);

console.log(a);
console.log(b);