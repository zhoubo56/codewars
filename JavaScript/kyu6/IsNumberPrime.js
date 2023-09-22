/**
 * Is a number prime?
 * https://www.codewars.com/kata/5262119038c0985a5b00029f
 * @param {*} num
 */
function isPrime(num) {
    if (!Number.isInteger(num)) return false;
    num = parseInt(num);

    if (num <= 1) return false;
    if (num === 2 || num === 3 || num === 5) return true;
    if (num % 2 === 0 || num % 3 === 0 || num % 5 === 0) return false;

    for (let i = 5; i <= Math.sqrt(num); i = i + 2) {
        if (num % i === 0) return false;
    }

    return true;
}

module.exports = {
    isPrime,
};
