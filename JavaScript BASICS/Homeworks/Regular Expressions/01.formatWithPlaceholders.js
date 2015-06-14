/*
Write a function that formats a string. The function should have placeholders, as shown in the example
Add the function to the String.prototype
*/

if(!String.prototype.format){
	String.prototype.format=function (options){
		var result=this;
		for(var i in options){
			result=result.replace(new RegExp('#{'+i+'}','g'), options[i]);
		}
		return result;
	};
}

var options={
	name:'Pesho',
	age:25
};

var text='My name is #{name} and I am #{age}-years-old.';

var result=text.format(options);

console.log(result);

