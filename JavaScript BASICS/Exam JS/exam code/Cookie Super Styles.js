function solve(args) {
	var code=args;
	var result={};
	var inSelector=false;	
	var selectorName='';
	var finalResult=[];

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
					result[selectorName]=mergeProperties(line,selectorName);
					console.log(mergeProperties(line,selectorName));
					return;
				}
			}			
		}		
	} // end of for

	function mergeProperties(line,name){		
		var propName=line.substring(0,line.indexOf(':'));
	/*	var propContent=line.substring(line.indexOf(':')+1,line.indexOf(';'));
		var content=result[name];
		content=content.replace(propName+':[A-z];', propContent);*/
		return propName+name;
	}	

	for(var j in result){
		finalResult.push(result[j].replace(/;}/g, '}'));
	}	

	console.log(finalResult.join());
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