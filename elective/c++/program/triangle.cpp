#include <iostream>
#include <cstdlib>
/* run this program using the console pauser or add your own getch, system("pause") or input loop */

using namespace std;

int main(int argc, char *argv[]) {
	int i,j;
	
	for(i=1;i<=5;i++)
	{
		for (j=1;j<=i;j++)
		{
			cout << "*";
		}

		cout << endl;
	}

	return 0;
}


