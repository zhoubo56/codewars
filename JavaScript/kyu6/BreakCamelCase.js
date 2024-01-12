/**
 * Break camelCase
 * https://www.codewars.com/kata/5208f99aee097e6552000148
 * @param {*} str
 * @returns
 */
function solution(str) {
    return str
        .split('')
        .map((i) => (i.toUpperCase() == i ? ' ' : '') + i)
        .join('');
}

function bestSolution(str) {
    return str.replace(/([A-Z])/g, ' $1');
}

module.exports = {
    solution,
};
