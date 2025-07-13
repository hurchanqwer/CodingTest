using System;
using System.Collections.Generic;
public class Solution
{
    public int solution(string numbers)
    {
        int answer = 0;
        HashSet<int> set = new HashSet<int>();
        permute("", numbers, set);
        return set.Count;
    }

    void permute(string prefix, string remain, HashSet<int> set)
    {
        // 숫자로 만들어서 소수인지 확인
        if (prefix.Length > 0)
        {
            int num = int.Parse(prefix);
            if (IsPrime(num))
                set.Add(num);
        }

        // 나머지 문자로 순열 생성
        for (int i = 0; i < remain.Length; i++)
        {
            string newPrefix = prefix + remain[i];
            string newRemain = remain.Substring(0, i) + remain.Substring(i + 1);
            permute(newPrefix, newRemain, set);
        }
    }

    bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}