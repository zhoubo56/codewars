const {
    firstNonRepeatingLetter,
} = require('../kyu5/FirstNonRepeatingCharacter');

describe('Testing firstNonRepeatingLetter', () => {
    const { assert } = require('chai');

    const doTest = (s, expected) =>
        it(`'${s}'`, () =>
            assert.strictEqual(firstNonRepeatingLetter(s), expected));

    describe('Fixed tests', () => {
        describe('Basic tests', () => {
            doTest('a', 'a');
            doTest('stress', 't');
            doTest('moonmen', 'e');
        });
    });
});
