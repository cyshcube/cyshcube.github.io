#include <cstdlib>
#include <iostream>

using namespace std;

int main(int argc, char *argv[])
{
    int e=2150,b=100,x=10,y=10,g,r;
    
    e=e+100;
    e+=100;

    b=b-5;
    b-=5;

    x=x+1;
    x++;

    y=y-1;
    y--;

    g=e/100;
    r=e%100;
    
    cout << e << " " << b << " " << x << " " << y << " " << g << " " << r;
    
    system("PAUSE");
    return EXIT_SUCCESS;
}

