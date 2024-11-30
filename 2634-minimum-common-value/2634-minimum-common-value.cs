public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        int res=int.MaxValue;
        HashSet<int> set = new HashSet<int>(nums1);
        foreach(int num in nums2){
            if(set.Contains(num)){
                res=Math.Min(res,num);
            }
        }
       if(res==int.MaxValue){
        return -1;
       }else{
        return res;
       }
    }
}