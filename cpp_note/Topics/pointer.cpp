#include <iostream>
using namespace std;
int main()
{
     int x = 4;
     int *pX = &x;
     int y = *pX;
     // cout << y;
     if (x == y)
     {
          cout << "It's equal" << endl;
     }
     
     return 0;
}