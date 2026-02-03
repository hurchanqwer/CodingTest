using System;

public class Solution {
    public int[] solution(int n, int k) {
        int length = n/k;
        int[] answer = new int[length];
        int index=0;
        for(int i=k ; i<=n;i+=k){
            answer[index++] = i;
        }
        return answer;
    }
}