using System;

public class Solution {
     int answer;
    public int solution(int[] numbers, int target) {
        answer = 0;

        dfs(0,0,numbers,target);
        return answer;
    }
    void dfs(int depth, int sum, int[] numbers, int target){
        if(depth == numbers.Length){
            
            if(sum == target)
                answer++;
            return;
        }
        dfs(depth+1, sum + numbers[depth],numbers,target);
        dfs(depth+1, sum - numbers[depth],numbers,target);
    }
}