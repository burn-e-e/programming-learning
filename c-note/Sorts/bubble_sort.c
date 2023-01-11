#include <stdio.h>
int main()
{
     int n, counter = 1;
     scanf("%d", &n);
     int arr[n];
     for (int i = 0; i < n; i++)
     {
          arr[i] = rand() % 10;
          printf("%d ", arr[i]);
     }
     while (counter < n)
     {
          for (int i = 0; i < n - counter; i++)
          {
               if (arr[i] > arr[i + 1])
               {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
               }
                    }
          counter++;
     }
     printf("\n");
     for (int i = 0; i < n; i++)
     {
          printf("%d ", arr[i]);
     }

     return 0;
}