public class Solution {
    public string TruncateSentence(string s, int k) {
       var arr=s.Split(" "); 
       List<String> res=new List<String>();
       for(int i=0;i<k;i++){
        res.Add(arr[i]);
       }
       return String.Join(" ",res);
    }
}