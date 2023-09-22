const { decode } = require("../kyu6/ReversingProcess");
const { assert } = require("chai");

describe("ReversingProcessTest", function () {
    function testing_decode(r, expected) {
        let actual = decode(r);
        assert.strictEqual(actual, expected);
    }

    it("Basic tests", function () {
        testing_decode(
            "1273409kuqhkoynvvknsdwljantzkpnmfgf",
            "uogbucwnddunktsjfanzlurnyxmx"
        );
        testing_decode(
            "1544749cdcizljymhdmvvypyjamowl",
            "mfmwhbpoudfujjozopaugcb"
        );
        testing_decode(
            "105860ymmgegeeiwaigsqkcaeguicc",
            "Impossible to decode"
        );
        testing_decode(
            "1122305vvkhrrcsyfkvejxjfvafzwpsdqgp",
            "rrsxppowmjsrclfljrajtybwviqb"
        );
    });
});
