var findRotateSteps = function(ring, key) {   
    const turnClockWise = (ind, n) => (ind + 1) % n;
    const turnAntiClockWise = (ind, n) => (ind === 0 ? n - 1 : ind - 1);

    const findSteps = (ind, keyInd, n, ring, key, dp) => {
        if (keyInd === key.length) return 0;
        if (dp[ind][keyInd] !== -1) return dp[ind][keyInd];

        let clockWiseSteps = 0;
        let antiClockWiseSteps = 0;
        let i = ind;
        while (ring.charAt(i) !== key.charAt(keyInd)) {
            i = turnClockWise(i, n);
            clockWiseSteps++;
        }

        clockWiseSteps++;

        if (keyInd + 1 < key.length)
            clockWiseSteps += findSteps(i, keyInd + 1, n, ring, key, dp);

        i = ind;
        while (ring.charAt(i) !== key.charAt(keyInd)) {
            i = turnAntiClockWise(i, n);
            antiClockWiseSteps++;
        }

        antiClockWiseSteps++;

        if (keyInd + 1 < key.length)
            antiClockWiseSteps += findSteps(i, keyInd + 1, n, ring, key, dp);

        dp[ind][keyInd] = Math.min(clockWiseSteps, antiClockWiseSteps);
        return dp[ind][keyInd];
    };

    const n = ring.length;
    const dp = Array.from({ length: n }, () => Array(key.length).fill(-1));
    return findSteps(0, 0, n, ring, key, dp);
};
