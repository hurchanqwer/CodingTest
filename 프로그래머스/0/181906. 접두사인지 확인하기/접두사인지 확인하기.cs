using System;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        if(is_prefix.Length > my_string.Length) return 0;
        string temp = my_string.Substring(0, is_prefix.Length);
        return temp == is_prefix ? 1 : 0;
    }
}