using System;
using System.Linq;

namespace MyString
{
    public class Mystring
    {
    private char[] _MyStr;
	int length = 0;
	
		
    public Mystring(char[] str)
	    {
		_MyStr = str;
		length =str.Length;
	    }
    public int MyLength() // Length of the string
    {
        return _MyStr.Length;
    }

	    //Printing the string
    public void Print()
	    {
		    for (int j = 0; j < length; j++)
		    {
			    Console.WriteLine( _MyStr[j]);
		    }
	    }
    }
}
