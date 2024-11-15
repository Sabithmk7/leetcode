public class Solution {
    public int SumOfTheDigitsOfHarshadNumber(int x) {
        int s=0;
        int p=x;
        while(p>0){
            int r=p%10;
            s=s+r;
            p=p/10;
        }
        if(x%s==0){
            return s;
        }else{
            return -1;
        }
    }
}