/*
Write a function that finds the youngest person in a given array of people and prints his/hers full name
Each person has properties firstname, lastname and age.
*/

function smallestPerson(people){
	var i=0,
	minAge=Number.MAX_VALUE,
	j=0;

	for(i;i<people.length;i+=1){
		if(minAge>people[i].age){
			minAge=people[i].age;
		}	
	}

	for(j;j<people.length;j+=1){
		if(minAge===people[j].age){			
			console.log(people[j].fullName());
		}	
	}
}


function Person(fname,lname,age){
	this.fName=fname,
	this.lName=lname,
	this.age=age,	
	this.fullName=function fullName(){
		return (this.fName+' '+this.lName).toString();
	}	
}

var person1=new Person('Rosen','Rusinov',15);
var person2=new Person('Peter','Petrov',19);
var person3=new Person('Ivan','Dragomirov',9);

var people=[person1,person2,person3];

smallestPerson(people);


