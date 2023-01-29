#include <stdio.h>
int main()
{
     int n,counter = 0;
     scanf("%d", &n);
     int a[n];
     printf("Unsorted array: ");
     for (int i = 0; i < n; i++)
     {
          a[i] = rand() % 10;
          printf("%d ", a[i]);
     }
     while (counter < n)
     {
          for (int i = 0; i < n - counter; i++)
          {
               if (a[i] > a[i + 1])
               {
                    int temp = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = temp;
               }
          }
          counter++;
     }
     printf("\nSorted array: ");
     for (int i = 0; i < n; i++)
     {
          printf("%d ", a[i]);
     }
     
     return 0;
}
