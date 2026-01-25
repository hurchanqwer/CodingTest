using System;

public class Solution {
    public int solution(string number) {
        int answer = 0;
        for(int i=0; i< number.Length; i++){
            answer += number[i] - '0';
        }
        return answer % 9;
    }
}