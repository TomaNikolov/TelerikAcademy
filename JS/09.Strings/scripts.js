//Problem 1. Reverse string
//Write a JavaScript function that reverses a string and returns it.
function reverseString() {
    var textInputN = document.getElementById('p1-n'),
        n = textInputN.value.split(''),
        result;


    result = n.reverse().join('');

    document.getElementById('problem1Table').appendChild(createTableRow([textInputN.value, result]));
}

//Problem 2. Correct brackets
//Write a JavaScript function to check if in a given expression the brackets are put correctly.
function correctBrackets() {
    var textInputN = document.getElementById('p2-n'),
        n = textInputN.value,
        leftBrackets = 0,
        rightBrackets = 0,
        result = true;

    for (var i = 0; i < n.length; i++) {
        if (n[i] === '(') {
            leftBrackets++;
        }
        if (n[i] === ')') {
            rightBrackets++;
        }
        if (leftBrackets < rightBrackets) {
            result = false;
            break;
        }

    }
    if (leftBrackets !== rightBrackets) {
        result = false;
    }
    document.getElementById('problem2Table')
        .appendChild(createTableRow([textInputN.value, result ? 'correct!' : 'incorrect!']));
}

//Problem 3. Sub-string in text
//Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
function occurrence() {
    var textInputT = document.getElementById('p3-t'),
        textInputW = document.getElementById('p3-w'),
        text = textInputT.value.toLowerCase(),
        word = textInputW.value,
        result;

    result = substringMatch(text, word);

    animateSection(document.getElementById('p3-section'));
    document.getElementById('p3-result').innerHTML = 'The result is: ' + result.length;
}

function substringMatch(text, searchWord) {
    var regex = new RegExp(searchWord, 'gi');
    return text.match(regex);
}

//Problem 4. Parse tags
//You are given a text. Write a function that changes the text in all regions:
function numberOfElement() {
    var i,
        textInputT = document.getElementById('p4-t'),
        text = textInputT.value,
        uperReg = /<upcase>(.+)<\/upcase>/i,
        lowReg = /<lowcase>(.+)<\/lowcase>/i,
        mixReg = /<mixcase>(.+)<\/mixcase>/i,
        result = text,
        curtentIndex = 0;

    for ( i = 0; i < text.length; i++) {

        if(text.substring(0, i).indexOf('<\/upcase>') >= 0){
            result = parceTag(result, uperReg, toUpper);
        }
        if(text.substring(0, i).indexOf('<\/lowcase>') >= 0){

            result = parceTag(result, lowReg, toLoler);
        }
        if(text.substring(0, i).indexOf('<\/mixcase>') >= 0){
            result = parceTag(result, mixReg, mixCase);
        }

    }

    animateSection(document.getElementById('p4-section'));
    document.getElementById('p4-result').innerHTML = result;
}

function parceTag(templ, reg, funk) {
    return templ.replace(reg, funk);
}
function toLoler(match, text) {
    return text.toLowerCase();
}

function toUpper(match, text) {
    return text.toUpperCase();
}
function mixCase(match, text) {
    var result = '',
        len = text.length;

    for (var i = 0; i < len; i++) {
        if (i % 2) {
            result += text[i].toUpperCase();
        } else {
            result += text[i].toLowerCase();
        }
    }
    return result;
}


//Problem 5. nbsp
//Write a function that replaces non breaking white-spaces in a text with &nbsp;
function replace() {
    var textInputN = document.getElementById('p5-n'),
        text = textInputN.value,
        wordToReplace = ' ',
        replaceWithWord = '&nbsp';

    text = replaceAll(text, wordToReplace, replaceWithWord)
    animateSection(document.getElementById('p5-section'));
    document.getElementById('p5-result').innerHTML = text;
}

function replaceAll(text, wordToReplace, replaceWithWord) {
    var regex = new RegExp(wordToReplace, 'gi');
    return text.replace(regex, replaceWithWord);
}

//Problem 6. Extract text from HTML
//Write a function that extracts the content of a html page given as text.
//e function should return anything that is in a tag, without the tags.
function extractTextFromHtml() {
    var textInputN = document.getElementById('p6-n'),
        text = textInputN.value,
        wordToReplace = '(<([^>]+)>)',
        replaceWithWord = '';

    text = replaceAll(text, wordToReplace, replaceWithWord)
    animateSection(document.getElementById('p6-section'));
    document.getElementById('p6-result').innerHTML = text;
}

