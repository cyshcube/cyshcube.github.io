#include <iostream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;
int main(int argc, char *argv[]) {
	struct student
	{
		char name[10];
		int chi,eng;
		float ave;
	};
	
	struct student s[4]={{"趙一",60,70,0},{"錢二",70,80,0},{"孫三",80,90,0},{"李四",90,100,0}};

//	typedef struct student std;
//	std s[4]={{"趙一",60,70,0},{"錢二",70,80,0},{"孫三",80,90,0},{"李四",90,100,0}};
	
	for (int i=0;i<4;i++) {
		s[i].ave=(float)(s[i].chi+s[i].eng)/2;
		cout << s[i].name << " " << s[i].chi << " " << s[i].eng << " " << s[i].ave << endl;
	}
	
	return 0;
}


