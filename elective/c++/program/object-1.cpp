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
			cout << name << " �C�p�ɥi�] " << var << " ����" << endl;
		}
		
		void setdefense(int d)
		{
			if(d>100)
			{
				cout << "�A�]�Ӹرi�F�a�A���m�ȳ]���y�魫+����/100�z�I" << endl; 
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
	
	cout << david.name << " ����=" << david.h << " �魫=" << david.w << " ���m�O=" << david.getdefense() << endl;
	david.walk(8);

	return 0;
}




