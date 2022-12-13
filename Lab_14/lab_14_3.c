#include <stdio.h>
#include <string.h>
int main()
{
     FILE *fpr;
     char str[100];
     fpr = fopen("burnee.txt", "r");
     if (fpr == NULL)
     {
          puts("Could not open");
     }
     while (1)
     {
          if (fgets(str, 10, fpr) == NULL)
          {
               break;
          }
          else
          {
               printf("%s", str);
          }
     }
     fclose(fpr);
     return 0;
}