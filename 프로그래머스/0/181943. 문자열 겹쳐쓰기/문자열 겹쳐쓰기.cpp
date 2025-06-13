#include <string>
#include <vector>

using namespace std;

string solution(string my_string, string overwrite_string, int s) {
    string answer = "";
    int i=0;
    for(;s<my_string.length() && i <overwrite_string.length();s++ )
   { 
        my_string[s]  = overwrite_string[i++];
        
    }
    answer = my_string;
    return answer;
}