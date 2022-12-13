#include <stdio.h>
#include <stdlib.h>

int main()
{
     int input[100], even[100], n, odd[100];
     FILE *fptw;
     FILE *fptw_even;
     FILE *fptw_odd;
     fptw = fopen("input.txt", "w");
     fptw_even = fopen("even.txt", "w");
     fptw_odd = fopen("odd.txt", "w");
     scanf("%d", &n);
     for (int i = 0; i < n; i++)
     {
          input[i] = rand() % 100;
          fprintf(fptw, "%d \n", input[i]);
     }
     for (int i = 0; i < n; i++)
     {
          if (input[i] % 2 == 0)
          {
               fprintf(fptw_even, "%d \n", input[i]);
          }
          else
          {
                 fprintf(fptw_odd, "%d \n", input[i]);
             
          }
     }

     fclose(fptw);
     fclose(fptw_even);
     fclose(fptw_odd);

     return 0;
}