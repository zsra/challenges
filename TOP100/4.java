class Solution {
    public double findMedianSortedArrays(int[] nums1, int[] nums2) {
            
        int nums1_index = 0;
        int nums2_index = 0;
        int newSize = nums1.length + nums2.length;
        int middleIndex = newSize % 2 == 0 ? newSize / 2 : (newSize - 1) / 2;
        int middle = 0;
        
        while(newSize % 2 == 0 && nums1_index + nums2_index < middleIndex 
            || newSize % 2 != 0 && nums1_index + nums2_index <= middleIndex) {
            
            if (nums1_index == nums1.length || (nums2_index != nums2.length && nums1[nums1_index] >= nums2[nums2_index])) {
                middle = nums2[nums2_index];
                nums2_index++;
            }
            else if (nums2_index == nums2.length || ( nums1_index != nums1.length && nums1[nums1_index] <= nums2[nums2_index])) {
                middle = nums1[nums1_index];
                nums1_index++;
            }
        }
        
        if (newSize % 2 != 0) {
            return middle;
        }
        else {
            
            if(nums1_index == nums1.length) {
                return (middle + nums2[nums2_index]) / (double)2;
            }
            
            if (nums2_index == nums2.length) {
                return (middle + nums1[nums1_index]) / (double)2;
            }
            
            if (nums1[nums1_index] >= nums2[nums2_index]) {
                return (middle + nums2[nums2_index]) / (double)2;
            }
            else {
                return (middle + nums1[nums1_index]) / (double)2;
            }
        }	
    }
}