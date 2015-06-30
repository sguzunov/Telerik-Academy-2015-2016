/* Task Description */
/* 
 * Create a module for a Telerik Academy course   DONE
 * The course has a title and presentations
 * Each presentation also has a title
 * There is a homework for each presentation
 * There is a set of students listed for the course
 * Each student has firstname, lastname and an ID
 * IDs must be unique integer numbers which are at least 1
 * Each student can submit a homework for each presentation in the course
 * Create method init   DONE
 * Accepts a string - course title 
 * Accepts an array of strings - presentation titles
 * Throws if there is an invalid title
 * Titles do not start or end with spaces
 * Titles do not have consecutive spaces
 * Titles have at least one character 
 * Throws if there are no presentations 
 * Create method addStudent which lists a student for the course 
 * Accepts a string in the format 'Firstname Lastname' 
 * Throws if any of the names are not valid
 * Names start with an upper case letter
 * All other symbols in the name (if any) are lowercase letters
 * Generates a unique student ID and returns it 
 * Create method getAllStudents that returns an array of students in the format: 
 * {firstname: 'string', lastname: 'string', id: StudentID}
 * Create method submitHomework 
 * Accepts studentID and homeworkID
 * homeworkID 1 is for the first presentation
 * homeworkID 2 is for the second one
 * ...
 * Throws if any of the IDs are invalid
 * Create method pushExamResults 
 * Accepts an array of items in the format {StudentID: ..., Score: ...}
 * StudentIDs which are not listed get 0 points ?
 * Throw if there is an invalid StudentID 
 * Throw if same StudentID is given more than once ( he tried to cheat (: )
 * Throw if Score is not a number
 * Create method getTopStudents which returns an array of the top 10 performing students ? 
 * Array must be sorted from best to worst
 * If there are less than 10, return them all
 * The final score that is used to calculate the top performing students is done as follows:
 * 75% of the exam result
 * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
 */
function solve() {
    var Course = {
        init: function(title, presentations) {
            this.title = title;
            this.presentations = presentations;
            this.students = [];
            this.homeworks = [];
            this.examResults = [];
            return this;
        },
        addStudent: function(name) {
            var id,
                names = [];
            if (!areValidNames(name)) {
                throw new Error('Invalid names!');
            }
            names = name.split(' ');
            id = this.students.length + 1;
            this.students.push({
                firstname: names[0],
                lastname: names[1],
                id: id
            });
            return id;
        },
        getAllStudents: function() {
            return this.students.slice();
        },
        submitHomework: function(studentID, homeworkID) {
            if (!isValidID(studentID) || !isContainedID(studentID, this.students.length) || !isValidID(homeworkID) || !isContainedID(homeworkID, this.presentations.length)) {
                throw new Error('Invalid IDs!');
            }
            this.homeworks[studentID] = [];
            this.homeworks[studentID] = [].push(homeworkID);
            return this;
        },
        pushExamResults: function(results) {
            var i,
                len;
                if(results.length === 0){
                    throw new Error('There are no elements in the array!');
                }

                if(!results instanceof(Array)){
                    throw new Error("The argument must be array!");
                }
            for (i = 0, len = results.length; i < len; i += 1) {
                var student = results[i];
                var score = student.Score;
                if (!isValidID(student.StudentID)) {
                    throw new Error('Invalid student\'s ID');
                }
                if (!isRepeatingID(results)) {
                    throw new Error('There is a repeating id in the list!');
                }
                if (isNaN(score) || score === 'undefined') {
                    throw new Error('The score is not a number!');
                }
            }
            this.examResults = results.map(function(result) {
                if (!isContainedID(result.studentID)) {
                    return {
                        StudentID: result.studentID,
                        Score: 0
                    };
                } else {
                    return result;
                }
            });
            return this;
        },
        getTopStudents: function() {
            var i,
                len,
                result,
                finalResults = [];
            for (i = 0, len = this.students.length; i < len; i += 1) {
                var student=this.students[i];

                result = formFinalResult(student.id);
                finalResults.push({
                    firstname: student.firstname,
                    lastname: student.lastname,
                    id: student.id,
                    result: result
                });
            }

            finalResults = finalResults.sort(function(firstSudent, secondStudent) {
                return firstSudent.result - secondStudent.result;
            });
            if (finalResults.length > 10) {
                return finalResults.slice(0,10);
            } else {
                return finalResults.slice(0);
            }
        }
    };
    Object.defineProperty(Course, 'title', {
        get: function() {
            return this._title;
        },
        set: function(value) {
            if (!isValidTitle(value)) {
                throw new Error('Invalid title!');
            }
            this._title = value;
            return this;
        }
    });
    Object.defineProperty(Course, 'presentations', {
        get: function() {
            return this._presentations;
        },
        set: function(value) {
            if (value.length === 0 || !isValidPresentation(value)) {
                throw new Error('No presentations!');
            }
            this._presentations = value;
            return this;
        }
    });

    function formFinalResult(id) {
        var examPoints,
            homeworksPoints,
            i,
            len;
        for (i = 0, len = this.examResults.length; i < len; i += 1) {
            var student = this.examResults[i];
            if (id === student.StudentID) {
                examPoints = student.Score * 0.75;
                break;
            }
        }
        homeworksPoints = (this.homeworks[id].length / this.presentations.length) * 0.25;
        return examPoints + homeworksPoints;
    }

    function isRepeatingID(results) {
        var i,
            j;
        for (i = 0; i < results.length - 1; i += 1) {
            for (j = 1; j < results.length; j += 1) {
                if (results[i].studentID === results[j].studentID) {
                    return false;
                }
            }
        }
        return true;
    }

    function isContainedID(id, max) {
        if (id < 1 || id > max) {
            return false;
        }
        return true;
    }

    function isValidID(id) {
        if (isNaN(id) || (id !== (id | 0))) {
            return false;
        }
        return true;
    }

    function areValidNames(fullName) {
        var names = fullName.split(' '),
            i,
            len,
            pattern = /([A-Z][a-zA-Z]*)/;
        if (names.length !== 2) {
            return false;
        }
        for (i = 0, len = names.length; i < len; i += 1) {
            if (pattern.test(names[i]) === false) {
                return false;
            }
        }
        return true;
    }

    function isValidPresentation(presentations) {
        var i,
            len;
        for (i = 0, len = presentations.length; i < len; i += 1) {
            if (!isValidTitle(presentations[i])) {
                return false;
            }
        }
        return true;
    }

    function isValidTitle(title) {
        var pattern = /[ ]{2,}/g;
        if (title.length < 1 || title[0] === ' ' || title[title.length - 1] === ' ' || pattern.test(title)) {
            return false;
        }
        return true;
    }
    return Course;
}
module.exports = solve;