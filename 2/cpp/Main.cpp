#include<iostream>
#include <string>
#include "MyString.h"
#include "MyText.h"

using namespace std;


int main(int argc, const char* argv[])
{
	int strToDel, chars = 0;
	int amountOfStrs = 0;

	Text text;
	string inputing;

	cout << "Enter amount of strings: ";
	cin >> amountOfStrs;
	cout << endl;

	cin.clear();

	for (int i = 0; i < amountOfStrs; i++)
	{
		cout << "Entered " << i + 1 << " string: ";
		cin >> inputing;

		char* array = new char[inputing.length()];

		for (int i = 0; i < strlen(array); i++)
			array[i] = inputing[i];

		text.AddStr(array);
		inputing.clear();
	}

	cout << endl;
	cout << "Enter strings :";
	text.Print();

	cout << "\n==============================\n";

	cout << "First letters to upper register: ";
	text.ToUpper();
	text.Print();
	cout << "\n==============================\n";

	cout << "The key-word is: ";
	text.TakeAKey().Print();
	cout << "\n================================\n";

	cout << "Input the amount of chars in string: ";
	cin >> chars;
	cout << "The amount of strings with this numb of chars is: " << text.TheLength(chars);
	cout << "\n==================================\n";

	cout << "Enter number of string to delete: ";
	cin >> strToDel;
	text.DeleteStr(strToDel);

	cout << "After deleteting " << strToDel << " string: ";
	text.Print();
	cout << "\n================================\n";

	cout << "After cleaning: " << endl;
	text.Print();

	cin >> strToDel;
	system("pause");
	return 0;
}