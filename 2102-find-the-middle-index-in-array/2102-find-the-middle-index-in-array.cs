public class Solution {
    public int FindMiddleIndex(int[] nums) {
       int totalSum=0;
       int leftSum=0;

       foreach(var n in nums){
        totalSum+=n;
       }

       for(int i=0;i<nums.Length;i++){
        if(leftSum==totalSum-leftSum-nums[i]){
            return i;
        }
        leftSum+=nums[i];
       }
       return -1;
    }
}