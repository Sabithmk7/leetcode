public class Solution {
    public void MoveZeroes(int[] nums) {
        int p=0;
        for(int i=0;i<nums.Length;i++){
          if(nums[i]!=0){
            nums[p]=nums[i];
            p++;
          }
        }
        for(int j=p;j<nums.Length;j++){
            nums[j]=0;
        }
    }
}