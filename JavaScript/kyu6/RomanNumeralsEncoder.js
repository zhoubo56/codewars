/**
 * Roman Numerals Encoder
 * https://www.codewars.com/kata/51b62bf6a9c58071c600001b
 * @param {*} number
 */
function solution(number) {
    var result = [];
    number = parseInt(number);
    if (number < 1 || number > 3999)
        return 'the number should between 1 and 3999 ';

    const symbols = ['I', 'V', 'X', 'L', 'C', 'D', 'M'];
    var index = 0;
    while (number > 0) {
        var tmp = '';
        var current = number % 10;
        if (current == 9) {
            tmp += symbols[index] + symbols[index + 2];
            current -= 9;
        }
        if (current >= 5) {
            tmp += symbols[index + 1];
            current -= 5;
        }
        if (current > 0) {
            if (current == 4) {
                tmp += symbols[index] + symbols[index + 1];
            } else {
                while (current > 0) {
                    tmp += symbols[index];
                    current--;
                }
            }
        }
        result.push(tmp);
        number = parseInt(number / 10);
        index += 2;
    }

    return result.reverse().join('');
}

module.exports = {
    solution,
};
