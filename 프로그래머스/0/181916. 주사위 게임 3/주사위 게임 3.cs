using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
public int solution(int a, int b, int c, int d) {

        int[] dice = { a, b, c, d };
        Array.Sort(dice);
        
        if (dice[0] == dice[3]) {
            return 1111 * dice[0];
        }

        if (dice[0] == dice[2]) {
            return (10 * dice[0] + dice[3]) * (10 * dice[0] + dice[3]);
        }

        if (dice[1] == dice[3]) {
            return (10 * dice[3] + dice[0]) * (10 * dice[3] + dice[0]);
        }

        if (dice[0] == dice[1] && dice[2] == dice[3]) {
            return (dice[0] + dice[2]) * Math.Abs(dice[0] - dice[2]);
        }

        if (dice[0] == dice[1]) { 
            return dice[2] * dice[3];
        }
        if (dice[1] == dice[2]) { 
            return dice[0] * dice[3];
        }
        if (dice[2] == dice[3]) { 
            return dice[0] * dice[1];
        }

        return dice[0];
    }
}