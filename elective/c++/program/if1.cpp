#include <iostream>
#include <cmath>

using namespace std;
/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int age; 
	
	cout << "�п�J�~��:";	
	cin >> age;
	
	if (age>=18 && age<=65)
	{
		cout << "Welcome!\n";
	}
	else
	{  
		if(age<18)
		{
			cout << "���j�A��!\n";	
		}
		else
		{
			cout << "�U���l�A��!\n";				
		}
	}

	return 0;
}

/*
	float r,area,len;
	const float pi=3.14159;
	
	cout << "�п�J��b�|:";
	
	cin >> r;
	
	area=pi*r*r;
	
	len=2*pi*r;
	
	cout << "�ꭱ�n���G" << area << " �P�����G" << len;
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
	
	cout << "�п�Ja,b,c:";
	
	cin >> a >> b >> c;
	
	x=(-b+sqrt(b*b-4*a*c))/(2*a);
	
	cout << x;
*/	

/*
	string pwd; 
	
	cout << "�п�J�K�X:";	
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
