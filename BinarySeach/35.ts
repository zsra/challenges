function searchInsert(nums: number[], target: number): number {
    let low = 0;
    let high = nums.length - 1;
    let middle;

    if (target > nums[high]) {
        return high + 1;
    }

    while (low <= high) {
        middle = Math.floor((low + high) / 2);

        if (nums[middle] == target) return middle;
        else if (nums[middle] < target) low = middle + 1;
        else high = middle - 1;
    }
    
    return low;
}