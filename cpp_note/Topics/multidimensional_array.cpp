#include <iostream>
using namespace std;
int main()
{
     int season, student;
     cout << "Enter season: ";
     cin >> season;
     cout << "Enter Student number: ";
     cin >> student;
     int arr[season][student];
     for (int i = 0; i < season; i++)
     {
          for (int j = 0; j < student; j++)
          {
               arr[i][j] = rand() % 101;
               cout << ""<<arr[i][j];
          }
     }

     return 0;
}