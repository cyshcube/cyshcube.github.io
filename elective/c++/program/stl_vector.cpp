#include <iostream>
#include <vector>
/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;

int main(int argc, char** argv) {
	int n;
	vector<int> vt;

	cout<<"請輸入整數資料數量：";
	cin >> n;
	
	for (int i=0;i<n;i++)
	{
		int data;
		cout << "請輸入整數：";
		cin >> data;
		vt.push_back(data);
	}
	
	cout << "顯示的數字為：";
	vector<int>::iterator it=vt.begin();
	while(it!=vt.end())
	{
		cout << *it << " ";
		it++;
	}
	return 0;
}
/*
vector常用函式
[n]			取得第索引值n之資料 
size		計算長度
front		取得開頭元素
back		取得結尾元素
pop_back	移除結尾資料
push_back	新增資料於結尾
begin		取得開頭元素之抽象指標 
end			取得結尾元素之抽象指標 
insert		插入資料
erase		刪除資料
*/

// 容器 <list> <deque> <vector> <stack> <queue> <set> <map>



