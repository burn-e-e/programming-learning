//
// Created by 4burn on 2024.05.30.
//

#include "MyClass.h"

#include <iostream>
using namespace std;

class MyChild : public MyClass, public MyWife{
public:
    void myChildFunction() {
        cout<<"My child function!";
    }
    void setSmart(string s) {
        this->smart = s;
    }
    string getSmart() {
        return smart;
    }
    void greetToBurnee() {
        cout<<"Hi Dad! \n";
    }
    void greetToE() {
        cout<<"Hi Mom! \n";
    }
};
class MyGrandChild: public MyChild {
public:
    void myGrandChildFunction() {
        cout<< "My grandchild function";
    }
    void greetToBurnee() {
        cout<<"Hi Grandpa! \n";
    }
    void greetToE() {
        cout<<"Hey Grandma \n";
    }
};
int notmain() {
    MyChild my_child;

    my_child.myWifeFunction();
    my_child.setSmart("Very smart \n");
    cout<< my_child.getSmart();


    MyGrandChild grandchild;
    grandchild.myFunction();
    grandchild.myWifeFunction();

    my_child.greetToBurnee();
    grandchild.greetToBurnee();

    return 0;
}
