#include <iostream>
#include <cmath>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

using namespace std;

int main(int argc, char *argv[]) {

	string passwd;

	cout << "請輸入密碼 :";
	cin >> passwd;

//寫法一	
	if (passwd=="0123")
	{
		cout << "Welcome！"; 
	}
	
	if (passwd!="0123")
	{
		cout << "Error！\n"; 
		cout << "Input again！\n"; 
	}
	
//寫法二 
	if (passwd=="0123")
	{
		cout << "Welcome！"; 
	}
	else
	{
		cout << "Error！\n"; 
		cout << "Input again！\n"; 
	}

	return 0;
}





