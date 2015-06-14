function solve(args){
	var s=+args[0],
	counter=0;

	for(var i=0;i<s;i+=1){
		for(var j=0;j<s;j+=1){
			for(var k=0;k<s;k+=1){
				if((i*10+j*4+k*3)===s){
					counter+=1;
				}
			}
		}
	}

	return counter;
}


console.log(solve(['7']));
console.log(solve(['10']));
console.log(solve(['40']));