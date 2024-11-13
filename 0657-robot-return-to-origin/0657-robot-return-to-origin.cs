public class Solution {
    public bool JudgeCircle(string moves) {
        int x=0;
        int y=0;
        foreach(var m in moves){
            if(m=='U'){
                x++;
            }else if(m=='D'){
                x--;
            }else if(m=='L'){
                y++;
            }else{
                y--;
            }
        }
        if(x==0 && y==0){
            return true;
        }
        return false;
    }
}