using System;
using System.Collections.Generic;
public class Solution {
    public bool solution(string s) {
  
        bool answer = true;
        int count;
        count=0;
        foreach (char c in s){
            if(count<0) return false;
            
            if(c=='(')
                count++;
            else
                 count--;
        }
        if (count==0)
        return true;
        else
             return false;
    }
}