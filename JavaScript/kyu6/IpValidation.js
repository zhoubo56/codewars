/**
 * IP Validation
 * https://www.codewars.com/kata/515decfd9dcfc23bb6000006
 * @param {string} str guaranteed to be a single string
 * @return {boolean} is IPV4
 */
function isValidIP(str) {
    var strArr = str.split(".");
    if (strArr.length != 4) return false;
    for (const s of strArr) {
        if (isNaN(s)) return false;
        if (s.length > 3 || s.length == 0) return false;
        let n = parseInt(s);
        if (s.length == 1 && (n < 0 || n > 9)) return false;
        if (s.length == 2 && (n < 10 || n > 99)) return false;
        if (s.length == 3 && (n < 100 || n > 255)) return false;
    }

    return true;
}

function isValidIP_clever(str) {
    return (
        str.split(".").filter(function (v) {
            return v == Number(v).toString() && Number(v) < 256;
        }).length == 4
    );
}

module.exports = {
    isValidIP,
};
