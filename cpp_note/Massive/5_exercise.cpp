#include <iostream>
using namespace std;
int main()
{
     int A[100], s = 0, a, b, i;
     for (i = 1; i <= 100; i++)
     {
          A[i] = rand() % 100;
          cout << A[i] << "\t";
          for (i = 1; i <= 100; i++)
          {
               a = A[i] / 10;
               b = A[i] % 10;
               s = s + a + b;
          }
     }
     cout << "sum= "
          << "\t" << s;
     return 0;
}