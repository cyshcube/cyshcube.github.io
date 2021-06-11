#include <iostream>

using namespace std;

int main(int argc, char *argv[])
{
	int m,n,ans,mf=1,nf=1,mnf=1,i;
	
	cin >> m >> n;
	
	for (i=1;i<=m;i++)
	{
		mf=mf*i;
	}
	
	for (i=1;i<=n;i++)
	{
		nf=nf*i;
	}
	
	for (i=1;i<=m-n;i++)
	{
		mnf=mnf*i;
	}

	ans=mf/(nf*mnf);
	
	cout << ans;
	
	return 0;
}




