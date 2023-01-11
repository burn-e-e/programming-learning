#include <iostream>
#include <windows.h>
#include <string.h>
#define M 3
#define K 2
#define N 3
int i = 0, j, a = 0, b = 1;
int A[M][K] = {{1, 4}, {2, 5}, {3.6}};
int B[K][N] = {{8, 7, 6}, {5, 4, 3}};
int C[M][N];
using namespace std;
int main()
{
     for (i; i < M; i++)
     {
          j = 0;
          for (j; j < N; j++)
          {
               C[i][j] = A[i][a] * B[a][j] + A[i][b] * B[b][j];
               cout << C[i][j] << " ";
          }
     }

     return 0;
}