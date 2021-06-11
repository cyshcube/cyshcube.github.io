#include <iostream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;

int main(int argc, char *argv[]) {

	int i,s[5]={6,4,9,8,3},t;

	cout<<"排序前："; 
	for (i=0;i<5;i++)
	{
		cout << s[i] << " ";
	}	

	t=s[0];
	s[0]=s[1];
	s[1]=t;

	cout << endl <<"排序後：";
	for (i=0;i<5;i++)
	{
		cout << s[i] << " ";
	}	

	return 0;
}


