#include <iostream>
using namespace std;
int main()
{
     long A[100][100],i,j,n,m;
     cout<<"n=";
     cin>>n;
     cout<<"m=";
     cin>>m;
     for ( i = 1; i <= n; i++)
     {
          for ( j = 1; j <= m; j++)
          {
               A[i][j] =0;
               cout<<A[i][j]<<"\t";
          }
          cout<<"\n";
     }
     
     return 0;
}