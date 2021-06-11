#include <iostream>
#include <cstdlib>
#include <ctime>
/* run this program using the console pauser or add your own getch, system("pause") or input loop */

using namespace std;

int main(int argc, char *argv[]) {

	int i;	
	
	srand(time(NULL));
	
	for (i=0;i<6;i++)
	{
		cout << rand()%48+1 << " ";
	}
	
	return 0;
}




int a(int n)
{
	if (n==1)
		return 5;
	else
		return a(n-1)+3*n+2;
}


/*
n=4   9-2*i
n=5	  11-2*i
*********
-*******-
--*****--
---***---
----*----


i	j(-)  j(*)
1	0		7
2	1		5
3	2		3
4	3		1

*/


/*
	float r,area,cir;
	const float pi=3.14159;

	cout << "請輸入圓半徑：";
	
	cin >> r;

	area=pi*r*r;
	
	cir=2*pi*r;
	
	cout << "圓面積：" << area << " 圓周長：" << cir;
*/	

/*
	int e=2150,b=100,x=10,y=10,g,r;

	string name;
	
	cin >> name;
	cout << "Welcome " << name;
	
	e=e+100;
	e+=100;
	
	b=b-5;
	b-=5;
	
	x=x+1;
	x++;
	
	y=y-1;
	y--;
	
	g=e/100;
	
//	if (  ((g + 5) >= 20) || key == 1 )
	
	r=e%100;
	
	cout << e << " " << b << " " << x << " " << y << " " << g << " " << r ;
*/	

/*
	float a,b,c,x;
	
	cout << "輸入a,b,c：";
	cin >> a >> b >> c;
	
	x=(-b+sqrt(b*b-4*a*c))/(2*a);
	
	x=sqrt(25);
	
	cout << x;
*/

/*
	int age;
	
	cout << "請輸入年齡：";
	cin >> age;
	
	if(age>=18 && age<=65)   //18<=age<=65
	{
		cout << "Welcome ";	
	}
	else
	{
		
		if(age<18)
		{
			cout << "長大再來\n";	
		}
		else
		{
			cout << "下輩子再來\n";	
		}
		
	}
*/

/*
	int age;
	
	cout << "請輸入年齡：";
	cin >> age;
	
	if(age<18 || age>65) 
	{
		if(age<18)
		{
			cout << "長大再來\n";	
		}
		else
		{
			cout << "下輩子再來\n";	
		}
	}
	else
	{
		cout << "Welcome ";	
	}
*/

/*
	int age;
	
	cout << "請輸入年齡：";
	cin >> age;
	
	if(age<18) 
	{
		cout << "長大再來\n";	
	}
	else
	{
		if(age<=65)
		{
			cout << "Welcome ";	
		}
		else
		{
			cout << "下輩子再來\n";	
		}
	}
*/	

/*
	int i,m,sum=0;

	for(i=1;i<=7;i++)
	{
		if(i<=6)
		{
			cout << "請輸入星期 " << i << " 的支出:";	
		}
		else
		{
			cout << "請輸入星期日的支出:";			
		}

		cin >> m; 
		sum=sum+m;
		
	}

	cout << sum;
*/	

/*
	int i,j;
	
	


	string passwd;
	int i=0;

	do
	{

		cout << "請輸入密碼：";			
		cin >> passwd; 
		i++;

	}while(passwd!="1234" && i<3);  // 當( 密碼不對  而  次數 小於3) 

	if(passwd=="1234")
	{
		cout << "歡迎光臨"; 	
	}
	else
	{
		cout << "110"; 			
	}


	int i,j,n,a,b,c;
	float sum=0,h;
	
	cin >> n;
	
	for (i=1;i<=n;i++)
	{
		sum=sum+1/(float)(i*i);
	}
	cout << sum << endl;

	for (i=100;i<=999;i++)
	{  //1 5 3
		a=i/100;
		b=(i-100*a)/10;  //i/10-10*a   i/10%10   i%100/10
		c=i%10;
		if(i == a*a*a + b*b*b + c*c*c)
		{
			cout << i << " ";
		}
	}

	cin >> n;

	for (i=1;i<=n;i++)
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

	sum=0;
	cout << "請輸入樹高：";
	cin >> h;
	 
	do
	{
		sum=sum+h;	
		h=h/2;
	}while(h>=1);

	cout << sum+h;


	int s[5],i;
	float sum=0,ave;

	for (i=0;i<5;i++)	//0 1 2 3 4
	{
		cout << "請輸入" << i+1 << "號的成績：";
		cin >> s[i];
	}

	for (i=0;i<5;i++)	//0 1 2 3 4
	{
		sum=sum+s[i];
	}
	ave=sum/5;
	
	for (i=0;i<5;i++)	//0 1 2 3 4
	{
		cout << s[i] << " ";
	}
	cout << "總分=" << sum << " 平均=" << ave;

	
*/

