const startCharASCII = 97;
const letterCount = 26;

/**
 * Reversing a Process
 * https://www.codewars.com/kata/reversing-a-process
 */
function decode(r) {
    var num = parseInt(r);
    var letters = [];
    var codes = [];
    for (var i = 0; i < letterCount; i++) {
        letters[i] = String.fromCharCode(startCharASCII + i);
        codes[i] = String.fromCharCode(
            ((i * num) % letterCount) + startCharASCII
        );
    }
    if (Array.from(new Set(codes)).length != letterCount)
        return "Impossible to decode";
    return r
        .split(num)[1]
        .split("")
        .map((v, i, a) => letters[codes.indexOf(v)])
        .join("");
}

module.exports = {
    decode,
};
