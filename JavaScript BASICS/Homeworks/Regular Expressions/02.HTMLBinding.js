/*
Write a function that puts the value of an object into the content/attributes of HTML tags.
Add the function to the String.prototype
*/

// NOT FINISHED

if(!String.prototype.bind){
	String.prototype.bind=function (str,obj){		
		for(var i in obj){
			var regexContent=new new RegExp('data-bind-'+i+'="name"','g');
			var regexHref=new new RegExp('data-bind-'+i+'="name"','g');
			var regexClass=new new RegExp('data-bind-'+i+'="name"','g');
		}
	};	
}


var text='<div data-bind-content="name"></div>';
var ind=text.bind();
console.log(ind);

console.log(text);