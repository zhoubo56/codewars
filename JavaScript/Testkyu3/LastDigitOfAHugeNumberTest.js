const { lastDigit } = require('../kyu3/LastDigitOfAHugeNumber');
const { assert, config } = require('chai');
const _ = require('lodash');

config.truncateThreshold = 0;

describe('Example tests', function () {
    it('Fixed tests', function () {
        assert.strictEqual(lastDigit([]), 1);
        assert.strictEqual(lastDigit([0, 0]), 1); // 0 ^ 0
        assert.strictEqual(lastDigit([1, 2]), 1);
        assert.strictEqual(lastDigit([0, 0, 0]), 0); // 0^(0 ^ 0) = 0^1 = 0
        assert.strictEqual(lastDigit([3, 4, 5]), 1);
        assert.strictEqual(lastDigit([3, 4, 2]), 1);
        assert.strictEqual(lastDigit([4, 3, 6]), 4);
        assert.strictEqual(lastDigit([7, 6, 21]), 1);
        assert.strictEqual(lastDigit([12, 30, 21]), 6);
        assert.strictEqual(lastDigit([2, 2, 2, 0]), 4);
        assert.strictEqual(lastDigit([937640, 767456, 981242]), 0);
        assert.strictEqual(lastDigit([123232, 694022, 140249]), 6);
        assert.strictEqual(lastDigit([499942, 898102, 846073]), 6);
    });

    it('Random tests', function () {
        const r1 = _.random(1, 100);
        const r2 = _.random(1, 10);

        assert.strictEqual(lastDigit([r1]), r1 % 10);
        assert.strictEqual(lastDigit([r1, r2]), Math.pow(r1 % 10, r2) % 10);
    });
});
