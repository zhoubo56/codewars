var startCharASCII = 96;
var letterCount = 26;

/**
 * Alphabetical Addition
 * https://www.codewars.com/kata/alphabetical-addition
 */
function addLetters(...letters) {
    var letterASCII =
        letters.reduce((p, c, i) => {
            return p + c.charCodeAt() - startCharASCII;
        }, 0) % letterCount;
    if (letterASCII == 0) letterASCII = letterCount;
    return String.fromCharCode(letterASCII + startCharASCII);
}

module.exports = {
    addLetters,
};
