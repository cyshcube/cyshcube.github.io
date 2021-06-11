#include <iostream>

using namespace std;

int a(int n)
{
	if (n==1)
		return 5;	
	else
		return a(n-1)+3*n+2;
}

int main(int argc, char *argv[]) {

	int n;
	cin >> n;
	cout << a(n);

	return 0;
}



