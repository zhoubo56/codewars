const { solution } = require('../kyu5/MeanSquareError');
const { assert } = require('chai');

describe('solution', function () {
    it('Sample tests', function () {
        tester([1, 2, 3], [4, 5, 6], 9);
        tester([10, 20, 10, 2], [10, 25, 5, -2], 16.5);
        tester([0, -1], [-1, 0], 1);
    });

    function tester(arr1, arr2, expected) {
        const TOLERANCE = 1e-9;
        const err_msg = `Failed for inputs:\n- arr1: ${JSON.stringify(
            arr1
        )}\n- arr2: ${JSON.stringify(arr2)}\n`;
        assert.approximately(
            solution(arr1, arr2),
            expected,
            TOLERANCE,
            err_msg
        );
    }
});
