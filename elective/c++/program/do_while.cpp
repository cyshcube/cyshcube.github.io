#include <iostream>
#include <cstdlib>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

using namespace std;

int main(int argc, char *argv[]) {

	string passwd;

	do
	{
		cout << "�п�J�K�X�G";	
		cin >> passwd;
	}while(passwd!="1234");

	cout << "�K�X���T�A�}�l�ϥ�";

	return 0;
}






/*
	int math;

	cout << "�п�J�ƾǦ��Z�G ";
	
	cin >> math;
	
	cout << math;
*/

/*

	float r,area,cir;
	const float pi=3.14159;

	cout << "�п�J��b�|�G ";
	
	cin >> r;

	area=pi*r*r;
	
	cir=2*pi*r;

	cout << "�ꭱ�n���G" << area << " ��P����" << cir;

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
	
	cout << "�п�Ja b c :";
	cin >> a >> b >> c;
	
	x=(-b+sqrt(b*b-4*a*c))/(2*a);
	
	cout << x;
*/

/*
 
	int age;

	cout << "�п�J�~�� :";
	cin >> age;
	
	if(age>=18 && age<=65)  //18<=age<=65
	{
		cout<< "Welcome";
	}
	else
	{
		if(age<18)
		{
			cout <<"���j�A��\n";	
		}
		else
		{
			cout <<"�U���l�A��\n";	
		}
		
	}
*/	

/*
	int age;

	cout << "�п�J�~�� :";
	cin >> age;
	
	if(age<18 || age>65) 
	{
		if(age<18)
		{
			cout <<"���j�A��\n";	
		}
		else
		{
			cout <<"�U���l�A��\n";	
		}
	
	}
	else
	{
		cout<< "Welcome";
		
	}
*/	

/*
	int age;

	cout << "�п�J�~�� :";
	cin >> age;
	
	if(age<18) 
	{
		cout <<"���j�A��\n";		
	}
	else
	{
		if(age<=65)
		{
			cout<< "Welcome";
		}
		else
		{
			cout <<"�U���l�A��\n";	
		}
	}
*/


/*
	int i,x,y,sum=1;
	
	cout << "�п�Jx,y:";
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
			cout << "�п�J�P�� " << i << " ����O:";	
		}
		else
		{
			cout << "�п�J�P���骺��O:";	
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
		
		cout << endl; //���� 
	}


	int i=0,m,sum=0;

	while(sum<30000)
	{
		i++;
		cout << "�п�J�� " << i << " �Ӥ몺�s��:";	
		cin >> m;
		sum=sum+m;
	}
	cout << "�s�F " << i << " �Ӥ�A�`�@ " << sum;

*/
