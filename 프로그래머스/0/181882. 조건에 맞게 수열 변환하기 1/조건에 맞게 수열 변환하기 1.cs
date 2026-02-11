using System;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[arr.Length];
        for(int i =0;i< arr.Length;i++){
            int cur = arr[i];
            if(cur >=50 && cur%2==0) answer[i]= cur/2;
                else if(cur < 50 && !(cur%2==0))answer[i]= cur*2;
                else answer[i]= cur;
        }
        return answer;
    }
}