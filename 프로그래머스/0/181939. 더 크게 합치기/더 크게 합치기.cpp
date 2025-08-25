#include <string>
#include <vector>

using namespace std;

int solution(int a, int b)
{
    int answer = 0;
    string atob, btoa;

    atob = to_string(a) + to_string(b);
    btoa = to_string(b) + to_string(a);

    return atob >= btoa ? stoi(atob) : stoi(btoa);
}