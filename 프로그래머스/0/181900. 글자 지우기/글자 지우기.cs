using System;
using System.Text;
public class Solution {
    public string solution(string my_string, int[] indices) {
        StringBuilder sb = new StringBuilder(my_string);
        Array.Sort(indices);
        Array.Reverse(indices);
        foreach(var i in indices){
            sb.Remove(i,1);
        }
        return sb.ToString();
    }
}