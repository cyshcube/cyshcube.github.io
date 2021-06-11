#include <iostream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;

int main(int argc, char *argv[]) {

	int i,j;
	
	for(i=1;i<=9;i++)
	{
		for (j=1;j<=9;j++)
		{
			cout << i << "*" << j << "=" << i*j << "\t";
		}
		cout << endl;
	}

	return 0;
}



