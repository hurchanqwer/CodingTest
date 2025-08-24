#include <string>
#include <vector>
#include <iostream>
using namespace std;

int solution(int n, int w, int num)
{
    int answer = 0;

    // 현재 층
    int floor = (num - 1) / w + 1;
    
    // 현재 열
    int pos = (num - 1) % w + 1;

    // 방향 계산
    int col = (floor % 2 == 1) ? pos : w - pos + 1;

    int boxNum = num;

    while (boxNum <= n)
    {
        answer++;

        floor++;

        if (floor > (n + w - 1) / w)
            break; // 층 넘어가면 종료

        if (floor % 2 == 1) // 홀수 층
        {
            boxNum = (floor - 1) * w + col;
        }
        else // 짝수 층
        {
            boxNum = floor * w - col + 1;
        }
    }

    return answer;
}
