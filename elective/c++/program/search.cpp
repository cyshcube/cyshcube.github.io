#include <iostream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;

int main(int argc, char *argv[]) {

	int num[10]={256,731,943,389,142,645,829,945,371,418},s,i;
	string name[10]={"�L�p��","������","�����","���j�P","���l��","�G���R","���ŬX","���Ӧh","��Ѩ}","�d���~"};
	bool isFound=false;

	cout << "�п�J�������X�G";
	cin >> s;
	
	for (i=0;i<10;i++)
	{
		if(s==num[i])
		{
			isFound=true;
			break;
		}
	}
	
	if (isFound==true)
	{
		cout << name[i];
	}
	else
	{
		cout << "�S�H�����I"; 
	}
	 
	return 0;
}


