#include <iostream>
using namespace std;
//fill() = fill(begin,end,value)
int main()
{
     int size;
     cout<<"Enter size of input: ";
     cin >>size;
     string foods[size];
     fill(foods, foods + size, "pizza");
     for (string hool : foods)
     {
          cout << hool << '\n';
     }
     return 0;
}