public class Solution {
    public int DominantIndex(int[] nums) {
        int max=nums.Max();
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=max && nums[i]*2 >max ) return -1;
        }
        return Array.IndexOf(nums,max);
    }
}