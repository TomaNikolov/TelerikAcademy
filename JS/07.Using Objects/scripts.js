//Problem 1. Planar coordinates
//Write functions for working with shapes in standard Planar coordinate system.
//Points are represented by coordinates P(X, Y)
//Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
//Calculate the distance between two points.
//Check if three segment lines can form a triangle.

//Make point
var Point = (function () {
    function Point(x, y) {
        if (!isFinite(x) && !isFinite(y)) {
            throw  new Error('x and y must be a number')
        }

        this.x = x;
        this.y = y;
    }

    Point.prototype = {
        toString: function () {
            return 'P(' + this.x + ',' + this.y + ')';
        }
    };

    return Point;
}());
//Make Line
var Line = (function () {
    function Line(firstPoint, secondPoint) {

        if (!firstPoint instanceof Point && !secondPoint instanceof Point) {
            throw  new Error('firstPoint and secondPoint must be instanceof Point')
        }
        this.startPoint = firstPoint;
        this.endPoint = secondPoint;
    }

    Line.prototype = {
        toString: function () {
            return 'L(' + this.startPoint.toString() + ',' + this.endPoint.toString() + ')';
        },
        distance: function () {
            return Math.abs(this.startPoint.x - this.endPoint.x) +
                Math.abs(this.startPoint.y - this.startPoint.y);
        }
    };
    return Line;
}());

function canFormTriangle(lineA, lineB, lineC) {
    if (!lineA instanceof Line && !lineB instanceof Line && lineC instanceof Line) {
        throw  new Error('lineA, lineB, lineC must be instanceof  of Line')
    }
    return lineA.distance() < lineB.distance() + lineC.distance() &&
        lineB.distance() < lineC.distance() + lineA.distance() &&
        lineC.distance() < lineA.distance() + lineB.distance();
}


function planarCoordinates() {
    var textInputA = document.getElementById('p1-a'),
        textInputB = document.getElementById('p1-b'),
        textInputC = document.getElementById('p1-c'),
        a = (textInputA.value).split(' ').map(parse),
        b = (textInputB.value).split(' ').map(parse),
        c = (textInputC.value).split(' ').map(parse),
        pointA = new Point(a[0], a[1]),
        pointB = new Point(b[0], b[1]),
        pointC = new Point(c[0], c[1]),
        lineAB = new Line(pointA, pointB),
        lineAC = new Line(pointA, pointC),
        lineBC = new Line(pointB, pointC),
        distanceAB = lineAB.distance(),
        distanceAC = lineAC.distance(),
        distanceBC = lineBC.distance();
    canFormTriangleFromLine = canFormTriangle(lineAB, lineBC, lineAC);

    animateSection(document.getElementById('p1-section'));
    document.getElementById('p1-result').innerHTML = lineAB + ', ' + lineBC  + ', ' + lineAC + '. Can form triangle: ' + canFormTriangleFromLine;

    console.log('=======Problem 1:========');
    console.log(lineAB.toString());
    console.log(lineAC.toString());
    console.log(lineBC.toString());
    console.log('=======distanceAB:========');
    console.log(distanceAB);
    console.log('=======distanceAC:========');
    console.log(distanceAC);
    console.log('=======distanceBC:========');
    console.log(distanceBC);

}

function parse(number) {
    return parseFloat(number);
}

//Problem 2. Remove elements
//Write a function that removes all elements with a given value.
//Attach it to the array type.
//Read about prototype and how to attach methods.
function removeElement() {
    var textInputN = document.getElementById('p2-n'),
        textInputC = document.getElementById('p2-c'),
        element = textInputC.value,
        arr = textInputN.value.split(/[ ,]+/);

    arr.remove(element);
    document.getElementById('problem2Table').appendChild(createTableRow([textInputN.value, arr.join(',')]));
}

Array.prototype.remove = function (element) {

    for (var i = 0; i < this.length; i++) {
        if (this[i] === element) {
            this.splice(i, 1);
            i--;
        }
    }
    return this;
};

//Problem 3. Deep copy
//Write a function that makes a deep copy of an object.
//The function should work for both primitive and reference types.

function dCopy() {

    animateSection(document.getElementById('p3-section'));
    document.getElementById('p3-result').innerHTML = 'See in the scripts.js for clone function';
    console.log('=======Problem 3:========');
    console.log(clone({name: 'pesho', age: 15}));

}

