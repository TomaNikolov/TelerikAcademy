//Problem 1. English digit
//Write a function that returns the last digit of given integer as an English word.
function englishDigit() {
    var textInputN = document.getElementById('p1-n'),
        n = parseInt(textInputN.value),
        result;

    if (!(validation(n, textInputN))) {
        return;
    }

    result = getLastDigitAsWord(Math.floor(n % 10))

    document.getElementById('problem1Table').appendChild(createTableRow([n, result]));
}

//Problem 2. Reverse number
//Write a function that reverses the digits of given decimal number.
function reverseNumber() {
    var textInputN = document.getElementById('p2-n'),
        result = textInputN.value.split('');


    if (!(validation(parseInt(textInputN.value), textInputN))) {
        return;
    }

    document.getElementById('problem2Table').appendChild(createTableRow([textInputN.value, result.reverse().join('')]));
}

//Problem 3. Min/Max of sequence
//Write a script that finds the max and min number from a sequence of numbers.
function occurrence() {
    var textInputT = document.getElementById('p3-t'),
        textInputW = document.getElementById('p3-w'),
        select = document.getElementById('p3-c'),
        text = textInputT.value,
        word = textInputW.value,
        caseSensitive = select.value === '1' ? true : false;

    var occurrence = countOccurrence(text, word, caseSensitive);

    animateSection(document.getElementById('p3-section'));
    document.getElementById('p3-result').innerHTML = word + ' : ' + occurrence + ' times';
}

//Problem 4. Maximal increasing sequence
//Write a script that finds the maximal increasing sequence in an array.
function numberOfElement() {
    var result = document.getElementsByTagName('div')

    animateSection(document.getElementById('p4-section'));
    document.getElementById('p4-result').innerHTML = result.length + ' times';
}

//Problem 5. Appearance count
//Write a function that counts how many times given number appears in given array.
//Write a test function to check if the function is working correctly.
function appearanceCount() {
    var textInputN = document.getElementById('p5-n'),
        textInputC = document.getElementById('p5-c'),
        n = parseInt(textInputC.value),
        arr = textInputN.value.split(/[ ,]+/);

    var searchedNumber = {
        value: n,
        times: 0
    };
    for (var i = 0; i < arr.length; i++) {
        if (searchedNumber.value === parseInt(arr[i])) {
            searchedNumber.times++;
        }

    }
    animateSection(document.getElementById('p5-section'));
    document.getElementById('p5-result').innerHTML = searchedNumber.value + ' : ' + searchedNumber.times + ' times';
}

//Problem 6. Larger than neighbours
//Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).
function larger() {
    var textInputN = document.getElementById('p6-n'),
        textInputC = document.getElementById('p6-c'),
        index = parseInt(textInputC.value),
        arr = textInputN.value.split(/[ ,]+/);

    for (var j = 0; j < arr.length; j++) {
        arr[j] = parseInt(arr[j]);
    }

    animateSection(document.getElementById('p6-section'));
    document.getElementById('p6-result').innerHTML = largerThanNeighbours(arr, index) > 0 ? 'Element is bigger than its two neighbours' :
        'Element is not  bigger than its two neighbours';
}

//Problem 7. First larger than neighbours
//Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
//Use the function from the previous exercise.
function firstLargerThanNeibhours() {
    var textInputN = document.getElementById('p7-n'),
        arr = textInputN.value.split(/[ ,]+/),
        index = -1;

    for (var j = 0; j < arr.length; j++) {
        arr[j] = parseInt(arr[j]);
    }
    for (var i = 0; i < arr.length; i++) {
        if (largerThanNeighbours(arr, i) > 0) {
            index = i;
        }

    }
    animateSection(document.getElementById('p7-section'));
    document.getElementById('p7-result').innerHTML = index > 0 ? ' First element  bigger than its two neighbours is on position ' + index :
        'Theare is no element bigger than its two neighbours';
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

function getLastDigitAsWord(digit) {
    switch (digit) {
        case 0:
            return 'Zero;';
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
    }

}
function countOccurrence(text, word, isCaseSensitive) {
    var replacedPunctuation = text.replace(/\W+/g, ' ');

    if (!isCaseSensitive) {
        replacedPunctuation = replacedPunctuation.toLowerCase();
        word = word.toLowerCase();
    }

    var words = replacedPunctuation.split(' ');

    var occurrences = 0;

    for (var ind = 0; ind < words.length; ind++) {
        if (words[ind] === word) ++occurrences;
    }

    return occurrences;
}

//checks if the element at given position in given array of integers is bigger than its two
function largerThanNeighbours(arr, index) {
    if (index <= 0 || index >= arr.length - 1) {
        return -1;
    }
    if (arr[index - 1] < arr[index] && arr[index + 1] < arr[index]) {
        return 1;
    } else {
        return -1;
    }
}