var longestIdealString = function (s, k) {
    let dp = new Array(26).fill(0);
    for (let i = 0; i < s.length; i++) {
        let charCode = s.charCodeAt(i) - 'a'.charCodeAt(0);
        
        let start = Math.max(0, charCode - k);
        let end = Math.min(25, charCode + k);
        
        dp[charCode] = Math.max(...dp.slice(start, end + 1)) + 1;
    }

    return Math.max(...dp);
}

