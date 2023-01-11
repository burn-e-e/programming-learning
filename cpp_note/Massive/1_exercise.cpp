//
#include <iostream>
using namespace std;
int main()
{
     int A[100], n, s = 0, i;
     cout << "Input book number:";
     cin >> n;
     for (i = 1; i <= n; i++)
     {
          cout << "Input book number page: "
               << "A[" << i << "]=";
          cin >> A[i];
          for (i = 1; i <= n; i++)
          {
               if (A[i] >= 100)
               {
                    s = s + 1;
               }
               cout << "100 more pages book " << s;
          }
     }

     return 0;
}