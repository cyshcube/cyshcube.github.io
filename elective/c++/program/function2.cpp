#include <iostream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;

void sayhello(int n)
{
	int i;
	
	for (i=0;i<n;i++)
	{
		cout << "Welcome ";	
	}
	
}

int main(int argc, char *argv[]) {
	
	sayhello(10);
	
	return 0;
}


/*
n
4	9-2*i
5	11-2*i

********* 
-*******-
--*****--
---***---
----*----

i	-	* 
1	0	7 9
2	1	5 7
3	2	3 5
4	3	1 3
          1

	int math;
	
	cout << "�п�J�ƾǦ��Z�G";
	
	cin >> math;
	
	cout << math;
	
*/

/*

	float r,area,len;
	const float pi=3.14159;
	
	cout << "�п�J�b�|�G";
	
	cin >> r;
	
	area=pi*r*r;

	len=2*pi*r;
		
	cout << "�ꭱ�n���G" << area << "��P�����G" << len;
*/

/*
int e=2150,b=100,x=10,y=10,g,r;
	
	e=e+100;
	e+=100;
	
	b=b-5;
	b-=5;

	x=x+1;
	x+=1;
	x++;
	
	y=y-1;
	y--;
	
	g=e/100;
	
//	if ( g*5 >= 20 || stone>=10000 )
	
	r=e%100;
	
	cout << e << "\n " << b << "\n " << x << " " << y << " " << g << " " << r;
*/	

/*
	float a,b,c,x;
	
	cout << "�п�J a b c :";

	cin >> a >> b >> c;

	x=(-b+sqrt(b*b-4*a*c)) / (2*a);

	cout << x;	
*/

/*

	int age;
	
	cout << "�п�J�~�֡G";
	cin >> age;

	if(age>=18 && age<=65)
	{
		cout << "Welcome";
	}
	else
	{
		if (age<18)
		{
			cout << "���j�A��\n";	
		}
		else
		{
			cout << "�U���l�A��\n";
		}
		
	}

*/

/*
	int age;
	
	cout << "�п�J�~�֡G";
	cin >> age;

	if(age<18 || age>65)
	{
		if (age<18)
		{
			cout << "���j�A��\n";	
		}
		else
		{
			cout << "�U���l�A��\n";
		}

	}
	else
	{
		cout << "Welcome";
		
	}
*/	

/*
	int age;
	
	cout << "�п�J�~�֡G";
	cin >> age;

	if(age<18)
	{
		cout << "���j�A��\n";	
	}
	else
	{
		if (age<=65)
		{
			cout << "Welcome";	
		}
		else
		{
			cout << "�U���l�A��\n";
		}

	}
*/
/*
	float a,b,c,s,area,x1,x2;
	
	cout << "�п�J a b c :";
	cin >> a >> b >> c;	
	
	if(a+b>c && b+c>a && a+c>b) 
	{
		s=(a+b+c)/2;
		area=sqrt(s*(s-a)*(s-b)*(s-c));
		cout << area;
	}
	else
	{
		cout << "���O�T����";		
	}

	
	cout << "�п�J a b c :";

	cin >> a >> b >> c;
	
	if(b*b-4*a*c>=0)
	{
		x1=(-b+sqrt(b*b-4*a*c)) / (2*a);
		x2=(-b-sqrt(b*b-4*a*c)) / (2*a);

		if(b*b-4*a*c==0)
		{
			cout << "������:" <<x1;	
		}
		else
		{
			cout << x1 << " " << x2;	
		}
	}
	else
	{
		cout << "�S����";
	}
	
*/		

/*
	int i,m,sum=0;
	
	for(i=1;i<=7;i++)
	{
		if(i<=6)
		{
			cout << "�п�J�P�� " << i << " ����X�G";	
		}	
		else
		{
			cout << "�п�J�P���骺��X�G";	
		}	
		cin >> m;
		sum=sum+m;

	}
	cout << "�`�@��F" << sum << endl;		
	
*/	

