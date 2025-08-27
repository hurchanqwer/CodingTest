#include<string>
#include <iostream>

using namespace std;

bool solution(string s)
{
    bool answer = true;

      int count;
        count=0;
        for (char c : s){
            if(count<0) return false;
            
            if(c=='(')
                count++;
            else
                 count--;
        }
        if (count==0)
            return true;
  
        return false;

    return answer;
}