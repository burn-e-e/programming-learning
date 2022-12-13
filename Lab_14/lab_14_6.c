#include <stdio.h>
#include <stdlib.h>

int main()
{
     int too[100], too1[100], n, niilber[100];
     FILE *fptw1;
     FILE *fptw2;
     FILE *fptwsum;
     fptw1 = fopen("too1.txt", "w");
     fptw2 = fopen("too2.txt", "w");
     fptwsum = fopen("sum.txt", "w");
     scanf("%d", &n);
     for (int i = 0; i < n; i++)
     {
          too[i] = rand() % 100;
          fprintf(fptw1, "%d \n", too[i]);
     }
     for (int i = 0; i < n; i++)
     {
          too1[i] = rand() % 100;
          fprintf(fptw2, "%d \n", too1[i]);
     }
     for (int i = 0; i < n; i++)
     {
          niilber[i] = too[i] + too1[i];
          fprintf(fptwsum, "%d \n", niilber[i]);
     }
     fclose(fptw1);
     fclose(fptw2);
     fclose(fptwsum);

     return 0;
}