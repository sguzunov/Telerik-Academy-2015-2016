// Write a JavaScript function to check if in a given expression the brackets are put correctly.

function checkBrackets(string){
	var i=0,
	count=0;

	for(i;i<string.length;i+=1){
		if(string[i]==='('){
			count+=1;
		}
		else if (string[i]===')'){
			count-=1;	
		}
	}

	if(count!==0){
		return 'Incorrectly';
	}
	else{
		return 'Correctly';
	}
}

console.log(checkBrackets(')(a+b))'));