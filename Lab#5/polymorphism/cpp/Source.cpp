#include<iostream>
#include<iomanip>
#include<cmath>
#include<string>

using namespace std;

	//=====================================������� ����====================================================
class Ryadok
{
	public:
		virtual int Len() { return 0; } //��������� ������� ����������� �������
		virtual void Sdvig() { }    //��������� ������� ������ ���������� �������� �� ����� ����
};
	//=================================���������� ���� �����==================================================
class Nums : public Ryadok
{
	private:
		string nums;
	public:
		Nums(int x1, int x2, int x3)                  //����������� � �����������
		{
			nums = to_string(x1) + " " + to_string(x2) + " " + to_string(x3);
		}

		int Len()  //����������� �������
		{
			return nums.length();
		};
		void Print()
		{
			cout<<"Numbers :" << nums<<endl;
		};
		void Sdvig()   // ����� ����
		{
			string array = nums;
			int k = 1;
			char temp;
			for (int j = 0; j < k; j++)
			{
				temp = array[array.length() - 1];
				for (int i = array.length() - 1; i >= 1; i--)
					array[i] = array[i - 1];
				array[0] = temp;
			}
			cout << "Sdvig: " << endl << array << endl;
		}
};
	//=========================================���� �������� ���� �����===============================================
class LowerLetters : public Ryadok
{
	private:
		string lower;

	public:
		LowerLetters(string s) //�����������
		{
			lower = s;
		}

		void Print()
		{
			cout << "LowerLetters :" << lower << endl;
		}

		int Len() //�������
		{
			return lower.length();
		}

		void Sdvig() // �����
		{
			string array = lower;
			int k = 1;
			char temp;
			for (int j = 0; j < k; j++)
			{
				temp = array[array.length() - 1];
				for (int i = array.length() - 1; i >= 1; i--)
					array[i] = array[i - 1];
				array[0] = temp;
			}
			cout << "Sdvig: " << endl << array << endl;
		}
};
	//=============================================================================================
int main()
	{
		
		cout<<"Kovalenko Yevhen IS-93"<<endl;

		Nums* num = new Nums(1, 2, 45);

		num->Print();

		cout<<"Numbers Length:"<< num->Len()<<endl;

		num->Sdvig();

		LowerLetters* low = new LowerLetters("asdasd");

		low->Print();


		cout<<"LowerLetters Length:"<< low->Len()<<endl;

		low->Sdvig();

		system("pause");
		return 0;
}
