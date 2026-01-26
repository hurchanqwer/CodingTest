using System;

public class Solution {
    public string solution(string my_string, int[,] queries) {
        string answer = my_string;
        for(int i = 0; i < queries.GetLength(0);i++){
            string temp = "";
            int s = queries[i,0];
            int e = queries[i,1];
            
            for(int j = 0 ; j < my_string.Length; j++){
                if (j == s) 
                   { 
                    for(int k = e ; k >= s ;k--)
                        temp += answer[k];
                    
                    j = e;
                   }
                else temp += answer[j];
            }
            answer = temp;
        }
        return answer;    
    }
}