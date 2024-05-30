#include <iostream>
using namespace std;

class Vehicle {
public:
    string brand = "Ford";
    void honk() {
        cout<<"Hoking!!\n";
    }
};
class Car : public Vehicle{
private:
    string car_owner = "Burentugs";
public:
    string brand;
    string model;
    int year;
    Car(string brand, string model, int year) {
        this->brand = brand;
        this->model = model;
        this->year = year;
    }
    void setOwner(string name) {
        car_owner = name;
    }
    string getOwner() {
        return car_owner;
    }
    void print() {
        cout << this->brand << " " << this->model << " " << this->year << "\n";
    }
};
int main() {
    Car car1("BMW","X5",1999);
    Car car2("Ford","Mustang",1969);
    car1.setOwner("Burentugs ");
    cout<<car1.getOwner();
    car1.print();
    car1.honk();
    car2.setOwner("Burnee ");
    cout<<car2.getOwner();
    car2.print();
    return 0;
}