using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[] priorities, int location) {
  
        Queue<(int priority , int index)> waitQ = new  Queue<(int, int)>();
        int answer = 1;
        int index=0;
        
        foreach (int p in priorities)
            waitQ.Enqueue((p, index++));
        
        while(waitQ.Count > 0){
            var cur = waitQ.Dequeue();
            if(waitQ.Any(x => x.priority > cur.priority)){
                waitQ.Enqueue(cur);
            }
            else{
                if (cur.index == location) break;
                answer++;
            }
        }
        
        return answer;
    
        //큐 안쓰고 더 빠름
        /*int answer = 1;
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
        
        return answer;*/
    }
}