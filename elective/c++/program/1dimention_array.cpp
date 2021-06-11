#include <iostream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;

int main(int argc, char *argv[]) {

	int s[5],i;
	float sum=0,ave;

	for (i=0;i<5;i++)
	{
		cout << "請輸入" << i+1 << "號的成績:";
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
	cout << "總分=" << sum << " 平均=" << ave; 
	
	return 0;
}
