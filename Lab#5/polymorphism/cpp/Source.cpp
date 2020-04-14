#include<iostream>
#include<iomanip>
#include<cmath>
#include<string>

using namespace std;

	//=====================================Базовий клас====================================================
class Ryadok
{
	public:
		virtual int Len() { return 0; } //віртуальна функція знаходження довжини
		virtual void Sdvig() { }    //віртуальна функція здвигу останнього елемента на перше місце
};
	//=================================Наслідуючий клас Цифри==================================================
class Nums : public Ryadok
{
	private:
		string nums;
	public:
		Nums(int x1, int x2, int x3)                  //конструктор з параметрами
		{
			nums = to_string(x1) + " " + to_string(x2) + " " + to_string(x3);
		}

		int Len()  //знаходження довжини
		{
			return nums.length();
		};
		void Print()
		{
			cout<<"Numbers :" << nums<<endl;
		};
		void Sdvig()   // здвиг цифр
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
	//=========================================Клас наслідник Нижні букви===============================================
class LowerLetters : public Ryadok
{
	private:
		string lower;

	public:
		LowerLetters(string s) //конструктор
		{
			lower = s;
		}

		void Print()
		{
			cout << "LowerLetters :" << lower << endl;
		}

		int Len() //довжина
		{
			return lower.length();
		}

		void Sdvig() // здвиг
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
