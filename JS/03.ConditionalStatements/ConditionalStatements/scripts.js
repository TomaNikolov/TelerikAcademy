//Problem 1. Exchange if greater
//Write an if statement that takes two double variables a and b and
//exchanges their values if the first one is greater than the second.
//As a result print the values a and b, separated by a space.
function exchangeIfGreater() {
    var textInputA = document.getElementById('p1-a'),
        textInputB = document.getElementById('p1-b'),
        a = parseFloat(textInputA.value),
        b = parseFloat(textInputB.value),
        result;

    textInputA.value = '';
    textInputB.value = '';
    if (!(validation(a, textInputA) && validation(b, textInputB))) {
        return;
    }
    a < b ? result = a.toString() + ' ' + b.toString() : result = b.toString() + ' ' + a.toString()

    document.getElementById('problem1Table').appendChild(createTableRow([a, b, result]));
}

//Problem 2. Multiplication Sign
//Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.
function multiplicationSign() {
    var textInputA = document.getElementById('p2-a'),
        textInputB = document.getElementById('p2-b'),
        textInputC = document.getElementById('p2-c'),
        a = parseFloat(textInputA.value),
        b = parseFloat(textInputB.value),
        c = parseFloat(textInputC.value),
        result;

    textInputA.value = '';
    textInputB.value = '';
    textInputC.value = '';
    if (!(validation(a, textInputA) && validation(b, textInputB) && validation(c, textInputC))) {
        return;
    }
    if (a === 0 && b === 0 && c === 0) {
        result = "0";
    }
    else if (a > 0 && b > 0 && c > 0) {
        result = "+";
    }
    else if (a < 0 && b < 0 && c < 0) {
        result = "-";
    }
    else if (a < 0 && b < 0 && c > 0) {
        result = "+";
    }
    else if (a < 0 && b > 0 && c < 0) {
        result = "+";
    }
    else if (a > 0 && b < 0 && c < 0) {
        result = "+";
    }
    else if (a < 0 && b > 0 && c > 0) {
        result = "-";
    }
    else if (a > 0 && b < 0 && c > 0) {
        result = "-";
    }
    else if (a > 0 && b > 0 && c < 0) {
        result = "-";
    }
    else if (a === 0 || b === 0 || c === 0) {
        result = "0";
    }

    document.getElementById('problem2Table').appendChild(createTableRow([a, b, c, result]));
}

//Problem 3. The biggest of Three
//Write a script that finds the biggest of three numbers.
//Use nested if statements.
function biggestOfThree() {
    var textInputA = document.getElementById('p3-a'),
        textInputB = document.getElementById('p3-b'),
        textInputC = document.getElementById('p3-c'),
        a = parseFloat(textInputA.value),
        b = parseFloat(textInputB.value),
        c = parseFloat(textInputC.value),
        result;

    textInputA.value = '';
    textInputB.value = '';
    textInputC.value = '';
    if (!(validation(a, textInputA) && validation(b, textInputB) && validation(c, textInputC))) {
        return;
    }
    result = biggestOfTwo(a, b);
    result = biggestOfTwo(result, c);

    document.getElementById('problem3Table').appendChild(createTableRow([a, b, c, result]));
}

//Problem 4. Sort 3 numbers
//Sort 3 real values in descending order.
//Use nested if statements.
function sortNumbers() {
    var textInputA = document.getElementById('p4-a'),
        textInputB = document.getElementById('p4-b'),
        textInputC = document.getElementById('p4-c'),
        a = parseFloat(textInputA.value),
        b = parseFloat(textInputB.value),
        c = parseFloat(textInputC.value),
        result;

    textInputA.value = '';
    textInputB.value = '';
    textInputC.value = '';
    if (!(validation(a, textInputA) && validation(b, textInputB) && validation(c, textInputC))) {
        return;
    }

    if (a >= b && b >= c) {
        result = sort(a, b, c);
    }
    else if (a > c && b > c) {
        result = sort(a, c, b);
    }
    else if (b > a && a >= c) {
        result = sort(b, a, c);
    }
    else if (b > c && c > a) {
        result = sort(b, c, a);
    }
    else if (c > a && a >= b) {
        result = sort(c, a, b);
    } else {
        result = sort(c, b, a);
    }

    document.getElementById('problem4Table').appendChild(createTableRow([a, b, c, result]));
}

//Problem 5. Digit as word
//Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//Print “not a digit” in case of invalid input.
//Use a switch statement.
function digitAsWord() {
    var textInputA = document.getElementById('p5-digit'),
        a = parseFloat(textInputA.value),
        result;

    result = returnWord(a);
    document.getElementById('problem5Table').appendChild(createTableRow([textInputA.value, result]));
    textInputA.value = '';

}

