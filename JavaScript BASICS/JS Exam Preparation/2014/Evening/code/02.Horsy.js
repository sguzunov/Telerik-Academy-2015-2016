function solve(params){
	var rowsAndCols=params[0].split(' ').map(Number);
	var R=rowsAndCols[0];
	var C=rowsAndCols[1];
	var row=R-1;
	var col=C-1;
	var matrixValues=params.slice(1);
	var field=[];	
	var direction={
		'1':{
			row:-2,
			col:1
		},
		'2':{
			row:-1,
			col:2
		},
		'3':{
			row:1,
			col:2
		},
		'4':{
			row:2,
			col:1
		},
		'5':{
			row:2,
			col:-1
		},
		'6':{
			row:1,
			col:-2
		},
		'7':{
			row:-1,
			col:-2
		},
		'8':{
			row:-2,
			col:-1
		}
	};
	var sum=0;
	var visited={};
	var visit=checkIfVisited(row,col);
	var counter=0;

	for(var i=0;i<matrixValues.length;i+=1){
		field[i]=matrixValues[i].split('');
	}

	while(true){
		if(!inRange(row,col)){
			return 'Go go Horsy! Collected ' + sum + ' weeds';
		}
		if(visited[visit]){
			return 'Sadly the horse is doomed in ' + counter +' jumps';			
		} 

		counter+=1;
		sum+=getValue(row,col);		
		visited[visit]=true;
		var dir=getDirection(row,col);
		row+=direction[dir].row;
		col+=direction[dir].col;
		visit=checkIfVisited(row,col);
	}

	function getDirection(row,col){
		return field[row][col];
	}

	function checkIfVisited(row ,col){
		return row*C+col+1;
	}

	function getValue(row,col){
		return Math.pow(2,row)-col;
	}

	function inRange(row,col){
		return row >= 0 && row < R && col >= 0 && col < C;
	}
}


var test1= [  '3 5',  '54561',  '43328',  '52388',],
test2= [  '3 5',  '54361',  '43326',  '52188',];

console.log(solve(test1));
console.log(solve(test2));
