#include <iostream>
#include <cstdlib>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

using namespace std;

int f(int n)
{
	int sum=1,i;
	
	for (i=1;i<=n;i++)
	{
		sum=sum*i;
	}
	
	return sum;
}

int main(int argc, char *argv[]) {

	int m,n;
	
	cout << "½Ð¿é¤Jm,n:"; 
	cin >> m >> n;
	
	cout << f(m)/(f(n)*f(m-n));
	
	return 0;
}


