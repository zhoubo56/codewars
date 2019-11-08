const { wordsToMarks } = require('../kyu7/LoveVsFriendship');
const { assert } = require('chai');

describe("Basic tests", () => {
    it('sample test', () => {
        assert.strictEqual(wordsToMarks("attitude"), 100);
        assert.strictEqual(wordsToMarks("friends"), 75);
        assert.strictEqual(wordsToMarks("family"), 66);
        assert.strictEqual(wordsToMarks("selfness"), 99);
        assert.strictEqual(wordsToMarks("knowledge"), 96);
    })
});