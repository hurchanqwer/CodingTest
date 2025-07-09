using System;
using System.Collections.Generic;
public class Solution {
    public bool solution(string s) {
  
        //스택 활용
        Stack<bool> temp = new Stack<bool>();
         foreach (char c in s){
            if(c=='(')
                temp.Push(true);
            else
           {  
             if(temp.Count == 0) return false;
             temp.Pop();
           }
             
         }
        return temp.Count == 0? true:false;
        //알고리즘
        /*int count;
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
             return false;*/
    }
}