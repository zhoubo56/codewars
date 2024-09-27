/**
 * RGB To Hex Conversion
 * https://www.codewars.com/kata/513e08acc600c94f01000001
 * @param {*} r
 * @param {*} g
 * @param {*} b
 * @returns
 */
function rgb(r, g, b) {
    return int2Hex(r) + int2Hex(g) + int2Hex(b);
}

const hexCode = '0123456789ABCDEF';

function int2Hex(i) {
    let hex = '';
    if (i < 1) return '00';
    if (i > 255) i = 255;
    hex += hexCode[i % 16];
    i = parseInt(i / 16);
    hex += i > 0 ? hexCode[i % 16] : '0';
    return hex.split('').reverse().join('');
}

module.exports = {
    rgb,
};
