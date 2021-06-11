#include <iostream>
#include <cstdlib>
#include <ctime>
/* run this program using the console pauser or add your own getch, system("pause") or input loop */

using namespace std;

int main(int argc, char *argv[]) {
	int lotto[11]={0},r;
	
	srand(time(NULL));

	for (int i=0;i<6;i++)
	{
		do{
			r=rand()%10+1;	
		}while(lotto[r]==1);
		
		lotto[r]=1;
		cout << r << " ";
	}
	
	return 0;
}
/*Q：這種演算法有什麼問題？ 
	int lotto[6];
	srand(time(NULL));

	for (int i=0;i<6;i++)
	{
		lotto[i]=rand()%10+1;
		for (int j=0;j<i;j++)
		{
			if (lotto[i]==lotto[j])
			{
				lotto[i]=rand()%10+1;				
			}
		}
		cout << lotto[i] << " ";
	}
*/	

