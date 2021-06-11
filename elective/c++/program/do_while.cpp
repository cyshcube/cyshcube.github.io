#include <iostream>
#include <cstdlib>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

using namespace std;

int main(int argc, char *argv[]) {

	string passwd;

	do
	{
		cout << "請輸入密碼：";	
		cin >> passwd;
	}while(passwd!="1234");

	cout << "密碼正確，開始使用";

	return 0;
}






/*
	int math;

	cout << "請輸入數學成績： ";
	
	cin >> math;
	
	cout << math;
*/

/*

	float r,area,cir;
	const float pi=3.14159;

	cout << "請輸入圓半徑： ";
	
	cin >> r;

	area=pi*r*r;
	
	cir=2*pi*r;

	cout << "圓面積為：" << area << " 圓周長為" << cir;

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
	
//	if ( g+2 >= 20 || key == 1 )
	
	r=e%100;
	
	cout << " " << e << " " << b << " " << x << " " << y << " " << g << " " << r;
*/

/*
	float a,b,c,x;
	
	cout << "請輸入a b c :";
	cin >> a >> b >> c;
	
	x=(-b+sqrt(b*b-4*a*c))/(2*a);
	
	cout << x;
*/

/*
 
	int age;

	cout << "請輸入年齡 :";
	cin >> age;
	
	if(age>=18 && age<=65)  //18<=age<=65
	{
		cout<< "Welcome";
	}
	else
	{
		if(age<18)
		{
			cout <<"長大再來\n";	
		}
		else
		{
			cout <<"下輩子再來\n";	
		}
		
	}
*/	

/*
	int age;

	cout << "請輸入年齡 :";
	cin >> age;
	
	if(age<18 || age>65) 
	{
		if(age<18)
		{
			cout <<"長大再來\n";	
		}
		else
		{
			cout <<"下輩子再來\n";	
		}
	
	}
	else
	{
		cout<< "Welcome";
		
	}
*/	

/*
	int age;

	cout << "請輸入年齡 :";
	cin >> age;
	
	if(age<18) 
	{
		cout <<"長大再來\n";		
	}
	else
	{
		if(age<=65)
		{
			cout<< "Welcome";
		}
		else
		{
			cout <<"下輩子再來\n";	
		}
	}
*/


/*
	int i,x,y,sum=1;
	
	cout << "請輸入x,y:";
	cin >> x >> y;
	
	for(i=1;i<=y;i++)
	{
		sum=sum*x;
	}

	cout << sum;	
*/

/*
	int i,sum=0,m;
	
	for(i=1;i<=7;i++)
	{
		if(i<=6)
		{
			cout << "請輸入星期 " << i << " 的花費:";	
		}
		else
		{
			cout << "請輸入星期日的花費:";	
		}

		cin >> m;
		sum=sum+m;
		
	}

	cout << sum;
*/	

/*	int i,j;
	
	for(i=1;i<=5;i++)
	{
		for(j=1;j<=5-i;j++)
		{
			cout << " ";	
		}
		
		for(j=1;j<=2*i-1;j++)				
		{
			cout << "#";
		}
		
		cout << endl; //換行 
	}


	int i=0,m,sum=0;

	while(sum<30000)
	{
		i++;
		cout << "請輸入第 " << i << " 個月的存款:";	
		cin >> m;
		sum=sum+m;
	}
	cout << "存了 " << i << " 個月，總共 " << sum;

*/
