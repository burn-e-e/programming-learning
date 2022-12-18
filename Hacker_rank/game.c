#include <stdio.h>
#define MAX 100
int main() {
     int p1,p2;
     do
     {
          printf(" Player 1 enter the a number: ");
          scanf("%d",&p1);
          printf(" Player 2 enter the a number: ");
          scanf("%d",&p2);
          if ((p1 == p2) || (p1+10 < p2) || (p2+10 < p1))
          {
               printf("This number is illegal");
               break;
          }
          
     } while ((p1 || p2)<=100);
     
     return 0;
}