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

		void setdefense(int d,int age)  //�l���O���P�Ѽƪ��h�� 
		{
			if(d>100)
			{
				cout << "�A�]�Ӹرi�F�a�A���m�ȳ]���y�魫+����/100�z�I" << endl; 
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

	cout << david.name << " ����=" << david.h << " �魫=" << david.w << " ���m�O=" << david.getdefense() << endl;
	david.walk(8);

	kevin.name="Kevin";
	kevin.h=180;
	kevin.w=70;
	kevin.setdefense(60,50);

	cout << kevin.name << " ����=" << kevin.h << " �魫=" << kevin.w << " ���m�O=" << kevin.getdefense() << " �����O=" << kevin.power() << endl;
	kevin.walk(10);

	return 0;
}