function clone(obj) {
    if (null === obj || 'object' !== typeof obj) {
        return obj;
    }
    var copy = obj.constructor();
    for (var prop in obj) {
        if (obj.hasOwnProperty(prop)) {
            copy[prop] = obj[prop];
        }

    }
    return copy;
}

//Problem 4. Has property
//Write a function that checks if a given object contains a given property.
function hasOwnPr() {
    animateSection(document.getElementById('p4-section'));
    document.getElementById('p4-result').innerHTML = 'See in the scripts.js for hasProperty function';
    var pesho = {
        name: 'pasho',
        age: 12
    };
    console.log('=======Problem 4:========');
    console.log(hasProperty(pesho, 'age'));
}


function hasProperty(obj, prop) {
    return obj.hasOwnProperty(prop);
}


//Problem 5. Appearance count
//Write a function that counts how many times given number appears in given array.
//Write a test function to check if the function is working correctly.

var Person = (function () {
    function Person(firstName, lastName, age, gender) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.gendre = gender;
    }

    Person.prototype = {
        fullName: function () {
            return this.firstName + ' ' + this.lastName;
        }
    };
    return Person;
}());

// make arr of person
var arrOfPerson = [new Person('Mariq', 'Mitkova', 12, 'female'),
    new Person('Pesho', 'Mitkov', 19, 'male'),
    new Person('Gosho', 'Mitkov', 20, 'male'),
    new Person('Pesho', 'Ivanov', 16, 'male'),
    new Person('Stamat', 'Mitkov', 31, 'male'),
    new Person('Mitko', 'Goshov', 54, 'male'),
    new Person('Mitka', 'Mitkova', 18, 'female'),
    new Person('Stamata', 'Stamatova', 23, 'female'),
    new Person('Didka', 'Mitkova', 65, 'female'),
    new Person('Kana', 'Didkova', 100, 'female')
];
//Problem 5
function youngestPerson() {
    var i,
        len,
        currentPerson,
        youngest = minAge(arrOfPerson);

    len = arrOfPerson.length;
    for (i = 0; i < len; i++) {
        currentPerson = arrOfPerson[i];
        document.getElementById('problem5Table').appendChild(createTableRow(
            [currentPerson.firstName, currentPerson.lastName, currentPerson.age, currentPerson.gendre]));
    }

    animateSection(document.getElementById('p5-section'));
    document.getElementById('p5-result').innerHTML = youngest.fullName();
}
//get person with min age
function minAge(arr) {
    var personWithMinAge = arr.reduce(function (first, second) {
        return first.age > second.age ? second : first;
    });
    return personWithMinAge;
}

//Problem 6.
//Write a function that groups an array of people by age, first or last name.
//The function must return an associative array, with keys - the groups, and values - arrays with people in this groups

function gPeople() {
    var groupedPerson = groupeByFirstLetter(arrOfPerson, 'firstName');
    animateSection(document.getElementById('p6-section'));
    document.getElementById('p6-result').innerHTML = 'See the console for result';
    console.log(JSON.stringify(groupedPerson));
}
function groupeByFirstLetter(arr, param) {
    var gropedPerson = {};
    arr.forEach(function (person) {
        var key;
        param === 'firstName' ? key = person.firstName : param === 'lastName' ? key = person.lastName : key = person.age;
        if (!gropedPerson[key]) {
            gropedPerson[key] = [];
        }
        gropedPerson[key].push({
            firstName: person.firstName,
            lastName: person.lastName,
            age: person.age,
            gender: person.gender
        });
    });
    return gropedPerson;
}


//Create table row
function createTableRow(arrOfTd) {
    var currentTr = document.createElement('tr');
    for (var i = 0; i < arrOfTd.length; i++) {
        var currentTd = document.createElement('td');
        currentTd.innerHTML = arrOfTd[i];
        currentTr.appendChild(currentTd);
    }
    return currentTr;
}

function animateSection(element) {
    var left = 0;

    function frame() {
        left++;
        element.style.width = left + '%';
        if (left === 100) {
            clearInterval(id);
        }
    }

    var id = setInterval(frame, 10);
}

function validation(number, input) {
    if (isNaN(number)) {
        input.placeholder = 'Input must be a number';
        input.className = 'invalidInput';
        return false;
    }
    input.className = '';
    return true;
}



