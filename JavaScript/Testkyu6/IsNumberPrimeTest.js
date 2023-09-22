const { isPrime } = require("../kyu6/IsNumberPrime");
const { assert } = require("chai");

describe("IsNumberPrimeTest", () => {
    it("Basic tests", function () {
        // assert.strictEqual(isPrime(0), false, "0 is not prime");
        // assert.strictEqual(isPrime(1), false, "1 is not prime");
        // assert.strictEqual(isPrime(2), true, "2 is prime");
        // assert.strictEqual(isPrime(73), true, "73 is prime");
        // assert.strictEqual(isPrime(75), false, "75 is not prime");
        // assert.strictEqual(isPrime(-1), false, "-1 is not prime");

        // assert.strictEqual(isPrime(5), true, "5 is prime");
        // assert.strictEqual(isPrime(6), false, "6 is not prime");
        assert.strictEqual(isPrime(88190881), false, "88190881 is not prime");
    });
});
