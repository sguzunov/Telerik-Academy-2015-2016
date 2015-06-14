function Solve(arg){
	var size=arg[0].split(' ').map(Number),
	startPosition=arg[1].split(' ').map(Number),
	lab=arg.slice(2),
	row=startPosition[0],
	col=startPosition[1];
	direction={
		u:{
			row:-1,
			col:0
		},
		r:{
			row:0,
			col:1
		},
		d:{
			row:1,
			col:0
		},
		l:{
			row:0,
			col:-1
		}
	},
	visited={},
	sum=0,
	count=0;

	function getValue(row,col,cols){
		return cols*row+(col+1);
	}

	function inRange(row,col){
		return row>=0 && row<size[0] && col>=0 && col<size[1];
	}	

	while(true){
		var cellValue=getValue(row,col,size[1]);	

		if(!inRange(row,col)){
			return 'out '+sum;
		}

		if(visited[cellValue]){
			return 'lost '+	count;
		}

		sum+=cellValue;
		count+=1;
		visited[cellValue]=true;
		var dir=lab[row][col];		
		row+=direction[dir].row;
		col+=direction[dir].col;		
	}
}




var test1 =[ "3 4", "1 3", "lrrd", "dlll", "rddd"];

var test2=[ "5 8", "0 0", "rrrrrrrd", "rludulrd", "durlddud", "urrrldud", "ulllllll"];

var test3=[ "5 8", "0 0", "rrrrrrrd", "rludulrd", "lurlddud", "urrrldud", "ulllllll"];


console.log(Solve(test1));
console.log(Solve(test2));
console.log(Solve(test3));
