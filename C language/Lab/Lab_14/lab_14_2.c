#include <stdio.h>
#include <stdlib.h>

int main()
{
   char name[100];
   FILE *fptr;
   fptr = fopen("burnee.txt","w");

   if(fptr == NULL)
   {
      printf("Error!");   
      exit(1);             
   }

   printf("Neree bich");
   scanf("%s",&name);

   fprintf(fptr,"%s",name);
   fclose(fptr);

   return 0;
}