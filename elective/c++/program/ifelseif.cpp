#include <iostream>
#include <cmath>

using namespace std;
/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	int age;
	
	cout << "請輸入年齡:";
	cin >> age;
	
	if(age<6)
	{
		cout << "你可以看普遍級!";	
	}
	else if(age<12)
	{
		cout << "你可以看保護級!";
	}	
	else if(age<18)
	{
		cout << "你可以看輔導級!";
	}
	else
	{
		cout << "你可以看限制級！";
	}
	
	return 0;
}


