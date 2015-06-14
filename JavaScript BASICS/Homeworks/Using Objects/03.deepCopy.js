/*
Write a function that makes a deep copy of an object.
The function should work for both primitive and reference types.
*/

function deepCopy(obj){
	if(typeof obj==='object'){
		var result={};
		for(var ind in obj){
			result[ind]=obj[ind];
		}

		return result;
	}
	else{
		return obj;
	}	
}

var person1={
	fname:'Ivan',
	lname:'Petrov'
};

person2=deepCopy(person1);
person2.fname='Peter';

console.log(person1.fname);
console.log(person2.fname);


