#include <iostream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;

int main(int argc, char *argv[]) {

	int num[10]={256,731,943,389,142,645,829,945,371,418},s,i;
	string name[10]={"林小虎","王中森","邵木淼","李大同","陳子孔","鄭美麗","曾溫柔","錢來多","賈天良","吳水品"};
	bool isFound=false;

	cout << "請輸入中獎號碼：";
	cin >> s;
	
	for (i=0;i<10;i++)
	{
		if(s==num[i])
		{
			isFound=true;
			break;
		}
	}
	
	if (isFound==true)
	{
		cout << name[i];
	}
	else
	{
		cout << "沒人中獎！"; 
	}
	 
	return 0;
}


