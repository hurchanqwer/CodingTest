#include <iostream>
#include <string>

using namespace std;

int main(void) {
    string str;
    cin >> str;
    int a;
    for (int i = 0; i < str.length(); i++) {
        a = str[i];
        if (a > 'Z')
            a -= 32;
        else
            a += 32;
       
        str[i] = a;
    }
    cout << str;
        return 0;
}