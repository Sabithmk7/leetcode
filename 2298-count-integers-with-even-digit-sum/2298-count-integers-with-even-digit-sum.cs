public class Solution {
    public int CountEven(int num) {
        int count=0;
        for(int i=1;i<=num;i++){
            int s=0;
            int c=i;
            while(c>0){
                int r=c%10;
                s=s+r;
                c=c/10;
            }
            if(s%2==0){
                count++;
            }
        }
        return count;
    }
}