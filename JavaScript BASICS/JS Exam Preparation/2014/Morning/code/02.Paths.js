function solve(args){
	var rowsAndCols=args[0].split(' ').map(Number);
	var positions=args.slice(1);

	var R=rowsAndCols[0];  // all rows
	var C=rowsAndCols[1];  // all cols
	var field=[],
	sum=0,
	direction={
		dr:{
			row:1,
			col:1
		},
		ur:{
			row:-1,
			col:1
		},
		ul:{
			row:-1,
			col:-1
		},
		dl:{
			row:1,
			col:-1
		}
	};
	var row=0,
	col=0;
	var visited={},
	visit=false;

	for(var i=0;i<R;i+=1){
		field[i]=positions[i].split(' ');		
	}		

	visit=checkForVisited(row,col);

	while(true){
		if(!inRange(row,col)){
			return 'successed with '+sum;
		}

		if(visited[visit]){
			return 'failed at '+'('+row+', '+col+')';
		}

		sum+=getValue(row,col);
		visited[visit]=true;
		var dir=field[row][col];
		row+=direction[dir].row;
		col+=direction[dir].col;
		visit=checkForVisited(row,col);
	}

	function getValue(row,col){
		return Math.pow(2,row)+col;
	}	

	function inRange(row,col){
		return row >= 0 && row < R && col >= 0 && col < C;
	}

	function checkForVisited(row,col){
		return row*C+col+1;
	}

}


var test1=[  '3 5',  'dr dl dr ur ul',  'dr dr ul ur ur',  'dl dr ur dl ur'];
var test2=[  '3 5',  'dr dl dl ur ul',  'dr dr ul ul ur',  'dl dr ur dl ur'];

console.log(solve(test1));
console.log(solve(test2));
