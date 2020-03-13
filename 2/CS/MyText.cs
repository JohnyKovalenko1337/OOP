using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyString;

namespace MyText
{
    public class Mytext
    {
        int length = 0;
	private Mystring[] _text = new Mystring[0];

	//Adding MyString object in vector
	public void AddStr(char[] strToAdd)
	{
		Array.Resize(ref _text, _text.Length+1);
        Mystring word = new Mystring(strToAdd);
        _text[_text.Length - 1] = word;
	}

	//Deleting MyString object from vector
	public void DeleteStr(int strToDel)
	{
        _text = new Mystring[0];
	}

	//Clearing Text
	public void CleatText()
	{
		_text = new Mystring[0];
	}
	/*//Making first letters to upper register
	public void Toupper()
	{
		for (int i = 0; i < length; i++)
		{
            Mystring a = _text[i];
			a[0] = ToUpper(a[0]);
		}
	}

	//Find a key(the word that contain from first letters of the strings)
	public Mystring TakeAKey()
	{
		Mystring Key;
		for (int i = 0; i < length; i++)
		{
			Key[i] = _text[i][0];
			Key.Length++;
		}

		return Key;
	}
*/
	//Return amount of string with the number of chars
	public int TheLength(int amount)
	{
		int quantity = 0;
		for (int i = 0; i < length; i++)
		{
            int a = _text[i].MyLength();
			if ( a == amount)
			{
				quantity++;
			}
		}

		return quantity;
	}

	//Printing 'i' element of vector
	public void Print(int i)
	{
		_text[i].Print();
	}

	//Printing whole vector
	public void Print()
	{
		for (int i = 0; i < length; i++)
		{
			Print(i);
		}
	}

    }
}
