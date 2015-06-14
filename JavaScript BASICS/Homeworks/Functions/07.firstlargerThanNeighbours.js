/*
Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
Use the function from the previous exercise.
*/

function checkNeighbours(numbers){
	for(var i = 1; i < numbers.length-1; i+=1){
		if(numbers[i]>numbers[i-1]&&numbers[i]>numbers[i+1]){
			return i;
		}
	}

	return -1;
}

var numbers=[1,2,3,1,2,3,1,2,3];

var result=checkNeighbours(numbers);
console.log(result);