/*
Write functions for working with shapes in standard Planar coordinate system.
Points are represented by coordinates P(X, Y)
Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
Calculate the distance between two points.
Check if three segment lines can form a triangle.
*/

function buildPoint(x,y){  // function to create a point
	return {
		xCoordinate:x,
		yCoordinate:y
	};
}

function buildLine(p1,p2){  //function to create a line that takes as arguments points
	return {
		firstPoint:p1,
		secondPoint:p2,
		size:function size(){
			calculateDistance(p1,p2);
		}
	};
}

function calculateDistance(firstPoint,secondPoint){
	var x=secondPoint.xCoordinate - firstPoint.xCoordinate;
	var y=secondPoint.yCoordinate - firstPoint.yCoordinate;

	return Math.sqrt(Math.pow(x, 2)+Math.pow(y, 2));
}

function canCreateTriangle(line1,line2,line3){
	if((line1+line2>line3)&&(line1+line3>line2)&&(line2+line3>line1)){
		return true;
	}
	else{
		return false;
	}
}


// points for line 1
var point1=buildPoint(2,1);
var point2=buildPoint(9,1);

//point for line 2
var point3=buildPoint(-2,-2);
var point4=buildPoint(11,-1);

// point for line 3
var point5=buildPoint(3,5);
var point6=buildPoint(3,-5);;

var line1=buildLine(point1,point2);
var line2=buildLine(point3,point4);
var line3=buildLine(point5,point6);

// shows the distance between two points
console.log('The distance between point1 and point2 is: '+calculateDistance(point1,point2));

// check if it is posible to create a triangle
console.log(canCreateTriangle(line1,line2,line3));

