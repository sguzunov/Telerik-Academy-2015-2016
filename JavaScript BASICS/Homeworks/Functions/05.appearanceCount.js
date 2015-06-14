/*
Write a function that counts how many times given number appears in given array.
Write a test function to check if the function is working correctly.
*/

function countNumbers(array,number){
	var counter=0;

	for(var ind in array){
		if(array[ind]===number){
			counter+=1;
		}
	}

	return counter;
}

function checkResult(array,number,expectedCount){
	var count=countNumbers(array,number);

	if(count===expectedCount){
		console.log('Correct');
	}
	else{
		console.log('Incorrect');
	}
}

var numbers=[1,2,3,1,2,3,1,2,3,1,2,3];

checkResult(numbers,1,4);
checkResult(numbers,3,2);