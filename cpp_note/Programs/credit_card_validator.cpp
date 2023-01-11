#include <iostream>
using namespace std;
int getDigit(const int number);
int sumOddDigits(const string cardNumber);
int sumEvenDigits(const string cardNumber);
int main()
{
    string cardNumber;
    int result = 0;

    cout << "Enter a credit card #: ";
    cin >> cardNumber;

    result = sumEvenDigits(cardNumber) + sumOddDigits(cardNumber);

    if(result % 10 == 0){
        cout << cardNumber << " is valid";
    }
    else{
        cout << cardNumber << " is not valid";
    }

	return 0;
}
int getDigit(const int number){

    return number % 10 + (number / 10 % 10);
}
int sumOddDigits(const string cardNumber){

    int sum = 0;

    for(int i = cardNumber.size() - 1; i >= 0; i-=2){
        sum += cardNumber[i] - '0';
    }

    return sum;
}
int sumEvenDigits(const string cardNumber){

    int sum = 0;

    for(int i = cardNumber.size() - 2; i >= 0; i-=2){
        sum += getDigit((cardNumber[i] - '0') * 2);
    }

    return sum;
}