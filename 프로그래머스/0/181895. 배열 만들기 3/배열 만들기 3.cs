using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, int[,] intervals) {
        int[] answer = new int[]{};
        for(int i=0; i<intervals.GetLength(0); i++)
           {   
            int a1 = intervals[i,0];
            int a2 = intervals[i,1];
            answer = answer.Concat(arr.Where((item, index) => a1 <= index && index <= a2).ToArray()).ToArray();
           }
        
        return answer;
    }
}