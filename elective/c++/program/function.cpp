#include <cstdlib>
#include <iostream>

using namespace std;

int sayhello(int n)
{
	int i,type;
	for (i=0;i<n;i++)
		cout << "Welcome!";
		
	cout << "�аݭn�I�Ǥ���H(1.���� 2.��� 3.�i�i)"; 
	cin >>type; 
	
	return type;
}

void process(int order)
{
	if (order==1)
		cout << "�������W�n";
	else if (order==2)
	 	cout << "������W�n";
	else
		cout << "�i�i���W�n";
}

int main(int argc, char *argv[])
{
	int order;
	order=sayhello(10);
	process(order);

	system("pause");
	return 0;
}

