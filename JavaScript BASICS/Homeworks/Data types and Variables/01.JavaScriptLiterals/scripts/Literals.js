/* Problem 1: Assign all the possible JavaScript literals to different variables. */

var integerLiteral = 5;
var floatingPointLiteral = 8.3;
var arrayLiteral = [1, 2, 3];
var boolTypeLiteral = true;
var objectLiteral = {
    firstName: "Rey",
    lastName: "Romano"
};
var stringLiteral = 'Hello world';

/*
Problem 2:
 Create a string variable with quoted text in it.
 For example: `'How you doin'?', Joey said'.
 */

var quotedText = '"How are you?",he asked.';
console.log('\nProblem 2:');
console.log(quotedText);

/*
 Problem 3:
 Try typeof on all variables you created.
 */

var allLiterals = [integerLiteral, floatingPointLiteral, arrayLiteral, boolTypeLiteral, objectLiteral, stringLiteral];
var i = 0;

console.log('\nProblem 3:')
for (i; i < allLiterals.length; i++) {
    console.log(typeof (allLiterals[i]));
}

/*
 Problem 4:
 Create null, undefined variables and try typeof on them.
 */

var nullVariable = null;
var undefinedVariable;

console.log('\nProblem 4:');
console.log(nullVariable);
console.log(typeof (undefinedVariable));