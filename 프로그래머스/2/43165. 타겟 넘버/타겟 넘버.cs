using System;

public class Solution
{
    int answer = 0;
    public int solution(int[] numbers, int target)
    {
        //- + 이진 트리
        //시작부터 끝까지 탐색
        //타겟 값인지 체크
        //맞으면 answer++;
        DFS(0, 0, numbers, target);
        return answer;
    }
    public void DFS(int depth, int sum, int[] numbers, int target)
    {
     
        if (depth == numbers.Length)
        {
            if (sum == target)
                answer++;
            return;
        }
        DFS(depth+1, sum+numbers[depth], numbers, target);
        DFS(depth+1, sum- numbers[depth], numbers, target);
    }

}