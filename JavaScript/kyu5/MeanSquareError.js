
/**
 * Mean Square Error
 * https://www.codewars.com/kata/51edd51599a189fe7f000015/train/javascript
 * @param {*} firstArray 
 * @param {*} secondArray 
 * @returns the average of those squared absolute value difference between each member pair.
 */
function solution (firstArray, secondArray) {
    let sum = 0;
    for (let i = 0; i < firstArray.length; i++) {
        sum += (firstArray[i] - secondArray[i]) ** 2
    }
    return sum / firstArray.length
}

module.exports = {
    solution,
}