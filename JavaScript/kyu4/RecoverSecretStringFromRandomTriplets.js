/**
 * Recover a secret string from random triplets
 * https://www.codewars.com/kata/53f40dff5f9d31b813000774
 * @param {*} triplets
 */
function recoverSecret(triplets) {
    let secret = [];
    triplets.map((arr) =>
        arr.map((v) => {
            if (!secret.includes(v)) secret.push(v);
        })
    );

    for (let i = 0; i < secret.length; i++) {
        const current = secret[i];
        for (let j = i + 1; j < secret.length; j++) {
            const next = secret[j];
            if (!isFront(current, next, triplets)) {
                let tmp = secret[i];
                secret[i] = secret[j];
                secret[j] = tmp;
            }
        }
        if (current != secret[i]) i--;
    }
    return secret.join('');
}

function isFront(current, next, triplets) {
    for (let i = 0; i < triplets.length; i++) {
        const arr = triplets[i];
        const ci = arr.indexOf(current);
        const ni = arr.indexOf(next);
        if (ci > -1 && ni > -1) {
            return ci < ni;
        }
    }
    return true;
}

module.exports = {
    recoverSecret,
};
