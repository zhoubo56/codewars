/**
 * Stop gninnipS My sdroW!
 * https://www.codewars.com/kata/5264d2b162488dc400000001/
 * @param {string} s
 * @return {string} result
 */
function spinWords(s) {
    return s
        .split(" ")
        .map((v, i, a) => (v.length >= 5 ? v.split("").reverse().join("") : v))
        .join(" ");
}

module.exports = {
    spinWords,
};
