#include <iostream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;

int main(int argc, char *argv[]) {

	int num[10]={256,731,943,389,142,645,829,945,371,418},s,i;
	string name[10]={"�L�p��","������","�����","���j�P","���l��","�G���R","���ŬX","���Ӧh","��Ѩ}","�d���~"};

	cout << "�п�J�������X�G";
	cin >> s;
	
	for (i=0;i<10;i++)
	{
		if(s==num[i])
		{
			cout << name[i];
		}
		else
		{
			cout << "�S�H�� "; 
		}
	}
	 
	return 0;
}


