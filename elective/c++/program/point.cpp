#include <iostream>
/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;

int main(int argc, char *argv[]) {
	int n1=10;
	int *p1;
	p1=&n1;
	cout << p1 << endl;
	cout << *p1 << endl;
	
//	int *p2;
//	*p2=10;	
	
	int n2;
	int *p2=&n2;
	*p2=20;
	cout << *p2 << endl;
	
	int *p3=new int;
	*p3=30;
//	int *p3=new int(30);
	cout << *p3 << endl;	
	delete p3;
	
	int array[3]={1,2,3};
	cout << array[2] << endl;
	cout << *(array+2) << endl;

	int n;
	cout << "�п�J�n�t�m���@���}�C�j�p�G";
	cin >> n;
	int *p=new int [n] ;

	cout << "�п�J�n�}�C�����G";
	for (int i=0;i<n;i++)
		cin >> *(p+i);
	
	cout << "�}�C�������G";
	for (int i=0;i<n;i++)
		cout << *(p+i) << " ";

	delete[] p;
	
	return 0;
}


