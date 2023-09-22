const { customChristmasTree } = require("../kyu6/CustomChristmasTree");
const { assert } = require("chai");

describe("CustomChristmasTreeTest", function () {
    it("Basic tests", function () {
        assert.strictEqual(
            customChristmasTree("*@o", 3),
            `  *
 @ o
* @ o
  |`
        );

        assert.strictEqual(
            customChristmasTree("*@o", 6),
            `     *
    @ o
   * @ o
  * @ o *
 @ o * @ o
* @ o * @ o
     |
     |`
        );

        assert.strictEqual(
            customChristmasTree("1234", 6),
            `     1
    2 3
   4 1 2
  3 4 1 2
 3 4 1 2 3
4 1 2 3 4 1
     |
     |`
        );

        assert.strictEqual(
            customChristmasTree("123456789", 3),
            `  1
 2 3
4 5 6
  |`
        );

        assert.strictEqual(
            customChristmasTree("(|@", 10),
            `         (
        | @
       ( | @
      ( | @ (
     | @ ( | @
    ( | @ ( | @
   ( | @ ( | @ (
  | @ ( | @ ( | @
 ( | @ ( | @ ( | @
( | @ ( | @ ( | @ (
         |
         |
         |`
        );
    });
});
