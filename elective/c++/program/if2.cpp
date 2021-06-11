#include <iostream>
#include <cstdlib>
#include <cmath>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

using namespace std;

int main(int argc, char *argv[]) {

	int age;

	cout << "請輸入年齡:";
	cin >> age;
	
	if(age<18 || age>65)		
	{
		if(age<18)
		{
			cout << "長大再來";	
		}
		else
		{
			cout << "下輩子再來";		
		}

	}
	else
	{
		cout << "Welcome";
		cout << "會員專區"; 
	}
	
	if(age<18)
	{
		cout << "長大再來";	
	}
	else
	{
		if(age<=65)
		{
			cout << "Welcome";
			cout << "會員專區"; 			
		}
		else
		{
			cout << "下輩子再來";	
		}
	}

	//system("pause");
	return 0;
}

/*


---
	long double a;
	
	cin >> a;
	
	cout << a;
---
	char x='A';
	char y=65;
	
	cout << x;
	cout << y;
	
	cout << x+32;
	cout << y+32;

	cout << (char)(x+32);

---
	int math=0,eng=0,sum;
	float ave;
	
	cout << "hello!" << endl << "小王"; 
	
	cout << "請輸入數學、英文成績:";
	
	cin >> math >> eng;
	
	sum=math+eng;
	
	ave=(float)sum/2;

	cout << "總分為：" << sum << " 平均為" << ave; 	
---
	float r,area,cir;
	const float PI=3.14159;

	cout << "請輸入半徑:";
	
	cin >> r;

	area=PI*r*r;
	
	cir=2*PI*r;
	
	cout << "面積為：" << area << " 圓周長為" << cir;	
---
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

	if( g>=20 || key==1 )
	{
		
	}
	cout << e << " " << b << " " << x << " " << y << " " << g << " " << r;	
---
	float a,b,c,x;
	
	cin >> a >> b >> c;
	
	x=(-b+sqrt(b*b-4*a*c))/(2*a);
	
	cout << x;
---
	int age;

	cout << "請輸入年齡:";
	cin >> age;
	
	if(age>=18 && age<=65)		
	{
		cout << "Welcome";
		cout << "會員專區"; 
	}
	else // <18  >65
	{
		if(age<18)
		{
			cout << "長大再來";	
		}
		else
		{
			cout << "下輩子再來";		
		}
		
	}	
	
*/	
