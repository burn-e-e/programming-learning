#include <stdio.h>
#include <stdlib.h>

int main()
{
     char greeting[100];
     char greeting1[100];
     char greeting2[100];
     FILE *fptr;
     fptr = fopen("greeting.txt", "w");

     if (fptr == NULL)
     {
          printf("Error!");
          exit(1);
     }

     printf("Mendchilgee bich: ");
     scanf("%s %s %s", &greeting, &greeting1, &greeting2);

     fprintf(fptr, "%s %s %s", greeting,greeting1,greeting2);
     fclose(fptr);

     return 0;
}