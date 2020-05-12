#include <iostream>
#include <iomanip>
#include <vector>
#include <string>

using namespace std;

string GetString(vector<string> str);

int main(){
	cout << " Kovalenko Yevhen IS-93 Variant#10"<<endl;

	string(*GetStringPointer)(vector<string> str); // start of making a pointer function

	GetStringPointer = GetString; // finish making a pointer of func

	cout << "Input a count of strings: " << endl;
	int n;
	cin >> n;
	cout << " Input strings: " << endl;
	string str;
	vector<string> vec;
	int counter = 0;
	while (counter < n){

		cin>>str;
		vec.push_back(str);
		counter++;
	}
	string result = "";
	result  = GetStringPointer(vec);

	cout << result;

	system("pause");
	return 0;
}

string GetString(vector<string> str){
	string result = "";
	for (int i = 0; i < str.size(); i++)
	{
		result = result + str[i][i];
	}
	return result;
}