#include <cstdlib>
#include <iostream>

using namespace std;

int main(int argc, char *argv[])
{
    int y;
    
    cout << "西元：" ;
    cin >> y;

    if(y%4==0)
    {
        if (y%100==0)
        {
            if(y%400==0)
            {
                   cout << y << " 是閏年" << endl;
            }
            else
            {
                   cout << y << " 不是閏年" << endl;                
            }

        }
        else
        {
            cout << y << " 是閏年" << endl; 
        }

    }
    else
    {
        cout << y << " 不是閏年" << endl;         
    }

    system("PAUSE");
    return EXIT_SUCCESS;
}


