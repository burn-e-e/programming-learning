#include <iostream>
using namespace std;
int main()
{
     int A[100], i, n, s = 0, m, s1 = 0, s2, s3;
     cout << "n=";
     cin >> n;
     for (i = 1; i <= n; i++)
     {
          cout << "A[" << i << "]=";
          cin >> A[i];
     }
     for (i = 1; i <= n; i = i + 2)
     {
          s = s + A[i];
     }
     for (i = 2; i <= n; i = i + 2)
     {
          s1 = s1 + A[i];
     }
     s3 = s - s1;
     cout << "The diffrence is: " << s3;
     return 0;
}