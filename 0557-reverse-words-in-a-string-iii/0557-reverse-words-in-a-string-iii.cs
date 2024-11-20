public class Solution {
    public string ReverseWords(string s) {
        var arr=s.Split(" ");
        List<string> str=new List<string>();
        foreach(var i in arr){
             
             string reverseString = string.Empty;
            for (int j = i.Length - 1; j >= 0; j--)
            {
                reverseString += i[j];
            }
            str.Add(reverseString);
             Console.WriteLine(reverseString);
        }
       return  string.Join(" ", str); 
    }
}