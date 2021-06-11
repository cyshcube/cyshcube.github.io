#include <cstdlib>
#include <iostream>

using namespace std;

int main(int argc, char *argv[])
{
    int i,j;

    for(i=1;i<=5;i++)
    {
       for (j=1;j<=5-i;j++)	// for(j=i;j<=4;j++)
       {					// for (j=4;j>=i;j--)
          cout << " ";		// for (j=5-i;j>=1;j--)
       }
       for (j=1;j<=2*i-1;j++)
       {
          cout << "*";
       }
       cout << endl;       
    }
    system("PAUSE");
    return EXIT_SUCCESS;
}

/*
i * -
1 1 4  ----*
2 3 3  ---***
3 5 2  --*****
4 7 1  -*******
5 9 0  *********

for (j=1;j<=5-i;j++)
1234
123
12
1

for(j=i;j<=4;j++)
1234
234
34
4

for (j=4;j>=i;j--)
4321
432
43
4

for (j=5-i;j>=1;j--)
4321
321
21
1
*/

