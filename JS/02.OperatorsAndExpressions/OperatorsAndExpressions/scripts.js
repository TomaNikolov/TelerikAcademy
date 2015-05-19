//task 1
//Write an expression that checks if given integer is odd or even.

function oddOrEven() {
    var textInput = document.getElementById('oddOrEvenInput'),
        number = parseInt(textInput.value),
        result;
    textInput.value = '';
    if (!validation(number, textInput)) {
        return;
    }
    number % 2 === 0 ? result = 'even' : result = 'odd';

    document.getElementById('problem1Table').appendChild(createTableRow([number, result]));
}

//Problem 2 Divisible by 7 and 5
//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

function divisibleBy() {
    var textInput = document.getElementById('divisible-by'),
        number = parseInt(textInput.value),
        result;
    textInput.value = '';
    if (!validation(number, textInput)) {
        return;
    }
    (number % 5 === 0 && number % 7 === 0) ? result = 'true' : result = 'false';

    document.getElementById('problem2Table').appendChild(createTableRow([number, result]));
}

//Problem 3 Rectangle area
//Write an expression that calculates rectangle’s area by given width and height.
function rectArea() {
    var textInputWidth = document.getElementById('rect-width'),
        textInputHeight = document.getElementById('rect-height'),
        width = parseFloat(textInputWidth.value),
        height = parseFloat(textInputHeight.value),
        area;
    textInputHeight.value = '';
    textInputWidth.value = '';
    if (!(validation(width, textInputWidth) && validation(height, textInputHeight))) {
        return;
    }
    area = width * height;

    document.getElementById('problem3Table').appendChild(createTableRow([width, height, area]));
}

//Problem 4. Third digit
//Write an expression that checks for given integer if its third digit (right-to-left) is 7.
function thirdDigit() {
    var textInput = document.getElementById('third-digit'),
       number = parseInt(textInput.value),
       result;
    textInput.value = '';
    if (!validation(number, textInput)) {
        return;
    }

    var thirdDig = (number / 100) % 10;
    result = parseInt(thirdDig);
    document.getElementById('problem4Table').appendChild(createTableRow([number, result === 7]));
}

//Problem 5. Third bit
//Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.
function thirdBit() {
    var textInput = document.getElementById('third-bit'),
        number = parseInt(textInput.value),
        result,
        binary;
    textInput.value = '';
    if (!validation(number, textInput)) {
        return;
    }

    binary = number.toString(2);
    result = padLeft(binary, '0', 17);
    document.getElementById('problem5Table').appendChild(createTableRow([number, result, result[12]]));
}

//Problem 6. Point in Circle
//Write an expression that checks if given point P(x, y) is within a circle K(O, 5).
function pointInCircle() {
    var textInputX = document.getElementById('point-x'),
      textInputY = document.getElementById('point-y'),
      x = parseFloat(textInputX.value),
      y = parseFloat(textInputY.value),
      radius = 5,
      inside;
    textInputX.value = '';
    textInputY.value = '';
    if (!(validation(x, textInputX) && validation(y, textInputY))) {
        return;
    }
    inside = Math.abs(x + y) < radius;

    document.getElementById('problem6Table').appendChild(createTableRow([x, y, inside]));
}

//Problem 7. Is prime
//Write an expression that checks if given positive integer number n (n ≤ 100) is prime.
function isPrime() {
    var textInput = document.getElementById('prime'),
       number = parseInt(textInput.value),
       result;
    textInput.value = '';
    if (!validation(number, textInput)) {
        return;
    }

    number < 2 ? result = false : result = true;

    for (var i = 2; i < number; i++) {
        if (number % i === 0) {
            result = false;
        }
    }

    document.getElementById('problem7Table').appendChild(createTableRow([number, result]));
}

//Problem 8. Trapezoid area
//Write an expression that calculates trapezoid's area by given sides a and b and height h.
function trapArea() {
    var textInputA = document.getElementById('a'),
        textInputB = document.getElementById('b'),
        textInputH = document.getElementById('h'),
        a = parseFloat(textInputA.value),
        b = parseFloat(textInputB.value),
        h = parseFloat(textInputH.value),
        area;

    textInputA.value = '';
    textInputB.value = '';
    textInputH.value = '';
    if (!(validation(a, textInputA) && validation(b, textInputB) && validation(h, textInputH))) {
        return;
    }
    area = ((a+ b) /2) * h;

    document.getElementById('problem8Table').appendChild(createTableRow([a, b, h, area]));
}

//Problem 9. Point in Circle and outside Rectangle
//Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3)
//and out of the rectangle R(top=1, left=-1, width=6, height=2).
function inCircleOutRect() {
    var textInputX = document.getElementById('new-point-x'),
     textInputY = document.getElementById('new-point-y'),
     x = parseFloat(textInputX.value),
     y = parseFloat(textInputY.value),
     radius = 3,
     result;
    textInputX.value = '';
    textInputY.value = '';
    if (!(validation(x, textInputX) && validation(y, textInputY))) {
        return;
    }
    result = (Math.abs(x - 1 ) + Math.abs(y - 1) < radius) &&
          !(x >= -1 && x <= 5 && y <= 1 && y >= -1);

    document.getElementById('problem9Table').appendChild(createTableRow([x, y, result]));
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

function padLeft(binarStr, symbol, lenght) {

    var pad = Array(lenght).join(symbol);
    var result = pad.substring(0, pad.length - binarStr.length) + binarStr;
    return result;
}