#include <iostream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;

int main(int argc, char *argv[]) {

	int i,sum=0,m;
	
	for(i=1;i<=7;i++)
	{
		if (i<=6)
		{
			cout << "�п�J�P�� " << i << " ����X:"; 
		}
		else
		{
			cout << "�п�J�P���骺��X:"; 			
		}
		cin >> m;
		sum=sum+m;
	}
	cout << "���P������X���G" << sum;

	return 0;
}






