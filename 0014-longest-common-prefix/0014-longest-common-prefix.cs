public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string res=strs[0];
      for(int i=1;i<strs.Length;i++){
        while(strs[i].IndexOf(res)!=0){
            res=res.Substring(0,res.Length-1);
            if(res.Length==0) return "";
        }
      }
      return res;
    }
}