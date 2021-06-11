#include <iostream>
#include <cstdlib>

using namespace std;
/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	float r,area,circumference;
	const float PI=3.14;
	
	cout << "請輸入圓半徑："; 
	
	cin >> r;
	
	area=PI*r*r;
	
	circumference=2*PI*r;
	
	cout << "圓面積為" << area << " 周長為" << circumference; 

	system("pause"); 
	return 0;
}


