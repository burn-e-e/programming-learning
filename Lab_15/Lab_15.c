#include <stdio.h>
#include <stdlib.h>

int main()
{
     int too[100], max[100], n;
     FILE *fout;
     FILE *fout_max;
     fout = fopen("too.dat", "wb");
     fout_max = fopen("max.dat", "wb");
     scanf("%d", &n);
     for (int i = 0; i < n; i++)
     {
          too[i] = rand() % 100;
          fwrite(&too[i],4,1,fout);
     }

     fclose(fout);
     fclose(fout_max);

     return 0;
}