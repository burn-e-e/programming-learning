#include <iostream>
using namespace std;
int main()
{
  int n, r, sum = 0, temp, i = 0;
  cout << "Enter the Number=";
  cin >> n;
  temp = n;
  while (n > 0)
  {
    i += 1;
    cout << i << " Section \n";
    r = n % 10;
    cout << r << "=r \n";
    sum = (sum * 10) + r;
    cout << sum << "=sum \n";
    n = n / 10;
    cout << n << "=n \n";
  }
  if (temp == sum)
    cout << "Number is Palindrome";
  else
    cout << "Number is not Palindrome";
  return 0;
}