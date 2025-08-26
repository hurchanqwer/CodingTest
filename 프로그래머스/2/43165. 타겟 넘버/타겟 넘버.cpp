#include <string>
#include <vector>
#include<iostream>
using namespace std;

//숫자를 모두 써야함 = depth 체크 dfs
//+와 - 두가지 경우의 수
//depth 충족 시 sum == target 체크, 맞다면 answer++
    
void dfs(int depth, int sum, int target, int& answer , vector<int> numbers){
    if(depth == numbers.size()){
        if(sum == target)
            answer++;

        return ;
    }
        dfs(depth+1, sum + numbers[depth], target,answer, numbers);
        dfs(depth+1, sum - numbers[depth], target,answer, numbers);
}


int solution(vector<int> numbers, int target) {
    int answer = 0;
    dfs(0, 0, target, answer, numbers);
    return answer;
}

