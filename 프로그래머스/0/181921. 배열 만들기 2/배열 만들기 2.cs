using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int l, int r) {
        List<int> answer = new List<int>();
        for(; l <= r; l+=1){
            string s = l.ToString();
            bool correct = true;
          
            foreach(char c in s){
                if(c == '0' || c == '5'){
                   continue;
                }
                correct = false;
            }
            if(correct){
                answer.Add(l);
            }
        }
        if(answer.Count == 0) answer.Add(-1);
        return answer.ToArray();
    }
}