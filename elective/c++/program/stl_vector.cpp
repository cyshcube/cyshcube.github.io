#include <iostream>
#include <vector>
/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;

int main(int argc, char** argv) {
	int n;
	vector<int> vt;

	cout<<"�п�J��Ƹ�Ƽƶq�G";
	cin >> n;
	
	for (int i=0;i<n;i++)
	{
		int data;
		cout << "�п�J��ơG";
		cin >> data;
		vt.push_back(data);
	}
	
	cout << "��ܪ��Ʀr���G";
	vector<int>::iterator it=vt.begin();
	while(it!=vt.end())
	{
		cout << *it << " ";
		it++;
	}
	return 0;
}
/*
vector�`�Ψ禡
[n]			���o�į��ޭ�n����� 
size		�p�����
front		���o�}�Y����
back		���o��������
pop_back	�����������
push_back	�s�W��Ʃ󵲧�
begin		���o�}�Y��������H���� 
end			���o������������H���� 
insert		���J���
erase		�R�����
*/

// �e�� <list> <deque> <vector> <stack> <queue> <set> <map>



