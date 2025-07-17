using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
class Solution
{
    bool[,] visited;
    int[] mx = { -1, 1, 0, 0 };
    int[] my = { 0, 0, -1, 1 };

    List<int> weight = new List<int>();

    public int solution(int[,] maps)
    {
        visited = new bool[maps.GetLength(0), maps.GetLength(1)];
        Queue<(int, int, int)> q = new Queue<(int, int, int)>();
        q.Enqueue((0, 0, 0));

        int answer = 0;
        while (q.Count > 0)
        {
            (int x, int y, int depth) = q.Dequeue();

            depth++;

            if (x == maps.GetLength(1) - 1 && y == maps.GetLength(0) - 1)
                return depth;
            
            for (int i = 0; i < 4; i++)
            {
                int nx = x + mx[i];
                int ny = y + my[i];

                if (nx < maps.GetLength(1) && ny < maps.GetLength(0) && nx > -1 && ny > -1)
                {
                    if (maps[ny, nx] == 1 && !visited[ny, nx])
                    {
                        visited[ny, nx] = true;
                        q.Enqueue((nx, ny, depth));
                    }
                }
            }
        }
        return -1;
    }
}