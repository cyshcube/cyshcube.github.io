#include <iostream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;

int main(int argc, char *argv[]) {

	int s[2][3]={{60,70,80},{70,80,90}},i,j; //2�H 3�� 
	
	for (i=0;i<2;i++)
	{
		for (j=0;j<3;j++)
		{
			cout << s[i][j] << " ";
		}
		cout << endl;		
	}
	
	return 0;
}


