/**
 * So Many Permutations!
 * https://www.codewars.com/kata/5254ca2719453dcc0b00027d
 * @param {*} string
 * @returns
 */
function permutations(string) {
    let resultSet = new Set();

    console.log(string);
    const arr = [...string];
    permutation(resultSet, arr, 0, arr.length - 1);

    return Array.from(resultSet);
}

function permutation(resultSet, arr, start, end) {
    if (start == end) {
        console.log(arr);
        resultSet.add(arr.join(''));
    } else {
        for (let i = start; i <= end; i++) {
            swap(arr, start, i);
            permutation(resultSet, arr, start + 1, end);
            swap(arr, start, i);
        }
    }
}

function swap(arr, i, j) {
    let tmp = arr[i];
    arr[i] = arr[j];
    arr[j] = tmp;
}

module.exports = {
    permutations,
};
