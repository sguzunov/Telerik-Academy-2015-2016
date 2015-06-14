// Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).

function checkNeighbours(numbers,position){
	if(position<1 || position>numbers.length-2){
		console.log('There aren\'t two neighbours');
	}
	else{
		if(numbers[position]>numbers[position-1]&&numbers[position]>numbers[position+1]){
			console.log(true);
		}
		else{
			console.log(false);
		}
	}
}

var numbers=[1,2,3,1,2,3,1,2,3];

checkNeighbours(numbers,0);
checkNeighbours(numbers,numbers.length-1);
checkNeighbours(numbers,2);
checkNeighbours(numbers,3);