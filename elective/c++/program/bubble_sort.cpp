#include <iostream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;

int main(int argc, char *argv[]) {

	int i,j,s[5]={6,4,9,8,3},t;

	cout<<"�Ƨǫe�G"; 
	for (i=0;i<5;i++)
	{
		cout << s[i] << " ";
	}	

	for (i=0;i<4;i++)
	{
		for (j=0;j<4-i;j++)
		{
			if(s[j]>s[j+1])
			{
				t=s[j];
				s[j]=s[j+1];
				s[j+1]=t;
			}
		}
	}

	cout << endl <<"�Ƨǫ�G";
	for (i=0;i<5;i++)
	{
		cout << s[i] << " ";
	}	

	return 0;
}






/*
	int age;
	
	cout << "�п�J�~�֡G";
	cin >> age;
             
	if( age>=18 && age<=65) 
	{
		cout << "Welcome!";
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
*/

/*
	int age;
	
	cout << "�п�J�~�֡G";
	cin >> age;
             
	if( age<18 || age>65)  
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
	else
	{
		cout << "Welcome!";
	}
*/	

/*
	
	int age;
	
	cout << "�п�J�~�֡G";
	cin >> age;
             
	if(age<18)  
	{
		cout << "���j�A��!\n";				
	}
	else
	{
		if(age<=65)
		{
			cout << "Welcome;!";
		}
		else
		{
			cout << "�U���l�A��!\n";
		}
	}
*/


/*

	float a,b,c,s,area,x1,x2;
	
	cout <<"�п�Ja,b,c:(space)";
	cin >> a >> b >> c;
	s=(a+b+c)/2;
	area=sqrt(s*(s-a)*(s-b)*(s-c));
	
	cout << area;

		
	cout <<"�п�Ja,b,c:(space)";
	cin >> a >> b >> c;

	if(b*b-4*a*c>=0)
	{
		x1= (-b + sqrt(b*b-4*a*c) ) / (2*a);
		x2= (-b - sqrt(b*b-4*a*c) ) / (2*a);	

		if(b*b-4*a*c==0)
		{
			cout << x1;	
		}
		else
		{
			cout << x1 << " " << x2;
		}
	}
	else
	{
		cout << "�S���";	
	}
*/

/*

	int i,m,sum=0;
	
	
	for(i=1;i<=7;i++)
	{
		if(i<=6)
		{
			cout << " �п�J�P�� " << i << " ����O:";	
		}
		else
		{
			cout << " �п�J�P���骺��O:";	
		}
		
		cin >> m; 
		sum=sum+m;
	}
	
	cout <<sum;
*/	
/*
	int i,j;
	
	for(i=1;i<=5;i++)
	{
		for(j=1;j<=5-i;j++)
		{
			cout << "-";
		}

		for(j=1;j<=2*i-1;j++)
		{
			cout << "#";
		}
		cout << endl;
	}
	*/
	/*
		string passwd;
	int i=0;

	do
	{
		cout << " �п�J�K�X�G";	
		cin >> passwd; 
		i++;
	}while(passwd!="1234" && i<3);//��(�K�X�� �B ���Ƥp��3 ) 
	
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
	int i,n;
	float sum=0;
	
	cin >> n;

	for (i=1;i<=n;i++)
	{
		sum=sum+(float)1/(i*i);
	}
	cout << sum;
*/		

/*	int i,a,b,c;
	
	for (i=100;i<=999;i++)
	{
		//153   1  5  3
		a=i/100;
		b=(i-100*a)/10;  // b=(i-100*a)/10  b=i%100/10   i/10%10
		c=i%10;		
		if(i==a*a*a+b*b*b+c*c*c) 
		{
			cout << i << " ";
		}
	}
*/	

/*
	int i,j,k,x;
	
	for (i=1;i<=9;i++)
	{
		for (j=0;j<=9;j++)
		{
			for (k=0;k<=9;k++)
			{
				x=i*100+j*10+k;
				if (x=i*i*i+j*j*j+k*k*k)
				{
					cout << x << " ";
				}

			}
		}
	}
*/	

/*
	int i,j,n;
	cin >> n;
	
	for(i=1;i<=n;i++)
	{
		for(j=1;j<=i-1;j++)
		{
			cout << "-";
		}

		for(j=1;j<=2*n+1-2*i;j++)
		for(j=1;j<=2*n-1-2*(i-1);j++)
		{
			cout << "*";
		}
		cout << endl;
	}	

	n
	4 ---9
	5 ----11

i  -	*	*
1	0	7	9
2	1	5	7
3	2	3	5
4	3	1	3
5			1
*/


/*

	float h,sum=0;
	
	cin >> h;
	
	do
	{
		sum=sum+h;
		h=h/2;	
	}while(h>=1);
	
	cout << sum+h;
*/

/*
	int s[5],i;
	float sum=0,ave;

	for (i=0;i<5;i++)
	{
		cout << "�п�J" << i+1 << "�������Z:";
		cin >> s[i];
	}

	for (i=0;i<5;i++)
	{
		sum=sum+s[i];
	}
	ave=sum/5;	

	for (i=0;i<5;i++)
	{
		cout << s[i] << " ";
	}
	cout << "�`��=" << sum << " ����=" << ave; 
*/	
