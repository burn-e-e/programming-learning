#include <iostream>
using namespace std;
int main(){

     int *pNum = NULL;
     pNum = new int;
     *pNum = 21;
     cout<<"Address: "<<pNum<<'\n';
     cout<<"Value: "<<*pNum<<'\n';
     return 0;
}