//Problem 6. Quadratic equation
//Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
//Calculates and prints its real roots.
//Note: Quadratic equations may have 0, 1 or 2 real roots.
function quadraticEquation() {
    var textInputA = document.getElementById('p6-a'),
        textInputB = document.getElementById('p6-b'),
        textInputC = document.getElementById('p6-c'),
        a = parseFloat(textInputA.value),
        b = parseFloat(textInputB.value),
        c = parseFloat(textInputC.value),
        x1,
        x2,
        discriminant,
        result;

    textInputA.value = '';
    textInputB.value = '';
    textInputC.value = '';

    if (!(validation(a, textInputA) && validation(b, textInputB) && validation(c, textInputC))) {
        return;
    }
    discriminant = (b * b) - 4 * a * c;
    if (discriminant >= 0) {
        x2 = (-b + Math.sqrt(discriminant)) / (2 * a);
        x1 = (-b - Math.sqrt(discriminant)) / (2 * a);
        result = 'x1=' + x1 + '; x2=' + x2;
    }
    else if (discriminant === 0) {
        x1 = -(b / (2 * a));
        result = 'x1=x2=' + x1;
    } else {
        result = 'no real roots';
    }

    document.getElementById('problem6Table').appendChild(createTableRow([a, b, c, result]));
}

//Problem 7. The biggest of five numbers
//Write a script that finds the greatest of given 5 variables.
//Use nested if statements.
function biggestOfFive() {
    var textInputA = document.getElementById('p7-a'),
        textInputB = document.getElementById('p7-b'),
        textInputC = document.getElementById('p7-c'),
        textInputD = document.getElementById('p7-d'),
        textInputE = document.getElementById('p7-e'),
        a = parseFloat(textInputA.value),
        b = parseFloat(textInputB.value),
        c = parseFloat(textInputC.value),
        d = parseFloat(textInputD.value),
        e = parseFloat(textInputE.value),
        result;

    textInputA.value = '';
    textInputB.value = '';
    textInputC.value = '';
    textInputD.value = '';
    textInputE.value = '';

    if (!(validation(a, textInputA) && validation(b, textInputB) && validation(c, textInputC)
         && validation(d, textInputD) && validation(e, textInputE))) {
        return;
    }

    result = biggestOfTwo(a, b);
    result = biggestOfTwo(result, c);
    result = biggestOfTwo(result, d);
    result = biggestOfTwo(result, e);

    document.getElementById('problem7Table').appendChild(createTableRow([a, b, c, d, e, result]));
}

//Problem 8. Number as words
//Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.
function numbersAsWords() {
    var textInputA = document.getElementById('p8-a'),
       a = parseInt(textInputA.value),
       result;

    if (!(validation(a, textInputA))) {
        return;
    }
    if (a <= 20) {
        result = returnWord(a);
    }
    else if (a < 100) {
        var tenths = a % 10;
        result = returnWord(a - tenths) + ' ';
        if (tenths !== 0) {
            result += returnWord(tenths).toLowerCase();
        }
    } else {
        tenths = a % 100;
        var hundreds = parseInt(a / 100);
        if (tenths !== 0) {
            result = returnWord(hundreds) + ' hundred and ';
            if (tenths < 20) {
                result += returnWord(tenths).toLowerCase();
            } else {
                var units = tenths % 10;
                result += returnWord(tenths - units).toLowerCase() + ' ' +
                returnWord(units).toLowerCase();
            }
        } else {
            result = returnWord(hundreds) + ' hundred';
        }
    }

    document.getElementById('problem8Table').appendChild(createTableRow([textInputA.value, result]));
    textInputA.value = '';
}

//Create Table row
function createTableRow(arrOfTd) {
    var currentTr = document.createElement('tr');
    for (var i = 0; i < arrOfTd.length; i++) {
        var currentTd = document.createElement('td');
        currentTd.innerHTML = arrOfTd[i];
        currentTr.appendChild(currentTd);
    }
    return currentTr;
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

function biggestOfTwo(first, second) {
    var result;
    first > second ? result = first : result = second;
    return result;
}

function sort(first, second, third) {
    return first.toString() + ' '
        + second.toString() + ' '
        + third.toString();
}

function returnWord(number) {
    switch (number) {
        case 1:
            return 'One';
        case 2:
            return 'Two';
        case 3:
            return 'Three';
        case 4:
            return 'Four';
        case 5:
            return 'Five';
        case 6:
            return 'Six';
        case 7:
            return 'Seven';
        case 8:
            return 'Eight';
        case 9:
            return 'Nine';
        case 10:
            return 'Ten';
        case 11:
            return 'Eleven';
        case 12:
            return 'Twelve ';
        case 13:
            return 'Thirteen';
        case 14:
            return 'Fourteen ';
        case 15:
            return 'Fifteen ';
        case 16:
            return 'Sixteen ';
        case 17:
            return 'Seventeen ';
        case 18:
            return 'Eighteen ';
        case 19:
            return 'Nineteen';
        case 20:
            return 'Twenty ';
        case 30:
            return 'Thirty ';
        case 40:
            return 'Forty ';
        case 50:
            return 'Fifty ';
        case 60:
            return 'Sixty ';
        case 70:
            return 'Seventy ';
        case 80:
            return 'Eighty ';
        case 90:
            return 'Ninety';
        default:
            return 'not a digit';
    }
}