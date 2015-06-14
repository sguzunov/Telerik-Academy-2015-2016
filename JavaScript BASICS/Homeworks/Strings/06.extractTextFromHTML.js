/*
Write a function that extracts the content of a html page given as text.
The function should return anything that is in a tag, without the tags.
*/

function getTextFromTags(text){
	var result='',
	i=0;

	for(i;i<text.length;i+=1){
		if(text[i]==='>'&&text[i+1]!=='<'){
			for(var j=i+1;j<text.length;j+=1){
				if(text[j]==='<'){
					result+=' ';
					break;
				}
				else{
					result+=text[j];
				}
			}
		}
	}

	return result;
}


var text='<html>Pesho<head>is cool man.</head><span>"Pesho" is Telerik\'s favourite name.</span></html>';
var result=getTextFromTags(text);
console.log(result);
