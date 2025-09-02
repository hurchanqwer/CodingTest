using System;
using System.Collections.Generic;

class Solution {
    public int solution(int[,] maps) {
        int my = maps.GetLength(0);
        int mx = maps.GetLength(1);
        int[] dx =  {0, 1, -1, 0};
        int[] dy = {1, 0, 0, -1};
        Queue<(int,int,int)> que = new Queue<(int,int,int)>();
        bool[,] visited = new bool[my,mx];
        que.Enqueue((0,0,1));
        visited[0, 0] = true;
        while(que.Count > 0){
            var (y,x,depth) = que.Dequeue();
            
            if(x == mx-1 && y == my-1 ){
                return depth;
            }
            
            for(int i = 0;i<4;i++){
                int nx = dx[i] + x;
                int ny = dy[i] + y;
                
                if(nx < 0 || nx >= mx || ny < 0 || ny >= my)
                    continue;
                
                if(maps[ny, nx] == 1){
                    if(visited[ny, nx] == false){
                        que.Enqueue((ny,nx,depth+1));
                        visited[ny, nx] = true;
                    }
                }
            }
        }
        return -1;
    }
}