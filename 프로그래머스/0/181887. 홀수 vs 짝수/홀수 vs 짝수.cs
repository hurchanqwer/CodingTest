using System;

public class Solution {
    public int solution(int[] num_list) {

        int odd=0;
        int even=0;
        for(int i=0; i< num_list.Length; i++){
            int cur =num_list[i];
            if(i%2==0) even+=cur;
            else odd+=cur;
        }
        return odd>=even ? odd: even ;
    }
}