#include <iostream>
#include <cstdlib>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

using namespace std;

int main(int argc, char *argv[]) {

	string passwd;
	int i=0;

	do
	{
		cout << "�п�J�K�X�G";	
		cin >> passwd;
		i++;
	}while(passwd!="1234" && i<3);  //��(�K�X�� �ӥB ���Ƥp��3��) 

	if (passwd=="1234")
	{
		cout << "�K�X���T�A�}�l�ϥ�";	
	}
	else
	{
		cout << "110!";			
	}
	

	return 0;
}

/*
	string pwd,user;
	int i=0;

	do
	{
		cout << "�п�J�b��:";	
		cin >> user;		
		cout << "�п�J�K�X:";	
		cin >> passwd;		
		i++;
	}while((user!="cysh" || passwd!="1234") && i<3); 
	
	if(passwd=="1234")
	{
		cout << "�K�X���T�A�}�l�ϥ�";
	}
	else
	{
		cout << "110!";	
	}
*/


