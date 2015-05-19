//Problem 1. Numbers
//Write a script that prints all the numbers from 1 to N.
function print() {
    var textInputN = document.getElementById('p1-n'),
        n = parseInt(textInputN.value);

    textInputN.value = '';
    if (!(validation(n, textInputN))) {
        return;
    }
    animateSection(document.getElementById('p1-section'));
    for (var i = 0; i < n; i++) {
        document.getElementById('p1-result').innerHTML += i + ' ';
    }

}

//Problem 2. Numbers not divisible
//Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time
function numbersNotDivisible() {
    var textInputN = document.getElementById('p2-n'),
        n = parseInt(textInputN.value),
        result;

    textInputN.value = '';
    if (!(validation(n, textInputN))) {
        return;
    }
    animateSection(document.getElementById('p2-section'));
    for (var i = 0; i < n; i++) {
        if (i % 3 === 0 && i % 7 === 0) {
            continue;
        } else {
            document.getElementById('p2-result').innerHTML += i + ' ';
        }

    }
}

//Problem 3. Min/Max of sequence
//Write a script that finds the max and min number from a sequence of numbers.
function minMax() {
    var textInputN = document.getElementById('p3-n'),
        n = textInputN.value.split(' '),
        min,
        max;

    animateSection(document.getElementById('p3-section'));
    for (var j = 0; j < n.length; j++) {
        n[j] = parseInt(n[j]);
    }
    max = n[0];
    min = n[0];

    for (var i = 0; i < n.length; i++) {
        if (min > n[i]) {
            min = n[i];
        }
        if (max < n[i]) {
            max = n[i];
        }
    }
    document.getElementById('p3-result').innerHTML = 'Min = ' + min + '; Max = ' + max;
}

//Problem 4. Lexicographically smallest
//Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.
function lexicographicallySmallest() {
    var textInputN = document.getElementById('p4-n'),
        n = textInputN.options[textInputN.selectedIndex].value,
        obj,
        min = 0,
        max = 0;
    switch (n) {
        case '1':
            obj = window;
            break;
        case '2':
            obj = document;
            break;
        case '3':
            obj = navigator;
            break;
        default:
            obj = window;
    }

    animateSection(document.getElementById('p4-section'));

    for (var prop in obj) {

        if (!min) {
            min = prop;
        }
        if (!max) {
            max = prop;
        }
        if (min > prop) {
            min = prop;
        }
        if (max < prop) {
            max = prop;
        }
    }
    document.getElementById('p4-result').innerHTML = 'Min = ' + min + '; Max = ' + max;
    console.log(min);
    console.log(max);
}

//validation of number input
function validation(number, input) {
    if (isNaN(number)) {
        input.placeholder = 'Input must be a number';
        input.className = 'ivalidInput';
        return false;
    }
    input.className = '';
    return true;
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