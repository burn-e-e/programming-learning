#include <iostream>
using namespace std;
int main(){
     int grades[]={98,100,95,93,};
     for(int grade : grades){
          cout << grade << "\n";
     }
     string students[]={"Bob", "Mark", "John", " Sandy"};
     for(string student:students){
          cout << student << "\n";
     }
     return 0;
}