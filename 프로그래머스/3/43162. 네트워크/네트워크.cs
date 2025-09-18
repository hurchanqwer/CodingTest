using System;

public class Solution {
    bool[] visited;
    int max;
    int[,] computers1;
    void dfs(int node){
          visited[node] = true;
        for(int next =0; next<max;next++){
                if (computers1[node,next] == 1 && !visited[next])
                      dfs(next);
            }
        }
    
    public int solution(int n, int[,] computers) {
        int answer = 0;
        computers1 = computers;
        max=n;
        visited = new bool[n];
        for(int i =0;i<n;i++){
            if(!visited[i])
            {
                dfs(i);
                answer++;}
            }
        return answer;
    }
}