const { permutations } = require('../kyu4/SoManyPermutations');
const chai = require('chai');
chai.config.truncateThreshold = 0;
const { deepEqual } = chai.assert;

function doTest(string, expected) {
    const actual = permutations(string);
    console.log(actual.sort());
    deepEqual(actual.sort(), expected.sort(), `for string "${string}"\n`);
}

describe('permutations', function () {
    it('sample tests', function () {
        doTest('a', ['a']);
        doTest('ab', ['ab', 'ba']);

        doTest('aabb', ['aabb', 'abab', 'abba', 'baab', 'baba', 'bbaa']);
    });
});
