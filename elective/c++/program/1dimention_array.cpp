#include <iostream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;

int main(int argc, char *argv[]) {

	int s[5],i;
	float sum=0,ave;

	for (i=0;i<5;i++)
	{
		cout << "�п�J" << i+1 << "�������Z:";
		cin >> s[i];
	}

	for (i=0;i<5;i++)
	{
		sum=sum+s[i];
	}
	ave=sum/5;	

	for (i=0;i<5;i++)
	{
		cout << s[i] << " ";
	}
	cout << "�`��=" << sum << " ����=" << ave; 
	
	return 0;
}
