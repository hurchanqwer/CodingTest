using System;
using System.Linq;
public class Solution {
    public int solution(int[] num_list) {
     
        if(num_list.Length >10)
            return num_list.Sum();
        else
            return  num_list.Aggregate((a,b)=> a*b);
        
       
    }
}