#include <cstdlib>
#include <iostream>

using namespace std;

void hanoi(int n, char a, char b, char c)
{ 
    if(n == 1) 
		cout << "盤 " << n << " 由 " << a << " 移至 " << c << "\n"; 
    else
	{ 
		hanoi(n - 1, a, c, b); 
		cout << "盤 " << n << " 由 " << a << " 移至 " << c << "\n"; 
		hanoi(n - 1, b, a, c); 
    }
}

int main(int argc, char *argv[])
{
    int n; 

    cout << "請輸入盤數："; 
    cin >> n; 

    hanoi(n, 'A', 'B', 'C'); 

	system("pause");
	return 0;
} 

