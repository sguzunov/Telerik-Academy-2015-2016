/*
Write a function for extracting all email addresses from given text.
All sub-strings that match the format @… should be recognized as emails.
Return the emails as array of strings.
*/

function extractMail(mail){
	var allMails=mail.match(/([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9._-]+)/gi);

	return allMails;
}

var test='All people have e-mails.Peshos\'s e-mail is pesho999@abv.bg, and Gosho\'s e-mail is jorkata11@gmail.com.';

var result=extractMail(test);

console.log(result.join('  '));