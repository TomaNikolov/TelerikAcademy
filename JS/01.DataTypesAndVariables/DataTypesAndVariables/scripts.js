//Task 1
//Assign all the possible JavaScript literals to different 
//variables.

var intLit = 42,
    floatLit = 42.2,
    stringLit = 'Pesho',
    boollit = true,
    objlit = {
        name: 'Pesho',
        age: 16
    },
    funcLit = function () {
        alert('This is funtion literal');
    },
    arrLit = ['apple', 'bananas'];

function firstProblem() {
    animateSection(document.getElementById('p1-section'));
    document.getElementById('p1-result').innerHTML = 'See scripts.js file';
}

//Task 2
//Create a string variable with quoted text in it. For 
//example: 'How you doin'?', Joey said.
function quotedText() {
    var qText = 'How you doin"?", Joel said.';
    console.log(qText);

    animateSection(document.getElementById('p2-section'));
    document.getElementById('p2-result').innerHTML = qText;
}

//Task 3
//Try typeof on all variables you created.
function typeOfAllVar() {
    var arrOfAllLit = [intLit, floatLit, stringLit, boollit, objlit, funcLit, arrLit];
    for (var i = 0; i < arrOfAllLit.length; i++) {
        console.log(typeof arrOfAllLit[i]);
    }
    animateSection(document.getElementById('p3-section'));
    document.getElementById('p3-result').innerHTML = 'See console for result';
}
//typeOfVariables(arrOfAllLit, 'task3');

//task 4
//Create null, undefined variables and try typeof on them.
function typeOfVariables() {

    var undefVar,
        nullVar = null;

    console.log(typeof (undefVar));
    console.log(typeof (nullVar));
    animateSection(document.getElementById('p4-section'));

    var udefNode = document.createElement('p');
    var undefInformation = 'Type of undefined is ' + typeof (undefVar);
    udefNode.innerHTML = undefInformation;
    document.getElementById('p4-result').appendChild(udefNode);

    var nullNode = document.createElement('p');
    var nullInformation = 'Type of null is ' + typeof (nullNode);
    nullNode.innerHTML = nullInformation;
    document.getElementById('p4-result').appendChild(nullNode);

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
// animated section
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

