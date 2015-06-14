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

//Problem 1. Make person
//Each person must have firstname, lastname, age and gender (true is female, false is male)
var Person = (function () {
    function Person(firstName, lastName, age, gender) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.gendre = gender ? 'female' : 'male';
    }

    Person.prototype ={
      fullName: function() {
       return  this.firstName + ' ' + this.lastName;
      }
    };
    return Person;
}());

//Generate an array with ten person with different names, ages and genders
var arrOfPerson = [new Person('Mariq', 'Mitkova', 12, true),
    new Person('Pesho', 'Mitkov', 19, false),
    new Person('Gosho', 'Mitkov', 20, false),
    new Person('Pesho', 'Ivanov', 16, false),
    new Person('Stamat', 'Mitkov', 31, false),
    new Person('Mitko', 'Goshov', 54, false),
    new Person('Mitka', 'Mitkova', 18, true),
    new Person('Stamata', 'Stamatova', 23, true),
    new Person('Didka', 'Mitkova', 65, true),
    new Person('Kana', 'Didkova', 100, true)
];

function showArrOfPerson(){
    var i,
        currentPerson,
        len = arrOfPerson.length;
    for (i = 0; i < len; i++) {
currentPerson = arrOfPerson[i];
        document.getElementById('problem1Table').appendChild(createTableRow(
            [currentPerson.firstName, currentPerson.lastName, currentPerson.age, currentPerson.gendre]));
    }
}

//Problem 2. People of age
//Write a function that checks if an array of person contains only people of age (with age 18 or greater)
//Use only array methods and no regular loops (for, while)
function peopleOfAge() {
    var ageAboveEightine = ageGreater(18, arrOfPerson);

    animateSection(document.getElementById('p2-section'));
    document.getElementById('p2-result').innerHTML = ageAboveEightine;
}

function ageGreater(age, arr) {
    return arr.every(function (item) {
        if (item.age >= age) {
            return true;
        } else {
            return false;
        }
    });
}

//Problem 3. Underage people
//Write a function that prints all underaged persons of an array of person
//Use Array#filter and Array#forEach
//Use only array methods and no regular loops (for, while)
function UnderagePeople() {
   var underAgePerson = getUnderage(arrOfPerson);

    animateSection(document.getElementById('p3-section'));
    document.getElementById('p3-result').innerHTML = JSON.stringify(underAgePerson);

}

function getUnderage(arr) {
    var result = arr.filter(function (item) {
        return item.age < 18;
    });
   return result;
}


//Problem 4. Average age of females
//Write a function that calculates the average age of all females, extracted from an array of persons
//Use Array#filter
//Use only array methods and no regular loops (for, while)

function averageAgeOfFemales() {
var femaleArr = maleOrFemales(arrOfPerson, 'female'),
    avrAge = averageAge(femaleArr);

    animateSection(document.getElementById('p4-section'));
    document.getElementById('p4-result').innerHTML = 'Average age of female is: ' + avrAge;
}

function maleOrFemales(arr, genre) {
    var result = arr.filter(function (item) {
        return item.gendre === genre;

    });
    return result;
}

function averageAge(arr) {
    var result= 0,
        count = 0;
    arr.forEach(function (item) {

        result += item.age;
        count += 1;
    });
    return result /count;
}

//Problem 5. Youngest person
//Write a function that finds the youngest male person in a given array of people and prints his full name
//Use only array methods and no regular loops (for, while)
//Use Array#find

function youngestPerson(){
var maleArr = maleOrFemales(arrOfPerson, 'male'),
    youngest = minAge(maleArr);

    animateSection(document.getElementById('p5-section'));
    document.getElementById('p5-result').innerHTML = youngest.fullName();
}

function minAge(arr){
   var personWithMinAge = arr.reduce(function(first, second) {
        return first.age > second.age ? second : first;
    });
    return personWithMinAge;
}

//Problem 6. Group people
//Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
//Use Array#reduce
//Use only array methods and no regular loops (for, while)

function gPeople(){
var groupedPerson =groupeByFirstLetter(arrOfPerson);
    animateSection(document.getElementById('p6-section'));
    document.getElementById('p6-result').innerHTML = 'See the console for result';
    console.log(JSON.stringify(groupedPerson));
}
function groupeByFirstLetter(arr){
    var gropedPerson = {};
    arr.forEach(function(person){
        var firssLetter = person.firstName.toString().substring(0, 1);
        if(!gropedPerson[firssLetter]){
            gropedPerson[firssLetter] = [];
        }
        gropedPerson[firssLetter].push({
            firstName: person.firstName,
            lastName: person.lastName,
            age: person.age,
            gender: person.gender
    });
    });
    return gropedPerson;
}