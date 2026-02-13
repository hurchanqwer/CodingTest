using System;

public class Solution {
    public int solution(int[] num_list) {
        int count = 0;
        for(int i =0; i< num_list.Length;i++){
            int cur = num_list[i];
            while(cur != 1){
                if(cur%2==0) cur=cur/2;
                else cur=(cur-1)/2;
                count++;
            }
        }
        return count;
    }
}