function solve(params){
	var start=+params[0],
	end=+params[1];
	var result='';
	var tableOpen='<table>';
	var tableClose='</table>';
	var trOpen='<tr>';
	var trClose='</tr>';
	var thOpen='<th>';
	var thClose='</th>';
	var tdOpen='<td>';
	var tdClose='</td>';

	result+=(tableOpen+'\n');
	result+=(trOpen+thOpen+'Num'+thClose+thOpen+'Square'+thClose+thOpen+'Fib'+thClose+trClose+'\n');

	function isFib(val){
 		var prev = 0;
 		var curr = 1;
 		while(prev<=val){
			if(prev == val){
 		    	return 'yes';
   			}
   			curr = prev + curr;
 			prev = curr - prev;
 		}
		return 'no';
	}

	for(var i=start;i<=end;i+=1){
		var pow=i*i;

		var line=(trOpen+tdOpen+i+tdClose+tdOpen+pow+tdClose+tdOpen+isFib(i)+tdClose+trClose+'\n').toString();
		result+=line;
	}

	result+=tableClose;

	console.log(result.trim());

}


var test1=['2','6'];
var test2=['55','56'];

solve(test1);
console.log('\n');
solve(test2);