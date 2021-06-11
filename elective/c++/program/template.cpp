#include <iostream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;

template <class T>
T getMax (T a,T b) {
        T result;
        result = (a>b)? a : b;
        return result;
}

int main(int argc, char** argv) {

    cout << getMax<int>(1,2) << endl;
    cout << getMax<char>('A','B') << endl;
	
	return 0;
}


