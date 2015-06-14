// Write a function that checks if a given object contains a given property.

function hasProperty(obj,property){
	for(var i in obj){
		if(i===property){
			return true;
		}
		else{
			return false;
		}
	}
}

var person={
	fname:'peter',
	age:25,
};


console.log(hasProperty(person,'fname'));
console.log(hasProperty(person,'lname'));