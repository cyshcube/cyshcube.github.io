#include <iostream>
#include <cmath>

using namespace std;
/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	float a,b,c,x;
	
	cout << "½Ð¿é¤Ja,b,c:";
	
	cin >> a >> b >> c;
	
	x=(-b+sqrt(b*b-4*a*c))/(2*a);
	
	cout << x;
	
	return 0;
}


