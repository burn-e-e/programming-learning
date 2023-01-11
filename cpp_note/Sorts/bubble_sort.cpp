#include <iostream>
using namespace std;
int main()
{
     int n;
     cin >> n;
     int arr[n];
     cout << "Unsorted array: ";
     for (int i = 0; i < n; i++)
     {
          arr[i] = (rand() % 10) + 1;
          cout << arr[i] << " ";
     }
     int counter = 1;
     while (counter < n)
     {
          for (int i = 0; i < n - counter; i++)
          {
               if (arr[i] > arr[i + 1])
               {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
               }
          }
          counter++;
     }
     cout << "\n";
     cout << "Sorted array: ";
     for (int i = 0; i < n; i++)
     {
          cout << arr[i] << " ";
     }
     cout << endl;
}