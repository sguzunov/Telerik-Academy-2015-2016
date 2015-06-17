/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		//returns `null` if the array is empty
		//throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(numbers) {
	var i,
	len,
	sum=0;

	if(numbers===undefined){
		throw 'Pass an array!';
		return;
	}
	if(numbers.length===0){
		return null;
	}
	
	for(i=0,len=numbers.length;i<len;i+=1){
		if(isNaN(numbers[i])){
			throw 'An element is non convertable to number!';
		}
	}

	numbers=numbers.map(Number);

	sum=numbers.reduce(function (a,b){
		return a+b;
	});

	return sum;
}


module.exports = sum