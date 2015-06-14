function Solve(args){
	var rowsColsAndJumps=args[0].split(' ').map(Number);
	var startPosition=args[1].split(' ').map(Number);
	var positions=args.slice(2);
	var newPositions=[]; // the position to go on
	var rows=rowsColsAndJumps[0]; // number of rows
	var cols=rowsColsAndJumps[1]; // number of cols
	var jumps=rowsColsAndJumps[2]; // number of jumps
	var counter=1,
	field=[];
	var visited={},
	row=startPosition[0]; // the start position on rows
	col=startPosition[1]; // the start position on cols

	for(var i=0;i<positions.length;i+=1){
		newPositions[i]=positions[i].split(' ').map(Number);
	}

	for(var j=0;j<rows;j+=1){
		field[j]=[];
		for(var k=0;k<cols;k+=1){
			field[j][k]=counter++;
		}
	}

	function inRange(row,col){
		return row<rows && row>=0 && col<cols && col>=0;
	}

	function getValue(row,col){
		return field[row][col];
	}

	var countJumps=0,
	sum=0,
	index=0;

	while(true){
		var cellValue=getValue(row,col);				
		if(!inRange(row,col)){
			return 'escaped '+sum;
		}
		if(visited[cellValue]){
			return 'caught '+countJumps;
		}	

		sum+=cellValue;
		countJumps+=1;
		visited[cellValue]=true;
		row+=newPositions[index][0];
		col+=newPositions[index][1];		
		index+=1;
		if(index===jumps+1){
			index=0;
		}
	}
}



var test=['500 500 1','0 0','1 1'];

console.log(Solve(test));