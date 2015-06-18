/* Task Description */
/* 
 Create a function constructor for Person. Each Person must have:
 *	properties `firstname`, `lastname` and `age`
 *	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
 *	age must always be a number in the range 0 150
 *	the setter of age can receive a convertible-to-number value
 *	if any of the above is not met, throw Error
 *	property `fullname`
 *	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
 *	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
 *	it must parse it and set `firstname` and `lastname`
 *	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
 *	all methods and properties must be attached to the prototype of the Person
 *	all methods and property setters must return this, if they are not supposed to return other value
 *	enables method-chaining
 */
function solve() {
    var Person = (function () {

        var _firsname,
            _lastname,
            _age;

        function Person(firstName, lastName, age) {
            this.firstname = firstName;
            this.lastname = lastName;
            this.age = age;
        }

        Person.prototype = {

            get firstname() {

                return _firsname;
            },
            set firstname(name) {

                if (!validateName(name)) {
                    throw Error('Invalid first name');
                }

                _firsname = name;
            },
            get lastname() {

                return _lastname;
            },
            set lastname(name) {

                if (!validateName(name)) {
                    throw Error('Invalid last name');
                }

                _lastname = name;
            },
            get age() {

                return _age;
            },
            set age(age) {

                if (!validateAge(age)) {
                    throw Error('Age is not valid')
                }

                _age = age;
            },
            get fullname() {

                return _firsname + ' ' + _lastname;
            },
            set fullname(fullName) {
                var splitNames = fullName.split(' '),
                    firstName = splitNames[0],
                    lastName = splitNames[1];

                if (!validateName(firstName)) {
                    throw Error('Invalid first name');
                }

                if (!validateName(lastName)) {
                    throw Error('Invalid last name');
                }
                _firsname = firstName;
                _lastname = lastName;
            },
            introduce: function () {

                return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
            }

        };

        function validateName(name) {

            return /^[a-zA-Z]{3,20}$/.test(name);
        }

        function validateAge(age) {

            return (age >= 0 && age <= 150);
        }

        return Person;
    }());
    return Person;
}
module.exports = solve;