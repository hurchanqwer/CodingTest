using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int n, int[] slicer, int[] num_list) {
        int[] answer = new int[] {};
        int a =slicer[0];
        int b =slicer[1];
        int c =slicer[2];
        switch(n){
            case 1:
                answer = num_list.Where((w,index)=>index <=b).ToArray();
                break;
            case 2:
                answer = num_list.Where((w,index )=>index >= a).ToArray();
                break;
            case 3:
                answer = num_list.Where((w,index) => index >= a && index <= b).ToArray();
                break;
            case 4:
                List<int> list = new List<int>();
                
                for(int i=a; i<= b;i+=c )
                    list.Add(num_list[i]); 
                
                answer = list.ToArray();
                break;
        }
        return answer;
    }
}