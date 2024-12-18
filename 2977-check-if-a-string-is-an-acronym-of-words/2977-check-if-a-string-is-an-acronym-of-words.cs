public class Solution {
    public bool IsAcronym(IList<string> words, string s) {
        string res="";
        foreach(var i in words){
            res+=i[0];
        }
        if(res==s){
            return true;
        }else{
            return false;
        }
    }
}