//Problem 7. Parse URL
//Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from
//it the [protocol], [server] and [resource] elements.
//Return the elements in a JSON object.
function parceUrl() {
    var textInputN = document.getElementById('p7-n'),
        text = textInputN.value,
        result,
        protocol,
        urlArr,
        server,
        resource;

    protocol = text.substr(0, text.indexOf('://'))
    urlArr = text.substring(text.indexOf('://') + 3).split('/')
    server = urlArr[0];
    urlArr.splice(0, 1);
    resource = urlArr.join('/');

    result = {
        protocol: protocol,
        server: server,
        resource: resource
    };

    animateSection(document.getElementById('p7-section'));
    document.getElementById('p7-result').innerHTML = JSON.stringify(result);
}
//Problem 8. Replace tags
//Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with
//corresponding tags [URL=…]…/URL].
function replaceTag() {
    var textInputN = document.getElementById('p8-n'),
        text = textInputN.value,

        text = replaceAll(text, '<a href="', '[URL=');
    text = replaceAll(text, '">', ']');
    text = replaceAll(text, '</a>', '[/URL]');

    animateSection(document.getElementById('p8-section'));
    document.getElementById('p8-result').innerHTML = text;
}

//Problem 9. Extract e-mails
//Write a function for extracting all email addresses from given text.
//All sub-strings that match the format @… should be recognized as emails.
//Return the emails as array of strings.
function extractMails() {
    var textInputT = document.getElementById('p9-n'),
        text = textInputT.value.toLowerCase(),
        word = /[A-Z0-9._%+-]+@[A-Z0-9.-]+.[A-Z]{2,4}/igm,
        result;

    result = text.match(word);

    animateSection(document.getElementById('p9-section'));
    document.getElementById('p9-result').innerHTML = result.join(', ');
}

//Problem 10. Find palindromes
//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
function findPalindromes() {
    var textInputN = document.getElementById('p10-n'),
        text = textInputN.value,
        palindromes,
        result = false;
    palindromes = text.split('').reverse().join('');
    if (text === palindromes) {
        result = true;
    }

    document.getElementById('problem10Table').appendChild(createTableRow([textInputN.value, result]));
}

//Problem 11. String format
//Write a function that formats a string using placeholders.
//The function should work with up to 30 placeholders and all types.
function strForm() {
    var textInputT = document.getElementById('p11-n'),
        text = textInputT.value.split(','),
        result;

    result = stringFormat('Hello {0}!', 'Peter');
    animateSection(document.getElementById('p11-section'));
    document.getElementById('p11-result').innerHTML = result;
}

function stringFormat() {
    var args,
        str,
        inPlaceHolders,
        result,
        i;
    inPlaceHolders = false;
    args = Array.prototype.slice.call(arguments);
    str = args [0];
    args.splice(0, 1);
    result = '';


    for (i = 0; i < str.length; i++) {
        if (str[i] === '{') {
            inPlaceHolders = true;
            continue;
        }
        if (str[i] === '}') {
            inPlaceHolders = false;
            continue;
        }
        if (inPlaceHolders) {
            result += args[parseInt(str[i])];
        } else {
            result += str[i];
        }

    }
    return result;

}
//Problem 12. Generate list
//Write a function that creates a HTML <ul> using a template for every HTML <li>.
//The source of the list should be an array of elements.
//Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.

function generateList() {
    var people = [
            {name: 'Pesho', age: 19},
            {name: 'Gosho', age: 45},
            {name: 'Stamat', age: 23},
            {name: 'Mitko', age: 65}
        ],
        ul = document.createElement('ul'),
        result = document.getElementById('result'),
        template = document.getElementById('list-item').innerHTML;
    for (var index in people) {
        var li = document.createElement('li');
        li.innerHTML = generateLi(template, people[index]);
        ul.appendChild(li);
    }
    result.appendChild(ul);
}

function generateLi(templ, obj) {
    return templ.replace(/\-{(\w+)\}-/g, function (match, prop) {
        return obj[prop] || '';
    });
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



