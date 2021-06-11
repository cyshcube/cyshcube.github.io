#include <iostream>
#include <vector>
#include <algorithm>
/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;

int main(int argc, char** argv) {
	int s[5]={6,4,9,8,3},p,n;

	sort(s,s+5);
	for (int i=0;i<5;i++)
		cout << s[i] << " ";
	
	cout << endl <<"請輸入要尋找的數字："; 
	cin >> n;
	p=lower_bound(s,s+5,n)-s; //以二分搜尋方式取得第一個大於等於 n 的第一個位置。搜尋的區間必須為已排序，否則結果無法預期。 
	cout << p << endl;
	
	reverse(s,s+5);
	for (int i=0;i<5;i++)
		cout << s[i] << " ";
	cout << endl;

//stl algorithm 配合 stl container 
	vector<int> vt;
	for (int i=0;i<5;i++)
	{
		vt.push_back(i);		
	}

	vector<int>::iterator it=vt.begin();
		
	reverse(vt.begin(),vt.end());
	while(it!=vt.end()){
		cout << *it << " ";	
		it++;
	}
	cout << endl;
	
	sort(vt.begin(),vt.end())	;
	it=vt.begin();
	while(it!=vt.end()){
		cout << *it << " ";	
		it++;
	}
		
	return 0;
}



