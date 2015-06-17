/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(start,end) {
	var result=[],
	i,
	j;	
	start= +start;
	end= +end;

	if(arguments.length<2){
		throw 'A parameter is missing!';
	}

	if(isNaN(arguments[0]) || isNaN(arguments[1])){
		throw 'Parameters must be numbers!';
	}

	for(i=start;i<=end;i+=1){
		var isPrime=true;

		if(i<2){
			isPrime=false;
		}
		else {
			for(j=2;j<=Math.sqrt(i);j+=1){
				if(i%j===0){
				isPrime=false;
				break;
				}
			}
		}		

		if(isPrime===true){
			result.push(i);
		}
	}

	return result;
}

module.exports = findPrimes;
