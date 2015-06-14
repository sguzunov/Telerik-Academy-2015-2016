function solve(params) {
	var n=parseInt(params[0]);
	var keyValue=[];
	var result=[];
	var modelOpeningTag='<nk-model>';
	var modelClosingTag='</nk-model>';
	var inModel=false;
	var modelKey='';
	var escapeOpeningTag='{{';
	var escapeClosingTag='}}';
	var inEscape=false;
	var tempOpeningTag='<nk-template name=';
	var tempClosingTag='</nk-template>';
	var inTemplate=false;
	var tempName='';
	var allTemplates={};
	var contentTemp=[];
	var renderTag='<nk-template render=';
	var renderTempName='';
	var conditionOpeningTag='<nk-if condition=';
	var conditionCloseingTag='</nk-if>';
	var inCondition=false;
	var condition='';

	for(var i=0;i<n;i+=1){
		keyValue[i]=params[i+1].split('-');
	}

	var m=parseInt(params[n+1]);
	var viewCode=params.slice(n+2);

	for(var j=0;j<viewCode.length;j+=1){
		var currentLine=viewCode[j];

		if(currentLine===undefined){
			currentLine='';
		}

		if(inTemplate){
			contentTemp.push('\n');
		}

		for(var k=0;k<currentLine.length;k+=1){
			var currentSymbol=currentLine[k];

			// check for escape
			if(isEqual(currentLine,k,escapeOpeningTag)){
				inEscape=true;
				k+=escapeOpeningTag.length-1;
				continue;
			}

			if(inEscape && isEqual(currentLine,k,escapeClosingTag)){
				inEscape=false;
				k+=escapeClosingTag.length-1;
				continue;
			}

			if(inEscape){
				result.push(currentSymbol);
				continue;
			}

			// check for template
			if(isEqual(currentLine,k,tempOpeningTag)){
				inTemplate=true;
				tempName=currentLine.split('"')[1];		
				break;		
			}

			if(inTemplate && isEqual(currentLine,k,tempClosingTag)){
				inTemplate=false;
				allTemplates[tempName]=contentTemp.join('').trim();
				contentTemp=[];
				break;
			}

			if(inTemplate){
				contentTemp.push(currentSymbol);
				continue;
			}

			// check for render template
			if(isEqual(currentLine,k,renderTag)){
				renderTempName=currentLine.split('"')[1];	
				result.push(allTemplates[renderTempName]);
				break;		
			}			

			// check for model
			if(isEqual(currentLine,k,modelOpeningTag)){
				inModel=true;
				k+=modelOpeningTag.length-1;
				continue;
			}

			if(inModel && isEqual(currentLine,k,modelClosingTag)){
				inModel=false;
				k+=modelClosingTag.length-1;
				result.push(getModel(modelKey));
				modelKey='';
				continue;
			}

			if(inModel){
				modelKey+=currentSymbol;
				continue;		
			}

			// check for condition
			if(isEqual(currentLine,k,conditionOpeningTag)){
				inCondition=true;
				condition=currentLine.split('"')[1];
				k+=conditionOpeningTag.length+condition.length+3;
				continue;
			}

			if(inCondition && isEqual(currentLine,k,conditionCloseingTag)){
				inCondition=false;
				k+=conditionOpeningTag.length+condition.length+3;
				continue;
			}

			if(inCondition){
				if(keyValue[condition]==='true'){
					result.push(currentSymbol);
				}
				else if(keyValue[condition]==='false'){
					continue;
				}
			}

			result.push(currentSymbol);						
		}

		result.push('\n');
	}	
	
	function isEqual(line,symbolNumber,tag){
		return line.substr(symbolNumber,tag.length)===tag;
	}

	function getModel(key){
		for(var i=0;i<keyValue.length;i+=1){
			if(keyValue[i][0]===key){
				return keyValue[i][1];
			}
		}
	}

	console.log(result.join('').trim());		
}

var test=[
'6',
'title-Telerik Academy',
'showSubtitle-true',
'subTitle-Free training',
'showMarks-false',
'marks-3;4;5;6',
'students-Ivan;Gosho;Pesho',
'42',
'<nk-template name="menu">',
'    <ul id="menu">',
'        <li>Home</li>',
'        <li>About us</li>',
'    </ul>',
'</nk-template>',
'<nk-template name="footer">',
'    <footer>',
'        Copyright Telerik Academy 2014',
'    </footer>',
'</nk-template>',
'<!DOCTYPE html>',
'<html>',
'<head>',
'    <title>Telerik Academy</title>',
'</head>',
'<body>',
'   <nk-template render="menu" />',
'',
'   <h1><nk-model>title</nk-model></h1>',
'   <nk-if condition="showSubtitle">',
'        <h2><nk-model>subTitle</nk-model></h2>',
'        <div>{{<nk-model>subTitle</nk-model>}} ;)</div>',
'    </nk-if>',
'',
'   <ul>',
'        <nk-repeat for="student in students">',
'            <li>',
'                <nk-model>student</nk-model>',
'            </li>',
'            <li>Multiline <nk-model>title</nk-model></li>',
'        </nk-repeat>',
'    </ul>',
'    <nk-if condition="showMarks">',
'        <div>',
'            <nk-model>marks</nk-model> ',
'        </div>',
'    </nk-if>',
'',
'    <nk-template render="footer" />',
'</body>',
'</html>'];


solve(test);