/*
Write a function that formats a string using placeholders.
The function should work with up to 30 placeholders and all types.
*/

function getPlaceholders(text,words)
{
   var result='';

   for(var i=0;i<text.length;i+=1){
   	if(text[i]==='{'){
   		var number=parseInt(text[i+1]);
   		result+=words[number];
   		i+=2;
   		continue;
   	}
   	result+=text[i];
   }

   return result;
}

var text='{0}, {1}, {0} text {2}';
var words=[1, 'Pesho', 'Gosho'];

var result=getPlaceholders(text,words);

console.log(result);

