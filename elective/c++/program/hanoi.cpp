#include <cstdlib>
#include <iostream>

using namespace std;

void hanoi(int n, char a, char b, char c)
{ 
    if(n == 1) 
		cout << "�L " << n << " �� " << a << " ���� " << c << "\n"; 
    else
	{ 
		hanoi(n - 1, a, c, b); 
		cout << "�L " << n << " �� " << a << " ���� " << c << "\n"; 
		hanoi(n - 1, b, a, c); 
    }
}

int main(int argc, char *argv[])
{
    int n; 

    cout << "�п�J�L�ơG"; 
    cin >> n; 

    hanoi(n, 'A', 'B', 'C'); 

	system("pause");
	return 0;
} 

