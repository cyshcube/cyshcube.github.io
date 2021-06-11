#include <cstdlib>
#include <iostream>

using namespace std;

int sayhello(int n)
{
	int i,type;
	for (i=0;i<n;i++)
		cout << "Welcome!";
		
	cout << "請問要點些什麼？(1.紅茶 2.綠茶 3.可可)"; 
	cin >>type; 
	
	return type;
}

void process(int order)
{
	if (order==1)
		cout << "紅茶馬上好";
	else if (order==2)
	 	cout << "綠茶馬上好";
	else
		cout << "可可馬上好";
}

int main(int argc, char *argv[])
{
	int order;
	order=sayhello(10);
	process(order);

	system("pause");
	return 0;
}

