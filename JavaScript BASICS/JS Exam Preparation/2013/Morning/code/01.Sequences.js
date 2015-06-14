function Solve(args){
	var numbers=args.slice(1).map(Number),
	counter=0;

	for(var i=1;i<numbers.length;i+=1){
		counter+=1;
		while(true){
			if(numbers[i-1]<=numbers[i]){
				i+=1;
			}
			else{
				if(i===numbers.length-1){
					counter+=1;
				}
				break;
			}		
		}
	}	

	return counter;
}


var test1=['7','1','2','-3','4','4','0','1',];

var test2=['6','1','3','-5','8','7','-6'];

test3=['9','1','8','8','7','6','5','7','7','6'];

console.log(Solve(test1));
console.log(Solve(test2));
console.log(Solve(test3));