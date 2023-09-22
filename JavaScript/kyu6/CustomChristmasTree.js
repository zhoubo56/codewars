const treeUnit = 3;
/**
 * Custom Christmas Tree
 * https://www.codewars.com/kata/5a405ba4e1ce0e1d7800012e
 * @param {*} chars the specified characters
 * @param {*} n the specified height. A positive integer greater than 2
 * @return {string} the tree
 */
function customChristmasTree(chars, n) {
    let strArray = [];
    let charIndex = 0;
    for (let i = 0; i < n; i++) {
        let tmp = new Array(n - i).join(" ");
        for (let j = i; j >= 0; j--) {
            tmp += chars[charIndex++ % chars.length] + " ";
        }
        strArray.push(tmp.substring(0, tmp.length - 1));
    }
    let index = n;
    while (index >= 3) {
        strArray.push(new Array(n).join(" ") + "|");
        index -= 3;
    }
    return strArray.join("\n");
}

module.exports = {
    customChristmasTree,
};
