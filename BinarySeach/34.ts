function searchRange(nums: number[], target: number): number[] {
    let first = findFirst(nums, target);
    let second = findLast(nums, target);

    return [first, second];
};

function findFirst(nums: number[], target: number): number {
    let low = 0;
    let high = nums.length - 1;
    let middle;
    let first = -1;

    while (low <= high) {
        middle = Math.floor(low + (high - low) / 2);

        if (nums[middle] == target) {
            first = middle;
            high = middle - 1;
        }
        else if (nums[middle] < target) low = middle + 1;
        else high = middle - 1;
    }
    
    return first;
}

function findLast(nums: number[], target: number): number {
    let low = 0;
    let high = nums.length - 1;
    let middle;
    let last = -1;

    while (low <= high) {
        middle = Math.floor(low + (high - low) / 2);

        if (nums[middle] == target) {
            last = middle;
            low = middle + 1;
        }
        else if (nums[middle] < target) low = middle + 1;
        else high = middle - 1;
    }
    
    return last;
}