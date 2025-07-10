#include <string>
#include <vector>
#include <unordered_map>

using namespace std;


string solution(vector<string> participant, vector<string> completion) {
    unordered_map<string, int> participantHash;

    for (auto& name : participant)
        participantHash[name]++;

    for (auto& name : completion)
        participantHash[name]--;

    for (auto& entry : participantHash) {
        if (entry.second > 0)
            return entry.first;
    }

    return "";
}