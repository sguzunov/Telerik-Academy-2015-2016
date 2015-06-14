function solve(params) {
    var R = parseInt(params[0]),
    C = parseInt(params[1]);
	var field=[];
	var figures={};	

	for(var j=0;j<R;j+=1){
		field[j]=params[j+2].split('');
	}

	for(var k=0;k<field.length;k+=1){
		for(var t=0;t<field.length+1;t+=1){
			figures[getCoordinate(k,t)]=field[k][t];
		}	
	}
	var tests=parseInt(params[R + 2]);	

	// main 
	for(var i=0;i<tests;i+=1){
		var move=params[R + 3 + i].split(' ');
		
		if(figures[move[0]]==='R'||figures[move[0]]==='B'||figures[move[0]]==='Q'||figures[move[1]]==='R'||figures[move[1]]==='B'||figures[move[1]]==='Q'){
			console.log('no');		
			continue;
		}		

		for(var m=0;m<field.length;m+=1){
			for(var n=0;n<field[m].length;n+=1){
				if(field[m][n]==='R');
			}
		}
	}	

	function getCoordinate(row,col){
		return (String.fromCharCode(97+col)+(R-row)).toString();
	}
}


var test1=['3','4','--R-','B--B','Q--Q','12','d1 b3','a1 a3','c3 b2','a1 c1','a1 b2','a1 c3','a2 b3','d2 c1','b1 b2','c3 b1','a2 a3','d1 d3'],
test2=['5','5','Q---Q','-----','-B---','--R--','Q---Q','10','a1 a1','a1 d4','e1 b4','a5 d2','e5 b2','b3 d5','b3 a2','b3 d1','b3 a4','c2 c5'];


solve(test1);
//solve(test2);