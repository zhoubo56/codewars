const {
    recoverSecret,
} = require('../kyu4/RecoverSecretStringFromRandomTriplets');
const { assert } = require('chai');

describe('Tests', () => {
    it('test', () => {
        secret1 = 'whatisup';
        triplets1 = [
            ['t', 'u', 'p'],
            ['w', 'h', 'i'],
            ['t', 's', 'u'],
            ['a', 't', 's'],
            ['h', 'a', 'p'],
            ['t', 'i', 's'],
            ['w', 'h', 's'],
        ];

        assert.strictEqual(recoverSecret(triplets1), secret1, 'Unexpected result');
    });
});
