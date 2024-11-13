public class Solution {
    public int SubtractProductAndSum(int n) {
        int p=1;
        int sum=0;
        while(n>0){
            int r=n%10;
            p=r*p;
            sum+=r;
            n/=10;
        }
        return p-sum;
    }
}