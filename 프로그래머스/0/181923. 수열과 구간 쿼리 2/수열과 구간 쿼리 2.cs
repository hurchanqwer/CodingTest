using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[queries.GetLength(0)];
        
        for(int i=0; i < queries.GetLength(0);i++){
            
            int smallest = -1;
            
            int s = queries[i,0];
            int e = queries[i,1];
            int k = queries[i,2];
            
            for(; s <= e; s++){
                if(arr[s] > k){
                    if(smallest==-1) smallest = arr[s];
                    else if(smallest > arr[s]) smallest =  arr[s];
                }
            }
            answer[i] = smallest;
        }
        return answer;
    }
}