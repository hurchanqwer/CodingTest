using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string[] intStrs, int k, int s, int l) {
        List<int> answer = new List<int>();
       
        
        for(int i =0; i<intStrs.Length; i++){
            string temp = "";
            string curStr = intStrs[i];
            
            for(int j = s; j < s+l; j++){
                temp += curStr[j];
            }
            int num = int.Parse(temp);
            if (k < num) answer.Add(num);
        }
        return answer.ToArray();
    }
}