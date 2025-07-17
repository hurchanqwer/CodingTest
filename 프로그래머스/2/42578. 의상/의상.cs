using System;
using System.Collections.Generic;
public class Solution
{
    public int solution(string[,] clothes)
    {
        int answer = 1;
        Dictionary<string, int> dic = new Dictionary<string, int>();
        for (int i = 0; i < clothes.GetLength(0); i++)
        {
            var part = clothes[i, 1];
            if (dic.ContainsKey(part))
                dic[part]++;
            else
                dic.Add(part, 1);
        }
        foreach (var i in dic.Values)
        {
            answer *= i + 1;
        }

        return answer - 1;
    }
}