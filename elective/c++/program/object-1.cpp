#include <iostream>

using namespace std;

class person
{
	private:
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
};

int main(int argc, char *argv[]) {

	person david;
	
	david.name="David";
	david.h=180;
	david.w=70;
	david.setdefense(1000);
	
	cout << david.name << " 身高=" << david.h << " 體重=" << david.w << " 防禦力=" << david.getdefense() << endl;
	david.walk(8);

	return 0;
}




