/* Task description */
/*
 Write a function a function that finds all the prime numbers in a range
 1) it should return the prime numbers in an array
 2) it must throw an Error if any on the range params is not convertible to `string`
 3) it must throw an Error if any of the range params is missing
 */
function solve() {

    return function solve(start, end) {
        var prime = [];

        if (start === undefined || end === undefined) {
            throw Error('Missing parameters ');
        }
        if (isNaN(start) || isNaN(end)) {
            throw  Error('Range params are not convertible to number');
        }

        for (var currentNumber = start; currentNumber <= end; currentNumber++) {

            var isPrime = true,
                maxDivisor = Math.sqrt(currentNumber);

            if (currentNumber < 2) {
                continue;
            }
            for (var divisor = 2; divisor <= maxDivisor; divisor++) {

                if (!(currentNumber % divisor)) {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime) {
                prime.push(currentNumber);
            }
        }

        return prime;
    }
}

module.exports = solve;