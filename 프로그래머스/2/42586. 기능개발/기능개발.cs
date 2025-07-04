using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
       
        List<int> progressList = new List<int>(progresses);
        List<int> ansList = new List<int>();
         List<int> speedsList = new List<int>(speeds);
      
        while(progressList.Count != 0)
        {
           
            for(int i = 0; i<progressList.Count;i++){
                 progressList[i] += speedsList[i];
            }
            
            int num = 0;
         
            while( progressList.Count !=0 && progressList[0] >= 100){
                     num++;
                     progressList.RemoveAt(0);
                     speedsList.RemoveAt(0);   
                 }

            
        if(num!=0)
        ansList.Add(num); 
        }
        
        int[] answer = ansList.ToArray();
        return answer;
    }
}