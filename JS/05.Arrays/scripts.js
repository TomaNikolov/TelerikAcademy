//Problem 1. Increase array members
//Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.
function print() {
    var textInputN = document.getElementById('p1-n'),
        n = parseInt(textInputN.value),
        result = [20];

    textInputN.value = '';
    if (!(validation(n, textInputN))) {
        return;
    }
    animateSection(document.getElementById('p1-section'));
    for (var i = 0; i < n; i++) {
        result[i] = i * 5;
    }
    document.getElementById('p1-result').innerHTML = result.join(',');
}

//Problem 2. Lexicographically comparison
//Write a script that compares two char arrays lexicographically (letter by letter).
function lexComparison() {
    var textInputN = document.getElementById('p2-n'),
        textInputC = document.getElementById('p2-c'),
        first = textInputN.value.split(/[ ,]+/),
        second = textInputC.value.split(/[ ,]+/),
        result;


    if (first.length > second.length) {
        result = 'First is bigger';
    }
    else if (second.length > first.length) {
        result = 'Second is bigger';
    } else {
        for (var i = 0; i < first.length; i++) {
            if (first[i] > second[i]) {
                result = 'First is bigger';
            }
            else if (first[i] < second[i]) {
                result = 'Second is bigger';
            } else {
                result = 'Equal'
            }
        }
    }
    animateSection(document.getElementById('p2-section'));
    document.getElementById('p2-result').innerHTML = result;

}

//Problem 3. Min/Max of sequence
//Write a script that finds the max and min number from a sequence of numbers.
function maxSequence() {
    var textInputN = document.getElementById('p3-n'),
        n = textInputN.value.split(/[ ,]+/),
        result = [],
        temp = [];

    for (var j = 0; j < n.length; j++) {
        n[j] = parseInt(n[j]);
    }

    for (var i = 0; i < n.length; i++) {
        if (temp.length === 0) {
            temp.push(n[i]);
        } else {
            if (n[i] === temp[0]) {
                temp.push(n[i])
            } else {
                if (result.length < temp.length) {
                    result = temp;
                }
                temp = [];
                temp.push(n[i]);
            }
        }
    }

    if (result.length < temp.length) {
        result = temp;
    }
    document.getElementById('problem3Table').appendChild(createTableRow([textInputN.value, result.join(',')]));
}

//Problem 4. Maximal increasing sequence
//Write a script that finds the maximal increasing sequence in an array.
function maxIncreasingSeq() {
    var textInputN = document.getElementById('p4-n'),
        n = textInputN.value.split(/[ ,]+/),
        result = [],
        temp = [];

    for (var j = 0; j < n.length; j++) {
        n[j] = parseInt(n[j]);
    }

    for (var i = 0; i < n.length; i++) {
        if (temp.length === 0) {
            temp.push(n[i]);
        } else {
            if (n[i] > temp[temp.length - 1]) {
                temp.push(n[i])
            } else {
                if (result.length < temp.length) {
                    result = temp;
                }
                temp = [];
                temp.push(n[i]);
            }
        }
    }

    if (result.length < temp.length) {
        result = temp;
    }
    document.getElementById('problem4Table').appendChild(createTableRow([textInputN.value, result.join(',')]));
}

//Problem 5. Selection sort
//Sorting an array means to arrange its elements in increasing order.
//Write a script to sort an array.
//Use the selection sort algorithm: Find the smallest element, move it at the first position,
//find the smallest from the rest, move it at the second position, etc.
//Hint: Use a second array
//validation of number input
function selectionSort() {
    var textInputN = document.getElementById('p5-n'),
        n = textInputN.value.split(/[ ,]+/),
        min = 0;

    for (var j = 0; j < n.length; j++) {
        n[j] = parseInt(n[j]);
    }

    animateSection(document.getElementById('p5-section'));
    for (var i = 0; i < n.length - 1; i++) {
        min = i;
        for (var k = i + 1; k < n.length; k++) {

            if (n[k] < n[min]) {
                min = k;
            }
        }
        if (min !== i) {
            var temp = n[i];
            n[i] = n[min];
            n[min] = temp;
        }
    }

    document.getElementById('p5-result').innerHTML = n.join(', ');
}

//Problem 6. Most frequent number
//Write a script that finds the most frequent number in an array.
function mostFreqNumber() {
    var textInputN = document.getElementById('p6-n'),
        n = textInputN.value.split(/[ ,]+/),
        result = [],
        value = 0,
        index;

    for (var i = 0; i < n.length; i++) {
        if (result.hasOwnProperty(n[i])) {
            result[n[i]]++;
        } else {
            result[n[i]] = 1;
        }
    }
    for (var prop in result) {
        if (result[prop] > value) {
            value = result[prop];
            index = prop;
        }
    }

    document.getElementById('problem6Table')
        .appendChild(createTableRow([textInputN.value, index + '(' + result[index] + ' times)']));
}

//Problem 7. Binary search
//Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.
function readNumber() {
    var textInputN = document.getElementById('p7-n'),
        textInputC = document.getElementById('p7-c'),
        key = parseInt(textInputC.value),
        n = textInputN.value.split(/[ ,]+/);

    for (var j = 0; j < n.length; j++) {
        n[j] = parseInt(n[j]);
    }
    n.sort(function (first, second) {
        return first - second
    });

    var result = binarySearch(n, key, 0, n.length - 1)
    animateSection(document.getElementById('p7-section'));
    document.getElementById('p7-result').innerHTML = 'Index = ' + result;
}

function binarySearch(arr, key, min, max) {
    if (max < min) {
        return 'key not found';
    } else {
        var mid = Math.floor((max - min) / 2) + min;
        if (arr[mid] > key) {
            return (arr, key, min, mid - 1);
        }
        else if (arr[mid] < key) {
            return (arr, key, mid + 1, max);
        } else {
            return mid;
        }
    }
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