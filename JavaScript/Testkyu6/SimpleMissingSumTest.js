const { solve } = require("../kyu6/SimpleMissingSum");
const { assert } = require("chai");

describe("SimpleMissingSumTest", function () {
    it("Basic tests", function () {
        assert.equal(solve([1, 2, 8, 7]), 4);
        assert.equal(solve([4, 2, 12, 3, 1]), 11);
        assert.equal(solve([4, 2, 8, 3, 1]), 19);
        assert.equal(solve([4, 2, 12, 3]), 1);

        //failed in solve_C, error: Maximum call stack size exceeded
        assert.equal(
            solve([
                1, 2, 4, 21, 28, 29, 41, 43, 53, 60, 63, 67, 69, 75, 96, 105,
                113, 123, 127, 135, 137, 142, 154, 159, 163, 165, 172, 174, 186,
                202, 204, 213, 223, 226, 229, 233, 236, 237, 238, 239, 242, 247,
                268, 273, 276, 289,
            ]),
            8
        );

        //timeout in solve_CS
        assert.equal(
            solve([
                1, 2, 4, 7, 8, 9, 16, 31, 38, 74, 80, 82, 85, 93, 97, 98, 107,
                111, 126, 137, 159, 183, 218, 220, 226, 228, 233, 240, 269, 278,
                285, 300,
            ]),
            4046
        );
    });
});
