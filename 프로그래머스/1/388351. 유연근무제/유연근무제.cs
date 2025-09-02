using System;

public class Solution {
    public int solution(int[] schedules, int[,] timelogs, int startday) {
        int answer = 0;
        
        for(int member = 0; member<schedules.Length; member++){
            
            int schedule = schedules[member]+10;            
            int h = schedule / 100;
            int m = schedule % 100;
            int start = startday;
            if(m > 59){
                h+=1;
                m-=60;
            }
            
            int limit = h * 100 + m;
            bool check = true;
            
            for(int day = 0; day<timelogs.GetLength(1);day++){
                     Console.WriteLine(startday);
                if(start == 6)
                {
                    start++;
                    continue;
                }
                if(start == 7){
                    start=1;
                    continue;
                }
       
                int log = timelogs[member, day];
            
                if(limit < log){
                    check =false;
                    break;
                }
                start++;
            }
            
            if(check)
                answer++;
        }
        return answer;
        
    }
}