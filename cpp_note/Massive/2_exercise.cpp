#include <iostream>
using namespace std;
int main()
{
     int A[100], i, n, s = 0, m;
     cout << "n= ";
     cin >> n;
     for (i = 1; i <= n; i++)
     {
          cout << "A[" << i << "] = ";
          cin >> A[i];
     }
     for (i = 1; i <= n; i++)
     {
          cout << A[i] << "\t";
          cout << A[i] << "\t"
               << "\n"
               << "\n \n \t";
          cout << A[i] << "\n \t";
          cout << A[i] << "\t \t";
     }
     return 0;
}