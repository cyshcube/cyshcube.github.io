#include <cstdlib>
#include <iostream>

using namespace std;

int main(int argc, char *argv[])
{
    int i,j,sum=0,score;
    float average;

    for(i=1;i<=5;i++)
    {

       sum=0;
       cout << "��" << i << "��" << endl;

       for (j=1;j<=3;j++)
       {
          cout << "��" << j << "�쪺���Z���G";
          cin >> score;
          sum=sum+score;
       }

       average=sum/3;
       cout << "��" <<  i << "�����`����" << sum << "�A������" << average << endl;

    }
    
    system("PAUSE");
    return EXIT_SUCCESS;
}