/*
	int i,j;
	
	for(i=1;i<=5;i++)
	{
		for (j=1;j<=5-i;j++)
		{
			cout << "-";
		}
		
		for (j=1;j<=2*i-1;j++)
		{
			cout << "#";
		}
		cout << endl;
	}
	
	string passwd;
	int i=0;
	
	do
	{
		cout << "�п�J�K�X�G";	
		cin >> passwd;
		i++;
		if(i==3)
		{
			break;
		}
	}while(passwd!="1234");  //�� �K�X��  ��  ���Ƥp��3 
	
	if(passwd=="1234")
	{
		cout << "welcome "; 	
	}
	else
	{
		cout << "110 ";
	}	
	
	
*/

/*
	int i,j,n,a,b,c;
	float sum=0,h;

	cout << "�п�Jn�G";
	cin >> n;	

	for (i=1;i<=n;i++)
	{
		sum=sum+1/(float)(i*i);
	}

	cout << sum;

	for (i=100;i<=999;i++)
	{
		a=i/100;
		b=i%100/10;  //i/10%10   i/10-10*a	 (i-100*a)/10
		c=i%10;	
		if(i == a*a*a + b*b*b + c*c*c)
		{
			cout << i <<" " ;
		}
	}

	cout << "�п�Jn�G";
	cin >> n;	

	for(i=1;i<=n;i++)
	{
		for (j=1;j<=i-1;j++)
		{
			cout << "-";
		}
		
		for (j=1;j<=2*n+1-2*i;j++)
		{
			cout << "*";
		}
		cout << endl;
	}	

	cout << "�п�J�𰪡G";
	cin >> h;
	
	do
	{
		sum=sum+h;
		h=h/2;
	}while(h>=0.5);
	
	cout << sum;
	
		int s[5],i;
	float sum=0,ave;

	for (i=0;i<5;i++) // 0 1 2 3 4
	{
		cout << "�п�J " << i+1 <<" �������Z:";
		cin >> s[i];
	}

	for (i=0;i<5;i++) // 0 1 2 3 4
	{
		sum=sum+s[i];
	}
	ave=sum/5;

	for (i=0;i<5;i++) // 0 1 2 3 4
	{
		cout << s[i] << " ";
	}
	cout << "�`��=" << sum << " ����="<< ave; 

	
*/		

/*
	int s[5]={6,4,9,8,3},i,j,t;
	float sum=0,ave;

	cout << "�Ƨǫe�G"; 
	for (i=0;i<5;i++) // 0 1 2 3 4
	{
		cout << s[i] << " ";
	}
	
	for(i=0;i<4;i++)	
	{
		for (j=0;j<4-i;j++) // 0 1 2 3 
		{
			if(s[j]>s[j+1])
			{	
				t=s[j];
				s[j]=s[j+1];
				s[j+1]=t;
			}
		}
	}

	cout << endl << "�Ƨǫ�G"; 
	for (i=0;i<5;i++) // 0 1 2 3 4
	{
		cout << s[i] << " ";
	}
*/

/*
	int num[10]={256,731,943,389,142,645,829,945,371,418},s,i,flag=0,n;
	string name[10]={"�L�p��","������","�����","���j�P","���l��","�G���R","���ŬX","���Ӧh","��Ѩ}","�d���~"};
	bool found=false;

	cout << "�п�J�������X�G";
	cin >> s;
	
	for (i=0;i<10;i++)
	{
		if(s==num[i])
		{
			found=true;
			n=i;
		}
	}

	if(found)
	{
		cout << name[n];
	}
	else
	{
		cout << "�S�H����"; 
	}
*/

/*
	int s[2][3],i,j,rank[2];
	string subname[3]={"���","�^��","�ƾ�"};
	float sum[2],ave[2];
	
	for (i=0;i<2;i++)
	{
		for (j=0;j<3;j++)
		{
			cout << "�п�J " << i+1 << " ���� "<< subname[j] << " �쪺���Z"; 
			cin >> s[i][j];
		}
	}

	for (i=0;i<2;i++)
	{
		sum[i]=0;			
		for (j=0;j<3;j++)
		{
			sum[i]+=s[i][j];
		}
		ave[i]=sum[i]/3;		
	}

	for (i=0;i<2;i++) 
	{
		rank[i]=1;
		for (j=0;j<2;j++)
		{
			if(sum[j]>sum[i])
			{
				rank[i]++;
			}
		}
	}
	 
	for (i=0;i<2;i++)
	{
		for (j=0;j<3;j++)
		{
			cout << s[i][j] << " ";
		}
		cout << sum[i] << " " <<ave[i] << " "  << rank[i] << endl;
	}
*/
