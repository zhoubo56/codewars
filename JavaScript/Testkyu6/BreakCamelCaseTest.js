const { solution } = require('../kyu6/BreakCamelCase');
const { assert } = require('chai');

describe('Sample Tests', () => {
    it('Should pass sample tests', () => {
        assert.strictEqual(
            solution('camelCasing'),
            'camel Casing',
            'Unexpected result'
        );
        assert.strictEqual(
            solution('camelCasingTest'),
            'camel Casing Test',
            'Unexpected result'
        );
    });
});
