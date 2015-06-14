function solve(params) {
    var n=parseInt(params[0]);
    var mas=[]
    var result=[];
    var keyValue={};
    var sectionOpen='@section';
    var close='}';
    var inSection=false;   
    var sectionName=''; 
    var sectionContent=[];
    var allSections={};
    var renderOpen='@renderSection(';  
    var escapeOpen='@@'; 	

    for(var k=0;k<n;k+=1){
    	mas[k]=params[k+1].split(':');
    	keyValue[mas[k][0]]=mas[k][1];
    }

    var m=parseInt(params[n+1]);
    var sourceCode=params.slice(n+2);

    // iterate over the lines
    for(var i=0;i<sourceCode.length;i+=1){
    	var line=sourceCode[i];

    	if(line===undefined){
    		line='';
    	}
    	if(inSection){
    		result.push('\n');
    	}

		// iterates over the symbols
    	for(var j=0;j<line.length;j+=1){
    		var symbol=line[j];

    		// check for escape
    		if(isEqual(line,j,escapeOpen)){
    			result.push('@');
    			k+=escapeOpen.length-1;
    			continue;
    		}

    		// check for section
    		if(isEqual(line,j,sectionOpen)){
    			inSection=true;
    			sectionName=line.split(' ')[1];    			
    			break;
    		}

    		if(inSection && isEqual(line,j,close)){
    			inSection=false;
    			allSections[sectionName]=sectionContent.join('').trim();
    			sectionContent=[];
    			break;
    		}

    		if(inSection){
    			sectionContent.push(symbol);
    			continue;
    		}    	

    		// check for render section
    		if(isEqual(line,j,renderOpen)){
    			var renderName=line.split('"')[1];
    			result.push(allSections[renderName]);
    			break;
    		}	

    		result.push(symbol);
    	}
    	result.push('\n');
    }

    console.log(result.join('').trim());
    
    function isEqual(line,symbolNumber,tag){
    	return line.substr(symbolNumber,tag.length)===tag;
    }
}


var test=[
'6',
'title:Telerik Academy',
'showSubtitle:true',
'subTitle:Free training',
'showMarks:false',
'marks:3,4,5,6',
'students:Pesho,Gosho,Ivan',
'42',
'@section menu {',
'<ul id="menu">',
'    <li>Home</li>',
'    <li>About us</li>',
'</ul>',
'}',
'@section footer {',
'<footer>',
'    Copyright Telerik Academy 2014',
'</footer>',
'}',
'<!DOCTYPE html>',
'<html>',
'<head>',
'    <title>Telerik Academy</title>',
'</head>',
'<body>',
'    @renderSection("menu")',
'',
'    <h1>@title</h1>',
'    @if (showSubtitle) {',
'        <h2>@subTitle</h2>',
'        <div>@@JustNormalTextWithDoubleKliomba ;)</div>',
'    }',
'',
'    <ul>',
'        @foreach (var student in students) {',
'            <li>',
'                @student ',
'            </li>',
'            <li>Multiline @title</li>',
'        }',
'    </ul>',
'    @if (showMarks) {',
'        <div>',
'           @marks ',
'        </div>',
'    }',
'',
'    @renderSection("footer")',
'</body>',
'</html>',
''
];

solve(test);
