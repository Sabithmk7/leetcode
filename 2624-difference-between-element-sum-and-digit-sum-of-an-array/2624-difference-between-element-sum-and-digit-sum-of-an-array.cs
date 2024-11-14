using System.Linq;
public class Solution {
    public int DifferenceOfSum(int[] nums) {
        int sum1=nums.Sum();
        int sum2=0;
        for(int i=0;i<nums.Length;i++){
            while(nums[i]>0){
                int r=nums[i]%10;
                sum2+=r;
                nums[i]=nums[i]/10;
            }
        }
        return sum1-sum2;
    }
}