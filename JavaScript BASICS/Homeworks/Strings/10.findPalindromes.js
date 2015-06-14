// Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

function findPalindromes(text){
	var words=text.match(/\b\w+\b/g);
	var isTrue=false,
	result=[];

	for(var i=0;i<words.length;i+=1){
		if(words[i].length>2){
		for(var j=0;j<words[i].length/2|0;j+=1){
			if(words[i][j]===words[i][words[i].length-1-j]){
				isTrue=true;
			}
			else{
				isTrue=false;
				break;
			}
		}

		if(isTrue){
			result.push(words[i]);
		}
		}
	}

	return result;
}

var text='Pesho is ABBA, and Gosho is exe.';

var result=findPalindromes(text);
console.log(result.join(','));