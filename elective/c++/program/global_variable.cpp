#include <iostream>
#include <cstdlib>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

using namespace std;

int a,b;

void swap()
{
	int t;
	
	t=a;
	a=b;
	b=t;
}

void other()
{
//	int a;
	for (a=0;a<10;a++)
	{
		
	}
}

int main(int argc, char *argv[]) {
	
	cin >> a >> b;
	
	cout << "交換前:"  << a << " " << b  << endl;
	
	swap();
	other();
	
	cout << "交換後:"  << a << " " << b  << endl;
	
	return 0;
}



