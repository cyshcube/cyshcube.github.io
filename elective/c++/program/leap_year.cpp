#include <cstdlib>
#include <iostream>

using namespace std;

int main(int argc, char *argv[])
{
    int y;
    
    cout << "¦è¤¸¡G" ;
    cin >> y;

    if(y%4==0)
    {
        if (y%100==0)
        {
            if(y%400==0)
            {
                   cout << y << " ¬O¶|¦~" << endl;
            }
            else
            {
                   cout << y << " ¤£¬O¶|¦~" << endl;                
            }

        }
        else
        {
            cout << y << " ¬O¶|¦~" << endl; 
        }

    }
    else
    {
        cout << y << " ¤£¬O¶|¦~" << endl;         
    }

    system("PAUSE");
    return EXIT_SUCCESS;
}


