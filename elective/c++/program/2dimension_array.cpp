#include <iostream>
/* run this program using the console pauser or add your own getch, system("pause") or input loop */

using namespace std;

int main(int argc, char *argv[]) {

	int s[2][3],i,j;
	string subname[3]={"���","�^��","�ƾ�"};
	float sum[2],ave[2];
	
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
		sum[i]=0;
		for (j=0;j<3;j++)
		{
			sum[i]=sum[i]+s[i][j];
		}
		ave[i]=sum[i]/3;
	}

	for (i=0;i<2;i++)	
	{
		for (j=0;j<3;j++)
		{
			cout << s[i][j] << " ";
		}
		cout << sum[i] << " " << ave[i] << endl;
	}
	
	return 0;
} 





