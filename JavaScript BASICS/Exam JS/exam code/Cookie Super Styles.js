function solve(args) {
	var code=args;
	var result={};
	var inSelector=false;	
	var selectorName='';
	var finalResult='';
	var endResult='';

	for(var i=0;i<code.length;i+=1){
		var line=code[i];
		line=line.replace(/[ \n\t]/g, '').trim();

		if(line[line.length-1]==='{'){
			inSelector=true;
			selectorName=line;
			continue;
		}

		if(inSelector){
			if(!result[selectorName]){
				result[selectorName]=selectorName;
				result[selectorName]+=line;
			}
			else{
				if(line==='}'){
					result[selectorName]+=line;
					inSelector=false;
					selectorName='';
				}
				else{
					if(checkContains(line,selectorName)===-1){
						result[selectorName]+=line;
					}		
					else{
						result[selectorName]=mergeProperties(line,selectorName);
					}												
				}
			}			
		}		
	} // end of for

	function checkContains(line,name){
		var propName=line.substring(0,line.indexOf(':'));
		var content=result[name];

		return content.indexOf(propName);
	}

	function mergeProperties(line,name){		
		var content=result[name];
		var propName=line.substring(0,line.indexOf(':'));
		var propIndex=content.indexOf(propName);
		var final='',
		inProperty=false;
		
		for(var t=0;t<content.length-1;t+=1){
			if(t===propIndex){
				inProperty=true;
			}

			if(inProperty){
				if(content[t]===';'){
					inProperty=false;
					continue;
				}
				continue;
			}
			final+=content[t];
		}

		return final+=line;
	}	
	
	for(var ind in result){
		finalResult+=result[ind];
	}

	for(var j=0;j<finalResult.length-1;j+=1){
		if(finalResult[j]===';'&&finalResult[j+1]==='}'){
			endResult+='}';
			j+=1;
		}
		else{
			endResult+=finalResult[j];
		}
	}

	console.log(endResult);	
}



var test=[
'#the-big-b{',
' color: yellow;',
'  size: big;',
'}',
'.muppet{',
'  powers: all;',
'  skin: fluffy;',
'}',
'     .water-spirit         {',
'  powers: water;',
'             alignment    : not-good;',
'				}',
'all{',
'  meant-for: nerdy-children;',
'}',
'.muppet      {',
'	powers: everything;',
'}',
'all            .muppet {',
'	alignment             :             good                             ;',
'}',
'   .muppet+             .water-spirit{',
'   power: everything-a-muppet-can-do-and-water;',
'}',
];

solve(test);