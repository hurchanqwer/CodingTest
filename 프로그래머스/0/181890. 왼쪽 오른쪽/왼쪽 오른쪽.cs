using System;
using System.Linq;
public class Solution {
    public string[] solution(string[] str_list) {
        string[] answer = new string[] {};
        for(int i =0; i< str_list.Length;i++){
            switch(str_list[i]){
                case "l":
                    answer = str_list.Where((w,index)=>index<i).ToArray();
                    return answer;
                case "r":
                    answer = str_list.Where((w,index)=>i<index).ToArray();
                    return answer;
            }
        }
        return answer;
    }
}