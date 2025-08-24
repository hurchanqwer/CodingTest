int solution(int n, int w, int num)
{
    int answer = 0;

    int floor = (num - 1) / w + 1;          // 층
    int pos = (num - 1) % w + 1;            // 기본 열
    int col = (floor % 2 == 1) ? pos : w - pos + 1; // 실제 열 번호

    int boxNum = num;

    while (boxNum <= n)
    {
        answer++;
        floor++;

        if (floor > (n + w - 1) / w) break; // 창고 높이 넘으면 종료

        if (floor % 2 == 1) // 홀수층
            boxNum = (floor - 1) * w + col;
        else // 짝수층
            boxNum = floor * w - col + 1;
    }
    return answer;
}
