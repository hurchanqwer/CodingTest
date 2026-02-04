using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr) {
        int s=-1,e=-1;
        for(int i =0; i< arr.Length; i++)
            if(arr[i] == 2) {s= i; break;}
        
        for(int i =arr.Length-1; i > -1; i--)
            if(arr[i] == 2) {e= i; break;}
        
        if(s==-1 || e==-1 )
            return new int[]{-1};
            
        return arr.Where((item,index) => s<=index && e>=index ).ToArray();
    }
}