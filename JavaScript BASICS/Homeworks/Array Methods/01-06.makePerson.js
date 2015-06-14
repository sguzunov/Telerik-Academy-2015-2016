// ----------------------------PROBLEM-1---------------------------------------------
/* 
Write a function for creating persons.
Each person must have firstname, lastname, age and gender (true is female, false is male)
Generate an array with ten person with different names, ages and genders
*/

function Person(fname,lname,age,gender){
	this.firstName=fname;
	this.lastName=lname;
	this.age=age;
	this.gender=gender;
}

function generatePeople(){
	var fnames=['Antoaneta','Ralica','Peter','Gosho','Ivan','Stanimir','Mila','Susana','Rosen','Steve'],
	 lnames=['Yordanova','Petrova','Goshov','Petrev','Stoyanov','Dinkov','Colova','Dimitrova','Milev','Jobs'],
	 i=0,
	 people=[];

	 for(i;i<10;i+=1){
	 	people[i]=new Person(fnames[i],lnames[i],(i%2)?i+10:i+20,fnames[i][fnames[i].length-1]==='a'?true:false);
	 } 

	 return people;
}

var result=generatePeople();
console.log('Problem 1: ');
console.log(result);


// ------------------------------PROBLEM-2---------------------------------------------
/*
Write a function that checks if an array of person contains only people of age (with age 18 or greater)
Use only array methods and no regular loops (for, while)
*/

 var ageOver18=result.every(function (person){
 		return person.age>18;
 });

console.log('\nProblem 2: '+ageOver18);


// ------------------------------PROBLEM-3---------------------------------------------
/*
Write a function that prints all underaged persons of an array of person
Use Array#filter and Array#forEach
Use only array methods and no regular loops (for, while)
*/

console.log('\nProblem 3:');

var filterArray=result.filter(function (person){
	return person.age<18;
}).forEach(function (person){
	console.log(person);
});


// ------------------------------PROBLEM-4---------------------------------------------
/*
Write a function that calculates the average age of all females, extracted from an array of persons
Use Array#filter
Use only array methods and no regular loops (for, while)
*/

console.log('\nProblem 4:');
var averageAge=result.filter(function (person){
	if(person.gender===true){
		return person;
	}
}).reduce(function (sum,person){
	return (sum+person.age)/2|0;
},0);

console.log(averageAge);   // always get a different number because of the random method Math.random()


// ------------------------------PROBLEM-5---------------------------------------------
/*
Write a function that finds the youngest male person in a given array of people and prints his full name
Use only array methods and no regular loops (for, while)
Use Array#find
*/

if(!Array.prototype.find){
	Array.prototype.find = function(callback){
		var i,
		len=this.length;
		for(i;i<len;i+=1){
			if(callback(this[i],i,this)){
				return this[i];
			}
		}
	};
}

result.sort(function (first,second){
	return first.age-second.age;
});


var young=result.find(function (item){
	return !item.gender;
});


// ------------------------------PROBLEM-6---------------------------------------------
/*
Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
Use Array#reduce
Use only array methods and no regular loops (for, while)
*/

var groupedPeople=result.reduce(function(obj,item){
	if(obj[item.firstName[0]]){
	   obj[item.firstName[0]].push(item);
	}
	else{
		obj[item.firstName[0]]=[item];
	}

	return obj;
},{});

console.log('\nProblem 6:');
console.log(groupedPeople);