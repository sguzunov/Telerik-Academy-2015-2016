function solve(input){	
	var result=[];
	
	for(var i=0;i<input.length;i+=1){
		result[i]=input[i].split('');
	}

	for(var row=1;row<result.length;row+=1){
		var maxCol=Math.min(
			input[row].length-3,
			input[row-1].length-2);

		for(var col=0;col<maxCol;col+=1){
			a=input[row][col];
			b=input[row][col+1];
			c=input[row][col+2];
			d=input[row-1][col+1];

			if(a===b && b===c && c===d){
				result[row][col]='*';
				result[row][col+1]='*';
				result[row][col+2]='*';
				result[row-1][col+1]='*';
			}
		}
	}

	for(var k=0;k<result.length;k+=1){
		console.log(result[k].join(''));
	}
}


var test1=['abcdexgh','bbbdxxxh','abcxxxxx'];
var test2=['aa','aaa','aaaa','aaaaa'];
var test3=['ax','xxx','b','bbb','bbbb'];
var test4=['dffdsgyefg','ffffeyeee','jbfffays','dagfffdsss','dfdfa','dadaaadddf','sdaaaaa','daaaaaaasf'];

solve(test1);
solve(test2);
solve(test3);
solve(test4);