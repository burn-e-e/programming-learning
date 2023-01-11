#include <iostream>
using namespace std;
int factorial(int num);
int main()
{
     cout<<factorial(4);
     return 0;
}
int factorial(int num)
{
   if (num>1)
   {
     return num*factorial(num-1);
   }else{
     return 1;
   }
   
}