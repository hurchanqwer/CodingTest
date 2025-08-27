#include <string>
#include <vector>
#include <queue>

using namespace std;

int solution(vector<int> priorities, int location) {
    int answer = 0;
    priority_queue<int> waitQ;
    
    for(int p : priorities){
        waitQ.push(p);
    }

    while(waitQ.size()>0)
    {
        for(int i= 0; i<priorities.size();i++){
            if(waitQ.top() == priorities[i])
            {
                answer++;
                waitQ.pop();
                
                if(i == location){
                    return answer;
                }
            }
        }
    }    
}