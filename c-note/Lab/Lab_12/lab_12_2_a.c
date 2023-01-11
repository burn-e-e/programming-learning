#include <stdio.h>
int main()
{
     char useg;
     int next;
     scanf("%c", &useg);
     next = (int)(useg + 1);
     char drachin = (char)(next);
     printf("%c%c", useg, drachin);
     return 0;
}