using System;
using System.Linq;
public class Solution {
    public int solution(int[] num_list) {
        
    string oddStr = string.Concat(num_list.Where(n => n % 2 != 0));
    string evenStr = string.Concat(num_list.Where(n => n % 2 == 0));

    return int.Parse(oddStr) + int.Parse(evenStr);
    }
}