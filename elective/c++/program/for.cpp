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
       cout << "第" << i << "號" << endl;

       for (j=1;j<=3;j++)
       {
          cout << "第" << j << "科的成績為：";
          cin >> score;
          sum=sum+score;
       }

       average=sum/3;
       cout << "第" <<  i << "號的總分為" << sum << "，平均為" << average << endl;

    }
    
    system("PAUSE");
    return EXIT_SUCCESS;
}

