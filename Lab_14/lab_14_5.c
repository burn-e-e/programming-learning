#include <stdio.h>
#include <stdlib.h>

int main()
{
     char answer[100];
     char answer1[100];
     char answer2[100];
     FILE *fptr;
     fptr = fopen("answer.txt", "w");

     if (fptr == NULL)
     {
          printf("Error!");
          exit(1);
     }

     printf("Hariu bich bich: ");
     scanf("%s %s %s", &answer, &answer1, &answer2);

     fprintf(fptr, "%s %s %s", answer, answer1, answer2);
     fclose(fptr);

     return 0;
}