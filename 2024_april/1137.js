const cache = [0, 1, 1];

var tribonacci = function (n) {
    if (cache[n] === undefined) {
        cache[n] = tribonacci(n - 3) + tribonacci(n - 2) + tribonacci(n - 1);
    }
    return cache[n];
};