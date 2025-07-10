/**
 * First non-repeating character
 * https://www.codewars.com/kata/52bc74d4ac05d0945d00054e/train/javascript
 * @param {*} s
 */
function firstNonRepeatingLetter(s) {
    let lowerS = s.toLowerCase();
    for (let i = 0; i < s.length; i++) {
        if (lowerS.indexOf(lowerS[i]) === lowerS.lastIndexOf(lowerS[i])) {
            return s[i];
        }
    }
    return '';
}

module.exports = {
    firstNonRepeatingLetter,
};
