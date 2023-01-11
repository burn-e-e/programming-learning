#include <iostream>
using namespace std;
int main() {
     int *pointer = nullptr;
     int x= 123;
     pointer = &x;
     if (pointer == nullptr)
     {
          cout << "address was not assigned\n";
     }else{
          cout<<"address was assigned\n";
     }
     
     return 0;
}