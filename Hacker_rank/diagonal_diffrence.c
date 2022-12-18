#include <stdio.h>
int function(int n);
int main()
{
     signed int n, difference;
     scanf("%d", &n);
     difference = function(n);
     printf("%d", difference);
     return 0;
}
int function(int n)
{
     int difference, principal = 0, secondary = 0;
     int arr[n][n];
     for (int i = 0; i < n; i++)
     {
          for (int j = 0; j < n; j++)
          {
               arr[i][j] = rand() % 10;

               printf("%d ", arr[i][j]);
               if (i == j)
               {
                    principal += arr[i][j];
               }
               if ((i + j) == (n - 1))
               {
                    secondary += arr[i][j];
               }
          }
          printf("\n");
     }
     difference = principal - secondary;

     return abs(difference);
}
