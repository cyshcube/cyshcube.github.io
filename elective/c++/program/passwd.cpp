#include <iostream>
#include <cmath>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

using namespace std;

int main(int argc, char *argv[]) {

	string passwd;

	cout << "�п�J�K�X :";
	cin >> passwd;

//�g�k�@	
	if (passwd=="0123")
	{
		cout << "Welcome�I"; 
	}
	
	if (passwd!="0123")
	{
		cout << "Error�I\n"; 
		cout << "Input again�I\n"; 
	}
	
//�g�k�G 
	if (passwd=="0123")
	{
		cout << "Welcome�I"; 
	}
	else
	{
		cout << "Error�I\n"; 
		cout << "Input again�I\n"; 
	}

	return 0;
}





