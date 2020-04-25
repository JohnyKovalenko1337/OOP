#include <iostream>
#include <iomanip>
#include "except.h"
using namespace std;
int main(){
	cout << "Kovalenko Yevhen IS-93"<<endl;
	Exept *obj[5];// Make arrg out objects
	obj[0] = new Exept(1, 0, 3, 2);
	obj[1] = new Exept(5, 2, 30, 2);
	obj[2] = new Exept(0, 2, 34, 10);
	for (int i = 2; i < 3; i++)
	{
		cout << "Value" << i + 1 << " = " << fixed << setprecision(3) << obj[i]->calc() << endl;;//Output value each object
	}
	system("pause");
	return 0;
}