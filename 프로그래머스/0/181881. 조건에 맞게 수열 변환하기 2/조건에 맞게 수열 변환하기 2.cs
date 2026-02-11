using System;
using System.Linq;
public class Solution {
    public int solution(int[] arr) {
        int answer = 0;
        int[] preArr = new int[arr.Length];
        int x=0;
        do
        {
            x++;
            Array.Copy(arr, preArr, arr.Length);
            
            for(int i=0; i< arr.Length; i++){
                int cur = arr[i];
                if(cur>=50&&cur%2 == 0) arr[i]/=2;
                    else if(cur<50 && cur%2 != 0) arr[i] = (arr[i] * 2) + 1;       
            }     

        }while(!preArr.SequenceEqual(arr));
        
        return x-1;
    }
}