#include <iostream>
#include <chrono>
#include <thread>
#include <cmath>
using namespace std;
const int height = 20;
const int width = 40;

void print_frame(int x, int y)
{
    cout << "\033[2J\033[1;1H";
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            if (i == y && j == x)
            {
                cout << "O";
            }
            else
            {
                cout << " ";
            }
        }
        cout << endl;
    }
}

int main()
{
    int x = 0;
    int y = 0;
    int x_direction = 1;
    int y_direction = 1;
    while (true)
    {
        print_frame(x, y);
        x += x_direction;
        y += y_direction;
        if (x == 0 || x == width - 1)
        {
            x_direction *= -1;
        }
        if (y == 0 || y == height - 1)
        {
            y_direction *= -1;
        }
        this_thread::sleep_for(chrono::milliseconds(50));
    }
    return 0;
}
