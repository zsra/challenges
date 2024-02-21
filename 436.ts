function findRightInterval(intervals: number[][]): number[] {
    let result: number[] = [];
    let n = intervals.length;
    let startIntervals: number[] = [];
    let startIndexes: number[] = [];

    for (let i = 0; i < n; i++) {
        startIntervals.push(intervals[i][0]);
        startIndexes[intervals[i][0]] = i;
        result[i] = -1;
    }

    startIntervals.sort((a, b) => a - b);

    for (let i = 0; i < n; i++) {
        let left = 0;
        let right = n - 1;

        let target = intervals[i][1];
        let currentIntervalStartIndex = startIndexes[intervals[i][0]];

        while (left <= right) {
            let mid = Math.floor((left + right) / 2);

            if (startIntervals[mid] >= target) {
                result[currentIntervalStartIndex] = startIndexes[startIntervals[mid]];
                right = mid - 1;
            } else {
                left = mid + 1;
            }
        }
    }

    return result;
};