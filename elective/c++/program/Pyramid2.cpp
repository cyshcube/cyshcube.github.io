#include <cstdlib>
#include <iostream>
#include <cmath>

using namespace std;

int main(int argc, char *argv[])
{
    int i,j,n;
    
    cin >> n;

    for (i=1;i<=n;i++)
    {
        for(j=1;j<=2*n-1;j++)
        {
          if (j>n-i && j<n+i)
             cout << "*";
          else
             cout << " ";
        }
        cout << endl;
    }    
 
    system("PAUSE");
    return EXIT_SUCCESS; 

}
