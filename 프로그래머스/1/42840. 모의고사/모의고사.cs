using System;
using System.Collections.Generic;
using System.Linq;
public class Solution
{
    public int[] solution(int[] answers)
    {
        int[] correctTest = new int[3];
        List<int> answer = new List<int>();
        int[] one = { 1, 2, 3, 4, 5 };
        int[] two = { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] three = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
  
        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == one[i % one.Length]) correctTest[0]++;
            if (answers[i] == two[i % two.Length]) correctTest[1]++;
            if (answers[i] == three[i % three.Length]) correctTest[2]++;
        }

        int max = correctTest.Max();
        for (int i = 0; i < 3; i++)
        {
            if (correctTest[i] == max)
            {
                answer.Add(i + 1);
            }
        }
        return answer.ToArray();
    }
}