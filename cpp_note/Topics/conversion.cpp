#include <iostream>
int main()
{
     using namespace std;
     cout << (char)69;
     cout << (char)110;
     cout << (char)116;
     cout << (char)101;
     cout << (char)114;
     cout << (char)32;

     int n, a;
     a = rand() % 100;
     string str = " + 10", string_s;
     cin >> n;
     cout << "Random number = " << a << endl;
     a += n;
     cout << a <<" ASCII Decimal number"<< endl;
     string_s = ((char)a) + str;
     cout << string_s << endl;

     return 0;
}