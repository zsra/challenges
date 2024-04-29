var minOperations = function(nums, k) {
    
    let xorValue = xorOfArrayElements(nums);

    if (xorValue == k) {
        return 0;
    }

    let xorValueBin = xorValue.toString(2);
    let kBin = k.toString(2);

    return countXORDifferingBits(xorValueBin, kBin);
};

function xorOfArrayElements(nums) {
    let result = 0;
    for (let i = 0; i < nums.length; i++) {
        result ^= nums[i];
    }
    return result;
}

function countXORDifferingBits(str1, str2) {
    let count = 0;
    const maxLength = Math.max(str1.length, str2.length);
    const minLength = Math.min(str1.length, str2.length);
    
    for (let i = 0; i < minLength; i++) {
        if (str1[str1.length - 1 - i] !== str2[str2.length - 1 - i]) {
            count++;
        }
    }

    if (str1.length !== str2.length) {
        const longerStr = str1.length > str2.length ? str1 : str2;
        for (let i = minLength; i < maxLength; i++) {
            if (longerStr[longerStr.length - 1 - i] === '1') {
                count++;
            }
        }
    }

    return count;
}
