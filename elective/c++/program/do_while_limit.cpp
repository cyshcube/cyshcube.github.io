#include <iostream>
#include <cstdlib>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

using namespace std;

int main(int argc, char *argv[]) {

	string passwd;
	int i=0;

	do
	{
		cout << "請輸入密碼：";	
		cin >> passwd;
		i++;
	}while(passwd!="1234" && i<3);  //當(密碼錯 而且 次數小於3次) 

	if (passwd=="1234")
	{
		cout << "密碼正確，開始使用";	
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
		cout << "請輸入帳號:";	
		cin >> user;		
		cout << "請輸入密碼:";	
		cin >> passwd;		
		i++;
	}while((user!="cysh" || passwd!="1234") && i<3); 
	
	if(passwd=="1234")
	{
		cout << "密碼正確，開始使用";
	}
	else
	{
		cout << "110!";	
	}
*/


