public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        List<int> l=new List<int>();
        Array.Sort(nums1);
        Array.Sort(nums2);
        int p1 = 0, p2 = 0;
        while(p1 < nums1.Length && p2 < nums2.Length){
            if(nums1[p1]==nums2[p2]){
                l.Add(nums1[p1]);
                p1++;
                p2++;
            }else if(nums1[p1]<nums2[p2]){
                p1++;
            }else{
                p2++;
            }
            
        }
        return l.ToArray();
    }
}