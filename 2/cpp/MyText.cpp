#include <iostream>
#include <string>
#include <vector>
#include "MyString.h"
#include "MyText.h"
using namespace std;



	int length = 0;
	vector<MyString> text;

	//Adding MyString object in vector
	void Text::AddStr(MyString strToAdd)
	{
		text.push_back(strToAdd);
		length++;
	}

	//Deleting MyString object from vector
	void Text::DeleteStr(int strToDel)
	{
		text.erase(text.begin() + strToDel - 1);
		length--;
	}

	//Clearing Text
	void Text::CleatText()
	{
		text.erase(text.begin(), text.end());
		length = 0;
	}

	//Making first letters to upper register
	void Text::ToUpper()
	{
		for (int i = 0; i < length; i++)
		{
			text[i][0] = toupper(text[i][0]);
		}
	}

	//Find a key(the word that contain from first letters of the strings)
	MyString Text::TakeAKey()
	{
		MyString Key;
		for (int i = 0; i < length; i++)
		{
			Key[i] = text[i][0];
			Key.length++;
		}

		return Key;
	}

	//Return amount of string with the number of chars
	int Text::TheLength(int amount)
	{
		int quantity = 0;
		for (int i = 0; i < length; i++)
		{
			if (text[i].length == amount)
			{
				quantity++;
			}
		}

		return quantity;
	}

	//For calling operator "[]"
	MyString& Text::operator [](int index)
	{
		return text[index];
	}

	//Printing 'i' element of vector
	void Text::Print(int i)
	{
		text[i].Print();
	}

	//Printing whole vector
	void Text::Print()
	{
		for (int i = 0; i < length; i++)
		{
			Print(i);
		}
	}
