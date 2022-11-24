#include <stdio.h>
int nemeh(int too1, int too2);
int hasah(int too3, int too4);
int urjih(int too5, int too6);
int huvaah(int too7, int too8);
int uldegdel(int too9, int too10);
int main()
{
     int too, b, a, answer;
     printf("1.+ \n2.- \n3.* \n4./ \n5.%%\n");
     scanf("%d", &too);
     switch (too)
     {
     case 1:
          scanf("%d %d", &a, &b);
          answer = nemeh(a, b);
          printf("%d", answer);
          break;
     case 2:
          scanf("%d %d", &a, &b);
          answer = hasah(a, b);
          printf("%d", answer);
          break;
     case 3:
          scanf("%d %d", &a, &b);
          answer = hasah(a, b);
          printf("%d", answer);
          break;
     case 4:
          scanf("%d %d", &a, &b);
          answer = urjih(a, b);
          printf("%d", answer);
          break;
     case 5:
          scanf("%d %d", &a, &b);
          answer = uldegdel(a, b);
          printf("%d", answer);
          break;
     default:
          break;
     }
     return 0;
}
int nemeh(int too1, int too2)
{
     int sum;
     sum = too1 + too2;

     return sum;
}
int hasah(int too3, int too4)
{
     int ylgavar;
     ylgavar = too3 - too4;

     return ylgavar;
}
int urjih(int too5, int too6)
{
     int answer;
     answer = too5 * too6;
     return answer;
}
int huvaah(int too7, int too8)
{
     int answer;
     answer = too7 / too8;

     return answer;
}
int uldegdel(int too9, int too10)
{
     int answer;
     answer = too9 % too10;

     return answer;
}