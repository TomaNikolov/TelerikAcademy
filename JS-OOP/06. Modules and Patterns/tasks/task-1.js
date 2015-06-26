/* Task Description */
/* 
 * Create a module for a Telerik Academy course
 * The course has a title and presentations
 * Each presentation also has a title
 * There is a homework for each presentation
 * There is a set of students listed for the course
 * Each student has firstname, lastname and an ID
 * IDs must be unique integer numbers which are at least 1
 * Each student can submit a homework for each presentation in the course
 * Create method init
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
 * StudentIDs which are not listed get 0 points
 * Throw if there is an invalid StudentID
 * Throw if same StudentID is given more than once ( he tried to cheat (: )
 * Throw if Score is not a number
 * Create method getTopStudents which returns an array of the top 10 performing students
 * Array must be sorted from best to worst
 * If there are less than 10, return them all
 * The final score that is used to calculate the top performing students is done as follows:
 * 75% of the exam result
 * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
 */

function solve() {
    var Course = {
        init: function (title, presentations) {
            this.title = title;
            this.presentations = presentations;
            this._students = [];

            return this;
        },
        addStudent: function (name) {
            var id = this._students.length + 1,
                student = getStudent(name, id);

            this._students.push(student);

            return id;
        },
        getAllStudents: function () {
            return this._students.map(function (student) {
                return {
                    firstname: student.firstName,
                    lastname: student.lastName,
                    id: student.id
                }
            });
        },
        submitHomework: function (studentID, homeworkID) {
            var student;


            if (studentID > this._students.length || !isValidId(studentID)) {
                throw Error("invalid student Id");
            }

            if (homeworkID > this.presentations.length || !isValidId(homeworkID)) {
                throw Error('Invalid homeworkId')
            }

            student = this._students[studentID - 1];
            student.homeworksCount += 1;

            return this;
        },
        pushExamResults: function (results) {
            var student = this._students[results.studentID - 1];
            student.examScore = results.Score;
        },
        getTopStudents: function () {
            var allHomework = this.presentations.length,
                result = this._students.forEach(function (students) {
                    students.finalScore = (students.examScore * 0.75) + ((students.homeworksCount / allHomework) * 25);
                });

            result = result.sort(function (first, second) {
                return second.finalScore - first.finalScore;
            });

            return result.slice(0,10);
        }
    };

    Object.defineProperty(Course, 'title', {
        get: function () {
            return this._title;
        },
        set: function (value) {
            if (!isValidTitle(value)) {
                throw Error('Invalid course title!');
            }

            this._title = value;
        }
    });

    Object.defineProperty(Course, 'presentations', {
        get: function () {
            return this._presentations.slice();
        },
        set: function (presentations) {
            if (!Array.isArray(presentations)) {
                throw Error('Invalid presentation!')
            }

            if (!presentations.length) {
                throw Error('Empty presentations!')
            }

            presentations = presentations.map(function (title, index) {
                return getPresentation(title, index + 1);
            });

            this._presentations = presentations;

            return this;
        }
    });


    var Student = {
        init: function (name, id) {

            var studentNamesSplit = name.split(' '),
                firstName = studentNamesSplit[0],
                lastName = studentNamesSplit[1];

            if (studentNamesSplit[2]) {
                throw Error('Student must have only two names!');
            }

            if ((!isValidName(firstName)) || (!isValidName(lastName))) {
                throw  Error('Invalid student name!');
            }

            this.id = id;

            this.firstName = firstName;
            this.lastName = lastName;
            this.examScore = 0;
            this._homeworkCount = 0;
            this._submittedHomework = [];

            return this;
        },
        submitHomework: function (homeworkID) {
            if (!this._submittedHomework[homeworkID]) {
                throw Error('This homework is submitted')
            }
            this._homeworkCount++;
            this._submittedHomework[homeworkID] = 'ok';

            return this;
        }
    };

    Object.defineProperty(Student, 'homeworkCount', {
        get: function () {
            return this._homeworkCount;
        }
    });
    function getStudent(name, id) {
        var student = Object.create(Student);
        return student.init(name, id);
    }

    var Presentation = {
        init: function (title, id) {
            if (!isValidTitle(title)) {
                throw Error('Invalid presentation name!')
            }
            this.id = id;

            return this;
        }
    };

    function getPresentation(title, id) {
        var presentation = Object.create(Presentation)
        return presentation.init(title, id);
    }

    function isValidTitle(title) {
        if (typeof title !== 'string') {
            return false;
        }
        if (title === '') {
            return false;
        }
        if (title[0] === ' ' || title[title.length - 1] === ' ') {
            return false;
        }

        if (/[\s]{2,}/.test(title)) {
            return false;
        }

        return true;
    }

    function isValidName(name) {
        return /^[A-Z]{1}[a-z]*$/.test(name);
    }

    function isValidId(id) {
        return id == parseInt(id) && id > 0;
    }

    return Course;
}


module.exports = solve;
