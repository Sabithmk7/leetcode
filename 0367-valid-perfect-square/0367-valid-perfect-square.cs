public class Solution {
    public bool IsPerfectSquare(int num) {
        if(num==1) return true;
        long low=1;
        long high=num;
        while(low<=high){
            long mid=low+(high-low)/2;
            long square=mid*mid;
            if(square==num)
                return true;
            else if(square<num){
                low=mid+1;
            }else{
                high=mid-1;
            }
        }
        return false;
    }
}