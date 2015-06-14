/* 
Write a function that makes a deep copy of an object.
The function should work for both primitive and reference types.
*/

Array.prototype.remove = function(element){
	var i=0;

	for(i;i<this.length;i+=1){
		if(element===this[i]){
			this.splice(i, 1);
			i-=1;
		}
	}
};


var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];

arr.remove(2);

console.log(arr.join(' '));
