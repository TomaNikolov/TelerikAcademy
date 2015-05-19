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

var node = document.createElement('p');
node.innerHTML = 'See scripts.js file';
visualization(node, 'task1');

//Task 2
//Create a string variable with quoted text in it. For 
//example: 'How you doin'?', Joey said.

var quotedText = 'How you doin"?", Joel said.';
console.log(quotedText);

var node = document.createElement('p');
node.innerHTML = quotedText;
visualization(node, 'task2');

//Task 3
//Try typeof on all variables you created.
var arrOfAllLit = [intLit, floatLit, stringLit, boollit, objlit, funcLit, arrLit];
typeOfVariables(arrOfAllLit, 'task3');

//task 4
//Create null, undefined variables and try typeof on them.
var undefVar;
var nullVar = null;
console.log(typeof (undefVar));
console.log(typeof (null));
typeOfVariables([undefVar, nullVar], 'task4');


function typeOfVariables(param, taskName) {
    for (var i = 0; i < param.length; i++) {
        console.log(typeof param[i]);
        var node = document.createElement('p');

        var information = 'Type of ' + param[i] + ' is ' + typeof (param[i]);
        node.innerHTML = information;
        visualization(node, taskName);

    }
}

function visualization(node, taskName) {
    document.getElementById(taskName).appendChild(node);
}

