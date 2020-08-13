
/**
 * Simple missing sum
 * https://www.codewars.com/kata/5a941f3a4a6b34edf900006f
 * @param {Array} arr list integers
 * @return {integer} minumum number that is no a possible sum
 */
function solve(arr) {
    arr = arr.sort((a, b) => a - b);
    let sum = 0;
    for (const item of arr) {
        if (item > sum + 1) break;
        sum += item;
    }
    return sum + 1;
}


/**
 * desc sort arr and combinatorial calculate sum value
 * @param {*} arr 
 */
function solve_CS(arr) {
    arr = arr.sort((a, b) => a - b);
    let sumIndex = 1;
    while (arr.includes(sumIndex) || combinatorialSum(arr.filter((v, i, a) => v < sumIndex).reverse(), sumIndex) == true) {
        sumIndex++;
    }
    return sumIndex;
}

function combinatorialSum(arr, sum, index = 0, combination = []) {
    //console.log(arr, sum, index, combination);
    if (sum < 0) return false;

    if (sum === 0) {
        return true;
    }

    for (let i = index; i < arr.length; i++) {
        const item = arr[i];
        combination.push(item);
        if (combinatorialSum(arr, sum - item, i + 1, combination)) return true;
        combination.pop();
    }

    return false;
}

/**
 * list all combination and check if the sum value exist
 * @param {*} arr 
 */
function solve_C(arr) {
    let sumArr = [];
    for (let n = 1; n <= arr.length; n++) {
        var result = C(arr, n);
        sumArr.push(...result.map((v, i, a) => eval(v.join('+'))));
    }

    let sumIndex = 1;
    while (sumArr.includes(sumIndex)) {
        sumIndex++;
    }

    return sumIndex;
}

/**
 * n(number) the combination of arr(Array) 
 * @param {*} arr 
 * @param {*} n 
 * @param {*} index 
 * @param {*} tmp 
 * @param {*} result 
 */
function C(arr, n, index = 0, tmp = [], result = []) {
    if (index + n > arr.length) return;

    for (let i = index; i < arr.length; i++) {
        if (n === 1) {
            result.push([...tmp, arr[i]]);
            C(arr, n, i + 1, tmp, result);
            break;
        }

        C(arr, n - 1, i + 1, [...tmp, arr[i]], result);
    }
    return result;
}



module.exports = {
    solve
}