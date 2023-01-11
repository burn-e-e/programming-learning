#include <stdio.h>
#include <string.h>
int main()
{
     char ovog[100], ner[100];
     printf("Ovog neree oruul:");
     scanf("%s %s", &ovog, &ner);
     printf("%c. %s", ovog[0], ner);
     return 0;
}