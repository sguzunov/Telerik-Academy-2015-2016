/*
Write a function that groups an array of people by age, first or last name.
The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
Use function overloading (i.e. just one function)
*/

// function to create an object
function Person(fName,lName,age){
	this.firstName=fName;
	this.lastName=lName;
	this.age=age;
	this.fullName=function fullName(){
		return (this.firstName+' '+this.lastName+' '+this.age).toString();
	}
}


function groupBy(people,param){
	var result={},
	len=people.length,
	i=0;

	if(param==='firstname'){
		for (i ; i < len; i+=1) {
			if(!result[people[i].firstName]){
				result[people[i].firstName]={};
			}
			result[people[i].firstName]=people[i];
		}
	}
	else if(param==='lastname'){
		for (i ; i < len; i+=1) {
			if(!result[people[i].lastName]){
				result[people[i].lastName]={};
			}
			result[people[i].lastName]=people[i];
		}
	}
	else if(param==='age'){
		for (i ; i < len; i+=1) {
			if(!result[people[i].age]){
				result[people[i].age]={};
			}
			result[people[i].age]=people[i];
		}
	}

	return result;
}

function printGroupedArray(grouped){
	for(var i in grouped){
	console.log(i+' --> '+grouped[i].fullName());
	}
}

// array of some people
var people=[
	new Person('Anton','Andonov',23),
	new Person('Rosen','Petrov',32),
	new Person('Ivo','Belomorov',15),
	new Person('Georgi','Petrov',20),
	new Person('Peter','Georgiev',50),
	new Person('Mishel','Antonov',23),
	new Person('Qvor','Stanev',44),
	new Person('Bogdan','Stoyanov',36)
];

// grouped by first name
var groupedByFirstName={};
groupedByFirstName=groupBy(people,'firstname');
console.log('By first name:');
printGroupedArray(groupedByFirstName);

// grouped by last name
var groupedByLastName={};
groupedByLastName=groupBy(people,'lastname');
console.log('By last name:');
printGroupedArray(groupedByLastName);

// grouped by age
var groupedByAge={};
groupedByAge=groupBy(people,'age');
console.log('By age');
printGroupedArray(groupedByAge);
