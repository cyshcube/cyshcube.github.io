#include <iostream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;

int main(int argc, char *argv[]) {

	int i,sum=1,n;

	cout << "½Ð¿é¤Jn¡A¨Dn!:";	
	cin >> n;
	
	for(i=1;i<=n;i++)
	{
		sum=sum*i;
//		sum+=i;
//		sum+=i*i;
	}
	cout << sum;

	return 0;
}






