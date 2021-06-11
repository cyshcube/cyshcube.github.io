#include <iostream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;

int main(int argc, char *argv[]) {

	int i,sum=0,m;
	
	for(i=1;i<=7;i++)
	{
		if (i<=6)
		{
			cout << "請輸入星期 " << i << " 的支出:"; 
		}
		else
		{
			cout << "請輸入星期日的支出:"; 			
		}
		cin >> m;
		sum=sum+m;
	}
	cout << "本星期的支出為：" << sum;

	return 0;
}






