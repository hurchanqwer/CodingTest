using System;



public class Solution {
    
    int TimeToNumber(string str){
        string[] temp = str.Split(':');
        int m = int.Parse(temp[0]);
        int s = int.Parse(temp[1]);
        return m * 60 + s;
    }
    
    public string solution(string video_len, string pos, string op_start, string op_end, string[] commands) {
        string answer = "";
       
        int ivideo_len = TimeToNumber(video_len);
        int ipos = TimeToNumber(pos);
        int iop_start = TimeToNumber(op_start);
        int iop_end = TimeToNumber(op_end);
        
        int time=ipos;
        foreach(string str in commands){
            
            if(time >= iop_start && time<=iop_end)
                time = iop_end;

            switch(str){
                case "next":
                    time +=10;
                    break;
                case "prev":
                    time -=10;
                    break;
            }
            
            if(time <= 0)
                time = 0;
            else if( ivideo_len <= time)
                time = ivideo_len;
            
        }
        if(time >= iop_start && time<=iop_end)
                time = iop_end;
        int minute = time / 60;
        int seconds = time % 60;
        return $"{minute:D2}:{seconds:D2}";
    }
}