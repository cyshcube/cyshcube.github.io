#include <iostream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

using namespace std;

int main(int argc, char *argv[]) {
	
	 int math; 	// short			2bytes	-32768~32767
				// int				4bytes	-2147483648~2147483647
				// long long int 	8bytes	-9223372036854775808~9223372036854775807
				// unsigned int 	4bytes	0~4294967295	不能存負數，但正數範圍多一倍 
				// float 			4bytes	才可以存小數
				// double			8bytes
					
	cout << "請輸入數學成績";
	
	cin >> math;
	
	cout << math;

	return 0;
}


