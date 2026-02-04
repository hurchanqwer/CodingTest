using System;

public class Solution {
    public int[] solution(int[] arr, int[] query) {
        int s=0;
        int e=0;
 
        for(int i=0; i< query.Length;i++){
            if(i%2==0)
                 e=s+query[i];
            else
                 s=s+query[i];   
        }
        int[] answer = new int[e-s+1];
        Array.Copy(arr, s,answer, 0 ,e-s+1);
        
        return answer;
    }
}