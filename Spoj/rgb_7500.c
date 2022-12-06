#include <stdlib.h>
#include <stdio.h>
int main()
{
     int i, n, s = 0;
     scanf("%d", &n);
     int a[n];
     for (i = 0; i < n - 1; i++)
     {
          scanf("%d\n", &a[i]);
          s = s + a[i];
     }
     scanf("%d", &a[n]);
     s = s + a[n];
     printf("%d\n", s);

     return 0;
}