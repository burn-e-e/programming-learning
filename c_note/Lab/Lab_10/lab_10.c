#include <stdio.h>
#include <stdlib.h>
#define S 100
void readElements(int *len, double *mas)
{
     int i;
     printf("Hemjee:");
     scanf("%d", len);
     for (i = 0; i < *len; i++)
          scanf("%lf", mas + i);
}
void changeElements(int len, double *mas)
{
     double max = mas[0];
     int maxIndex = 0, i;
     for (i = 1; i < len; i++)
          if (max < mas[i])
          {
               max = mas[i];
               maxIndex = i;
          }
     for (i = maxIndex + 1; i < len; i++)
          mas[i] = 0.5;
}
void printElements(int len, double *mas)
{
     for (int i = 0; i < len; i++)
          printf("%.3lf ", mas[i]);
     printf("\n");
}
main()
{
     double a[S], b[S];
     int n, m;
     readElements(&n, a);
     readElements(&m, b);
     changeElements(n, a);
     changeElements(m, b);
     printElements(n, a);
     printElements(m, b);
     system("pause");
     return 0;
}