/*
	
	int s[5]={6,4,9,8,3},i,t,j;

	cout << "排序前"; 
	for (i=0;i<5;i++)	//0 1 2 3 4
	{
		cout << s[i] << " ";
	}

	for(i=0;i<4;i++)
	{
		for (j=0;j<4-i;j++)
		{
			if(s[j]>s[j+1])
			{	
				t=s[j];
				s[j]=s[j+1];
				s[j+1]=t;
				
				swap(s[j],s[j+1]);
				
			}
		}
	}

	cout << endl << "排序後"; 
	for (i=0;i<5;i++)	//0 1 2 3 4
	{
		cout << s[i] << " ";
	}

	int num[10]={256,731,943,389,142,645,829,945,371,418},s,i,n;
	string name[10]={"林小虎","王中森","邵木淼","李大同","陳子孔","鄭美麗","曾溫柔","錢來多","賈天良","吳水品"};
	bool isfound=false;

	cout << "請輸入中獎編號：";
	cin >> s;
	
	for (i=0;i<10;i++)
	{
		if (s==num[i])
		{
			isfound=true;
			break;
		}
	}

	if(isfound==true)
	{
		cout << name[i];
	}	
	else
	{
		cout << "沒人中 ";
	}

*/

/*
	int s[2][3],i,j;
	string subname[3]={"國文","英文","數學"};
	float sum[2],ave[2];
	
	for (i=0;i<2;i++)
	{
		for (j=0;j<3;j++)
		{
			cout << "請輸入 " << i+1 << " 號的 " << subname[j] << " 成績："; 
			cin >> s[i][j];
		}
	}

	for (i=0;i<2;i++)
	{
		sum[i]=0;
		for (j=0;j<3;j++)
		{
			sum[i]=sum[i]+s[i][j];
		}
		ave[i]=sum[i]/j;
	}
	
	for (i=0;i<2;i++)
	{
		for (j=0;j<3;j++)
		{
			cout << s[i][j] << " ";
		}
		cout << sum[i] << " " << ave[i] << endl;
	}
	
	*/
	
	/*
		for (i=0;i<5;i++)
	{
		if(s[i][1]>max)
		{
			max=s[i][1];
			n=i;
		}
	}
	
	cout << name[n] <<" " <<max;
	
	
		for (i=0;i<5;i++)
	{
		if(s[i][2]>max)
		{
			max=s[i][2];
		}
	}
	
	for (i=0;i<5;i++)
	{
		if(s[i][2]==max)
		{
			cout << name[i] <<" " <<max;
		}
	}
	

	for (i=0;i<5;i++)
	{
		for (j=0;j<3;j++)
		{
			if(s[i][j]<60)
			{
				cout << name[i] <<" "<< subname[j] << " " << s[i][j] << endl;
			}
		}
	}
		
	string name[5]={"趙一","錢二","孫三","李四","周五"};
	string subname[3]={"國文","英文","數學"};
	float s[5][3] = {{30,50,90},{30,50,90},{80,50,70},{70,100,90},{60,70,80}},max=-100,sum[5],ave[5],aves[5],t;
	int i,j,n;

	for (i=0;i<5;i++)
	{
		sum[i]=0;
		for (j=0;j<3;j++)
		{
			sum[i]=sum[i]+s[i][j];
		}
		ave[i]=sum[i]/j;
		aves[i]=ave[i];
	}
	
	for(i=0;i<4;i++)
	{
		for (j=0;j<4-i;j++)
		{
			if(aves[j]<aves[j+1])
			{	
				t=aves[j];
				aves[j]=aves[j+1];
				aves[j+1]=t;
			}
		}
	}	
	
	for (i=0;i<5;i++)
	{
		cout << name[i]<< " " <<sum[i] << setw(10) << ave[i] << setw(10) << aves[i] <<" ";
		for(j=0;j<5;j++)
		{
			if(ave[i]==aves[j])
			{
				cout << j+1;
				break;
			}
		}
		
		cout << endl;
	}	
	
	*/
	
	
	/*int sayhello(int n);
void cook(int order);

int main(int argc, char *argv[]) {
	
	int order;
	
	order=sayhello(10);
	
	cook(order);
	
	return 0;	
	

}

int sayhello(int n)
{
	int i,type;
		
	for (i=0;i<n;i++)
	{
		cout << "welcome ";	
	}
	
	cout << "請問要點什麼？(1.紅茶 2.綠茶 3.奶茶)";
	cin >> type;

	return type;
}

void cook(int order)
{
	if(order==1)
		cout << "紅茶馬上來 "; 
	else if (order==2)
		cout << "綠茶馬上來 "; 			
	else if (order==3)
		cout << "奶茶馬上來 "; 			
	else 
		cout << "點錯了"; 
	
}

*/
