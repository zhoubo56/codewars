
/**
 * Consecutive Ducks
 * https://www.codewars.com/kata/consecutive-ducks
 */
function consecutiveDucks(num) {
    var index = 2;
    while (index <= num) {
        if ((num - index * (index - 1) / 2) % index == 0) return true;
        index++;
    }
    return false;
}

module.exports = {
    consecutiveDucks
}