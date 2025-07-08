#include <vector>
#include <iostream>

using namespace std;

vector<int> solution(vector<int> arr) 
{
    vector<int> answer;
   
    if (arr.empty()) return answer;
    
    answer.push_back(arr[0]);
    int n = arr[0];
    
    for (int i = 1; i < arr.size(); i++) {
        if (arr[i - 1] !=  arr[i])
            answer.push_back(arr[i]);
            n = arr[i];
    }
    return answer;
}