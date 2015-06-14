function Solve(params) {
	var numbers=[],
	i=1,
	j=0,
	k;

	for(i;i<params.length;i+=1){
		numbers.push(parseInt(params[i]));
	}

	var maxSum,
	currentSum;

	for(j;j<numbers.length-1;j+=1){
		if(j===0){
			maxSum=numbers[0];
		}
		currentSum=numbers[j];
		if(currentSum>maxSum){
			maxSum=currentSum;
		}
		for(k=j+1;k<numbers.length;k+=1){
			currentSum+=numbers[k];
			if(currentSum>maxSum){
				maxSum=currentSum;
			}
		}
	}

	return maxSum;
}



var test=['9','-9','3','-5','8','7','-6'];
console.log(Solve(test));