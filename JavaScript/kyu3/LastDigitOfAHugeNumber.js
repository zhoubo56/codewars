/**
 * Last digit of a huge number
 * @param {Array<number|string|BigInt>} arr - Array of numbers representing x1, x2, ..., xn
 * @returns {number} The last digit of x1 ^ (x2 ^ (x3 ^ (... ^ xn)))
 */
function lastDigit(arr) {
    if (arr.length === 0) return 1;

    let exponent = 1n;
    for (let i = arr.length - 1; i >= 0; i--) {
        if (exponent >= 4n) {
            exponent = (exponent % 4n) + 4n;
        }
        exponent = BigInt(arr[i]) ** exponent;
    }

    return Number(exponent % 10n);
}

/**
 * 最开始自己的思路来源是LastDigitOfALargeNumber.js，但是只算了每次的末尾，最终结果不对
 * @param {*} arr
 * @returns
 */
function lastDigitBefore(arr) {
    console.log('arr:', arr);
    if (arr.length === 0) return 1;
    if (arr.length === 1) return arr[0];

    const cycles = {
        0: [0, 0, 0, 0],
        1: [1, 1, 1, 1],
        2: [2, 4, 8, 6],
        3: [3, 9, 7, 1],
        4: [4, 6, 4, 6],
        5: [5, 5, 5, 5],
        6: [6, 6, 6, 6],
        7: [7, 9, 3, 1],
        8: [8, 4, 2, 6],
        9: [9, 1, 9, 1],
    };

    let exponent = 1n;
    for (let i = arr.length - 1; i >= 0; i--) {
        let base = arr[i];

        if (exponent === 0) {
            exponent = 1;
            console.log(i, base, exponent);
        } else {
            let expMod4 = exponent % 4;
            let cycleIndex = expMod4 === 0 ? 3 : expMod4 - 1;
            exponent = cycles[base][cycleIndex];
        }
    }

    return Number(exponent % 10n);
}

module.exports = {
    lastDigit,
};
