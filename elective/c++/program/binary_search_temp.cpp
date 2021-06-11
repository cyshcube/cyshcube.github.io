#include <iostream>
#include <cstdlib>

using namespace std;

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	int num[]={1,3,7,14,18,20,23,32,38,41,44,56,57,73,76,77,89,93,99,100},s,left,right,mid,i=0;
	bool flag=false;
	cout << "請輸入中獎編號";
	cin >> s; 

	left=0;
	right=19;

	while(1)
	{
		i++;
		mid=(left+right)/2;
		
		if (s==num[mid])
		{
			flag=true;
			break;		
		}
		else if(s>num[mid])
		{
			left=mid+1;
		}
		else
		{
			right=mid-1;
		}
	}

	if (flag==true)
	{
		cout << "找到" << num[mid] << " 找了" << i << "次";
	}
	else
	{
		cout << "沒找到";
	}

	return 0;
}

					
