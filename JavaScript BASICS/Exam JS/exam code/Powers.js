function solve(params) {
    var nk = params[0].split(' ').map(Number),
    numbers = params[1].split(' ').map(Number),
    n=nk[0], 
    k=nk[1]; 
    var result=[];
    var sum=0;

    if(k===0){
        for(var ind1=0;ind1<numbers.length;ind1+=1){
            sum+=numbers[ind1];
        }

        console.log(sum);
        return;
    }
    
    for(var i=0;i<k;i+=1){
    	for(var j=0;j<numbers.length;j+=1){
    		if(j===0){
    			if(numbers[j]===0){
    				result[j]=Math.abs(numbers[j+1]-numbers[n-1]);
    			}
    			else if(numbers[j]===1){
    				result[j]=(numbers[j+1]+numbers[n-1]);
    			}
    			else if((numbers[j]%2)===0){
    				result[j]=Math.max(numbers[j+1],numbers[n-1]);
    			}
    			else if((numbers[j]%2)!==0){
    				result[j]=Math.min(numbers[j+1],numbers[n-1]);
    			}
    		}
    		else if(j===n-1){
    			if(numbers[j]===0){
    				result[j]=Math.abs(numbers[j-1]-numbers[0]);
    			}
    			else if(numbers[j]===1){
    				result[j]=numbers[j-1]+numbers[0];
    			}
    			else if((numbers[j]%2)===0){
    				result[j]=Math.max(numbers[j-1],numbers[0]);
    			}
    			else if((numbers[j]%2)!==0){
    				result[j]=Math.min(numbers[j-1],numbers[0]);
    			}
    		}
    		else{
    			if(numbers[j]===0){
    				result[j]=Math.abs(numbers[j-1]-numbers[j+1]);
    			}
    			else if(numbers[j]===1){
    				result[j]=numbers[j-1]+numbers[j+1];
    			}
    			else if((numbers[j]%2)===0){
    				result[j]=Math.max(numbers[j-1],numbers[j+1]);
    			}
    			else if((numbers[j]%2)!==0){
    				result[j]=Math.min(numbers[j-1],numbers[j+1]);
    			}
    		}
    	} //
    	numbers=result.slice();
    }

	for(var ind2=0;ind2<result.length;ind2+=1){
		sum+=result[ind2];
	}       

    console.log(sum);
}


test1=[	'5 1','9 0 2 4 1'];
test2=[ '10 3','1 9 1 9 1 9 1 9 1 9'];
test3=[	'10 10','0 1 2 3 4 5 6 7 8 9'];


solve(test1);
solve(test2);
solve(test3);