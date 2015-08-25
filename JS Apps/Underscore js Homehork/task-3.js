/* 
Create a function that:
*   Takes an array of students
    *   Each student has:
        *   `firstName`, `lastName` and `age` properties
        *   Array of decimal numbers representing the marks         
*   **finds** the student with highest average mark (there will be only one)
*   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve() {
    function getAverageMark(marks) {
        var sum = 0;
        _.each(marks, function(mark) {
            sum += mark;
        });

        return sum / marks.length;
    }

    return function(students) {
        _.chain(students)
            .map(function(student) {
                var avrMark = getAverageMark(student.marks);
                return {
                    fullName: student.firstName + ' ' + student.lastName,
                    averageMark: avrMark
                };
            })
            .sortBy(function(student) {
                return student.averageMark;
            })
            .last(1)
            .each(function(student) {
                console.log(student.fullName + ' has an average score of ' + student.averageMark);
            });
    };
}

module.exports = solve;
