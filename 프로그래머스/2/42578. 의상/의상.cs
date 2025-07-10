using System;
using System.Collections.Generic;
public class Solution {
      public int solution(string[,] clothes)
    {
        int answer = 0;
        int mul=1;
        Dictionary<string, int> dic = new Dictionary<string, int>();
        for (int i = 0; i < clothes.GetLength(0); i++)
        {

            var key = clothes[i, 1];
            if (dic.ContainsKey(key))
                dic[key]++;
            else
                dic.Add(key, 1);
        }

            foreach (var i in dic.Values)
            {
                if (i > 0)
                    mul *= (i+1);
            }   
        
        answer = mul-1;
        return answer;
    }
}