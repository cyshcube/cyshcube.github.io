#include <iostream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;

void sort(int s[],int n)	//�ϥΫ��б��� int *s 
{
	int i,j;
	
	for (int i=0;i<n-1;i++)
	{
		for (int j=0;j<n-1-i;j++)
		{
			if(s[j]>s[j+1])
			{
				swap(s[j],s[j+1]);
			}
		}
	}
}

int main(int argc, char *argv[]) {

	int s[5]={6,4,9,8,3};
	sort(s,5);
	cout << "�Ƨǫ�";	
	for (int i=0;i<5;i++)
	{
		cout << s[i] << " ";
	}
	
	return 0;
}


