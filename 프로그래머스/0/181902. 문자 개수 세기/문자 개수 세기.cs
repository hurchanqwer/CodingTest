using System;

public class Solution {
    public int[] solution(string my_string) {
        int[] answer = new int[52];

        foreach(var c in  my_string)
            if(c <'a') answer[c -'A']++;
            else answer[c -'A' - 6]++;
     
        return answer;
    }
}