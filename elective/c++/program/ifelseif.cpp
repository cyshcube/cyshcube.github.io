#include <iostream>
#include <cmath>

using namespace std;
/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	int age;
	
	cout << "�п�J�~��:";
	cin >> age;
	
	if(age<6)
	{
		cout << "�A�i�H�ݴ��M��!";	
	}
	else if(age<12)
	{
		cout << "�A�i�H�ݫO�@��!";
	}	
	else if(age<18)
	{
		cout << "�A�i�H�ݻ��ɯ�!";
	}
	else
	{
		cout << "�A�i�H�ݭ���šI";
	}
	
	return 0;
}


