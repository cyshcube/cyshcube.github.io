#include <iostream>

using namespace std;

class person
{
	protected:
		int defense;
		
	public:
		string name;
		int h;
		int w;

		void walk(int var)
		{
			cout << name << " 每小時可跑 " << var << " 公里" << endl;
		}
		
		void setdefense(int d)
		{
			if(d>100)
			{
				cout << "你也太誇張了吧，防禦值設為『體重+身高/100』！" << endl; 
				defense=w+h/100;
			}
			else
			{
				defense=d;
			}
		}
		
		int getdefense()
		{
			return defense;
		}
		
		person()
		{
			h=30;
		}
};


class man:public person
{
	public:
		int power()
		{
			return w*2+h;
		}

		void setdefense(int d,int age)  //子類別不同參數的多載 
		{
			if(d>100)
			{
				cout << "你也太誇張了吧，防禦值設為『體重+身高/100』！" << endl; 
				defense=w+h/100;
			}
			else
			{
				defense=d+age/10;
			}
			/*
			person::setdefense(d);
			defense+=age/10;	
			*/
		}

		man()
		{
			h=150;
		}
};


int main(int argc, char *argv[]) {

	person david;
	man kevin;
		
	david.name="David";
//	david.h=180;
	david.w=40;
	david.setdefense(1000);

	cout << david.name << " 身高=" << david.h << " 體重=" << david.w << " 防禦力=" << david.getdefense() << endl;
	david.walk(8);

	kevin.name="Kevin";
	kevin.h=180;
	kevin.w=70;
	kevin.setdefense(60,50);

	cout << kevin.name << " 身高=" << kevin.h << " 體重=" << kevin.w << " 防禦力=" << kevin.getdefense() << " 攻擊力=" << kevin.power() << endl;
	kevin.walk(10);

	return 0;
}




