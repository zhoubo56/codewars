/**
 * Last digit of a large number
 * https://www.codewars.com/kata/5511b2f550906349a70004e1/train/javascript
 * @param {BigInt} a
 * @param {BigInt} b
 * @returns {BigInt}
 */
function lastDigit(a, b) {
    // Convert to BigInt type to ensure compatibility
    a = BigInt(a);
    b = BigInt(b);
    
    // Handle special cases
    if (b === 0n) return 1n; // Any number to the power of 0 is 1
    if (a === 0n) return 0n; // 0 to any positive power is 0

    // Get the last digit of a (BigInt version)
    const lastDigitA = a % 10n;

    // Define cycle patterns for each possible last digit
    const cycles = {
        0n: [0n],
        1n: [1n],          
        2n: [2n, 4n, 8n, 6n],
        3n: [3n, 9n, 7n, 1n],
        4n: [4n, 6n],
        5n: [5n],
        6n: [6n],
        7n: [7n, 9n, 3n, 1n],
        8n: [8n, 4n, 2n, 6n],
        9n: [9n, 1n]
    };

    const cycle = cycles[lastDigitA];
    const cycleLength = BigInt(cycle.length);

    // For cycles of length 1, return the value directly
    if (cycleLength === 1n) {
        return cycle[0];
    }
    
    // Calculate the effective exponent using modulo operation
    // const effectiveExponent = (b - 1n) % cycleLength;
    const bMod4 = b % cycleLength;
    const effectiveExponent = bMod4 == 0n ? cycleLength - 1n : bMod4 - 1n;

    // Return the result
    return cycle[Number(effectiveExponent)];
}

module.exports = {
    lastDigit,
};