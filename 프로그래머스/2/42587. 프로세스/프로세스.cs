using System;

public class Solution {
    public int solution(int[] priorities, int location) {
        int answer = 1;
        
        int[] process = (int[])priorities.Clone();
        Array.Sort(priorities);
        Array.Reverse(priorities);
        int index =0;
        int max = priorities[index++];
        
        while(priorities.Length != 0){
            for(int i =0; i<process.Length; i++){
              
                if(process[i] != max)
                  continue;
                
                    if(i==location)
                        return answer;
                  
                    max = priorities[index++];
                    answer++;
                
            }
       }
        
        return answer;
    }
}