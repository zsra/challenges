function countNegatives(grid: number[][]): number {
    const N = grid.length;
    const M = grid[0].length;

    let total = 0;
    
    const binarySearch = (arr: string | any[]) => {
        let left = 0;
        let right = arr.length - 1;
        let mid;
        
        while (left < right) {
            mid = Math.floor((left + right) / 2);
            
            if (arr[mid] >= 0) {
                left = mid + 1;
            } else {
                right = mid;
            }
        }
        
        return arr[left] < 0 ? M - left : 0;
    };
    
    for (let i = 0; i < grid.length; i++) {
	    if (grid[i][0] < 0) {
            total += (N - i) * M;
            break;
        } else {
            total += binarySearch(grid[i]);
        }
    }
    
    return total;
};