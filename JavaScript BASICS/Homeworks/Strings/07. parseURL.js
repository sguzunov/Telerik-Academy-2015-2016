/* Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
Return the elements in a JSON object.
*/


function Url(protocol,server,resource){
	this.protocol=protocol;
	this.server=server;
	this.resource=resource;
}

function parseUrl(url){
	var firstSlashIndex=url.indexOf('/');
	var secondSlashIndex=firstSlashIndex+1;
	var thirdSlashIndex=url.indexOf('/',secondSlashIndex+1);

	result={};

	result['protocol']=url.substring(0,secondSlashIndex+1);
	result['server']=url.substring(secondSlashIndex+1,thirdSlashIndex);
	result['resource']=url.substring(thirdSlashIndex);

	return result;
}


var url='http://telerikacademy.com/Courses/Courses/Details/239';
console.log(parseUrl(url));
