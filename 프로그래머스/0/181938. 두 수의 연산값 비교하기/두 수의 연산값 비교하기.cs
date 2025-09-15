using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        string temp = "";
        temp += a ;
        temp += b;
        int plus = int.Parse(temp);
        int mul = 2 * a * b;
        
        return plus >= mul ? plus : mul;
    }
}