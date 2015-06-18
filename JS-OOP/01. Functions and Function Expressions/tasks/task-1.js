/* Task Description */
/* 
 Write a function that sums an array of numbers:
 numbers must be always of type Number
 returns `null` if the array is empty
 throws Error if the parameter is not passed (undefined)
 throws if any of the elements is not convertible to Number

 */
function solve() {


  return  function sum(arr) {

        if (arr === undefined) {
            throw Error('Array is undefined');
        }
        if (!arr.length) {
            return null;
        }
        if (!arr.every(function (item) {
                return !isNaN(item);
            })) {
            throw Error('Some of the element of the array is not a number');
        }

        arr = arr.map(Number);
        return arr.reduce(function (previus, current) {
            return previus + current;
        });

    }
}
module.exports = sum;

