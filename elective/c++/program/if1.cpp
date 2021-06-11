#include <iostream>
#include <cmath>

using namespace std;
/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int age; 
	
	cout << "請輸入年齡:";	
	cin >> age;
	
	if (age>=18 && age<=65)
	{
		cout << "Welcome!\n";
	}
	else
	{  
		if(age<18)
		{
			cout << "長大再來!\n";	
		}
		else
		{
			cout << "下輩子再來!\n";				
		}
	}

	return 0;
}

/*
	float r,area,len;
	const float pi=3.14159;
	
	cout << "請輸入圓半徑:";
	
	cin >> r;
	
	area=pi*r*r;
	
	len=2*pi*r;
	
	cout << "圓面積為：" << area << " 周長為：" << len;
*/

/*
	int e=2150,b=100,x=10,y=10,g,r;
	
	e=e+100;
	e+=100;
	
	b=b-5;
	b-=5;
	
	x=x+1;
	x++;
	
	y=y-1;
	y--;
	
	g=e/100;
	r=e%100;
	
	if ( (g>=20) && key==1 )
	
	x=((a+b)*c); 
	
	cout << e << " " << b << " " << x << " " << y << " " << g << " " << r;
*/

/*
	float a,b,c,x;
	
	cout << "請輸入a,b,c:";
	
	cin >> a >> b >> c;
	
	x=(-b+sqrt(b*b-4*a*c))/(2*a);
	
	cout << x;
*/	

/*
	string pwd; 
	
	cout << "請輸入密碼:";	
	cin >> pwd;
	
	if (pwd=="0123")
	{
		cout << "Welcome ";
	}
	else
	{
		cout << "Error!\n";
		cout << "Input Again ";
	}
*/
