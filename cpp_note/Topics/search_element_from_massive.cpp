#include <iostream>
using namespace std;
int searcharray(int array[], int size, int element);
int main()
{
     int n, mynum, index;
     cin >> n;
     int numbers[n];
     for (int i = 0; i < n; i++)
     {
          numbers[i] = rand() % 10;
          cout << i + 1 << ". " << numbers[i] << "\n";
     }
     cout << "Enter element to search for: \n";
     cin >> mynum;
     index = searcharray(numbers, n, mynum);
     if (index != 1)
     {
          cout << mynum << " is at index " << index;
     }
     else
     {
          cout << mynum << " is not in the array  ";
     }

     return 0;
}
int searcharray(int array[], int size, int element)
{
     
     for (int i = 0; i < size; i++)
     {
          if (array[i] == element)
          {
               return i;
          }
     }
     return 1;
}