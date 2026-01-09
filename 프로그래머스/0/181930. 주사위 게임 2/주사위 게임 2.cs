using System;

public class Solution {
    public int solution(int a, int b, int c) {
        int answer = 0;
        int[] array= new int[3];
        array[0]= a;
        array[1]= b;
        array[2]= c;
        
        Array.Sort(array);
        int temp= array[0];
        int same = 0;
        
        for(int i=1;i< array.Length; i++){
            if(temp==array[i]) {same++;}
            temp = array[i];
        }
      
        switch(same){
            case 0:
                answer =  a + b + c ;
                break;
            case 1:
                answer = (a + b + c) * (a *a + b*b + c*c );
                break;
            case 2:
                answer =  (a + b + c) * (a *a  + b*b + c*c ) * (a *a * a +  b*b*b +  c*c*c );
                break;
                
        }
        
        return answer;
    }
}