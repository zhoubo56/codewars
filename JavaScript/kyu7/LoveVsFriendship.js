
/**
 * Love vs friendship
 * https://www.codewars.com/kata/love-vs-friendship
 */
function wordsToMarks(string) {
    return string.split('').reduce((p, c) => p + c.charCodeAt() - 96, 0);
}

module.exports = {
    wordsToMarks
}