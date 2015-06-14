function Solve(params){

	var lines=params,
	i=0,
	variables={};

	for(i;i<lines.length;i+=1){
		lines[i]=lines[i].replace('def', '').replace('[', '_').replace(']', '_').replace(/\W+/g, ' ').trim();			

		 if(i!==lines.length-1){
		 	var name=getVariableName(lines[i]);  // gets the name of the variable
			var func=getOperation(lines[i]); // gets the operator	
		 	variables[name]=getValue(lines[i],func);  // returns the value of the operation			
		 			 	
		 }
		 else{
	 		return variables;
		 }
	}

	// Separate functions

	function getVariableName(line){
		var firstSpace=line.indexOf(' '),
		name =line.substring(0,firstSpace).trim();

		return name;
	}

	function getOperation(line){
		var firstSpace=line.indexOf(' ');
		var firstUnderscore=line.indexOf('_');
		if((firstUnderscore-firstSpace)===1){
			return 'arr';
		}
		else{
			return line.substring(firstSpace+1,firstUnderscore);
		}
	}

	function getValue(line,operator){
		
		switch(operator){
			case 'arr':{
				return parseNumbers(line);
			}break;
			case 'min':{
				var numbers=parseNumbers(line);
				var min=numbers[0];
				for(var i=1;i<numbers.length;i+=1){
					if(min>numbers[i]){
						min=numbers[i];
					}
				}
				return min;
			}break;
			case 'max':{
				var numbers=parseNumbers(line);
				var max=numbers[0];
				for(var i=1;i<numbers.length;i+=1){
					if(max<numbers[i]){
						max=numbers[i];
					}
				}
				return max;				
			}break;
			case 'avg':{
				var numbers=parseNumbers(line);
				sum=0,
				counter=0;
				for(var i=0;i<numbers.length;i+=1){
					sum+=numbers[i];
					counter+=1;
				}
				return sum/counter|0;					
			}break;
			case 'sum':{
				var numbers=parseNumbers(line);
				sum=0;
				for(var i=0;i<numbers.length;i+=1){
					sum+=numbers[i];
				}
				return sum;			
			}break;
			default:
				return 'Invalid function';				
		}
	}		

	function flatten(arr, item) {
        if (Array.isArray(item)) {
            return arr.concat(item);
        }
        return arr.concat([item]);
    }


	function parseNumbers(line){
		var str=line.substring(line.indexOf('_')+1,line.length-1);

		var values=str.split(' ');

		values=values.map(function (item){
			if(variables[item]){				
				return variables[item];				
			}
			else{
				return parseInt(item);
			}
		});

		return values.reduce(flatten,[]);
	}	
}

/*
[ 'func sum_5 3 7 2 6 3_',
  'func2 _5 3 7 2 6 3_',
  'func3 min_func2_',
  'func4 max_5 3 7 2 6 3_',
  'func5 avg_5 3 7 2 6 3_',
  'func6 sum_func2 func3 func4 _',
  'sum_func6 func4_' ]
*/

var test1=[
'def func sum[5, 3, 7, 2, 6, 3]',
'def func2 [5, 3, 7, 2, 6, 3]',
'def func3 min[func2]',
'def func4 max[5, 3, 7, 2, 6, 3]',
'def func5 avg[5, 3, 7, 2, 6, 3]',
'def func6 sum[func2, func3, func4 ]',
'sum[func6, func4]'
];

var test2=[
'def func        sum[1, 2,     3     , -6]',
'def newList [func, 10, 1]',
'def newFunc sum[func, 100, newList]',
'[newFunc]'
];

console.log(Solve(test1));
//console.log(Solve(test2));