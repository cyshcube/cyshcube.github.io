#include <iostream>
#include <cstdlib>
/* run this program using the console pauser or add your own getch, system("pause") or input loop */

using namespace std;

int main(int argc, char *argv[]) {

	int s[2][3],i,j;
	string subname[3]={"���","�^��","�ƾ�"};
	
	for (i=0;i<2;i++)	
	{
		for (j=0;j<3;j++)
		{
			cout << "�п�J " << i+1 << " ���� " << subname[j] << " ���Z:"; 
			cin >> s[i][j];
		}
	}
	



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


