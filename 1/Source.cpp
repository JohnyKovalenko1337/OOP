#include<iostream>
#include<string>
using namespace std;

void Vidnimanya( int &a);
bool Vidnoshenya(int a, int b);

int main()
{
	setlocale(LC_ALL, "russian");
	cout << "Kovalenko Yevhen IS-93 VAR-10"<<endl;
	int a,b,c;
	cout << "����i�� ����� ��� ��������� �� 1: " << endl;
	cin >> a;
	Vidnimanya(a);
	cout << "Result: " << endl;
	cout << a << endl;
	cout << "����i�� ��� ����� ��� �����i��� �� ���� �i����: " << endl;
	cin >> b >> c;
	cout<<Vidnoshenya(b, c);
	
	system("pause");
	return 0;
}

void Vidnimanya(int &a){
	int Ai;
	for (int mask = 0; mask < sizeof(int) * 8 - 1; mask++) //���������� 8 �����
	{
		if (a & (1 << mask)) { Ai = 1; }		//���� � = ������ ����� �� �1 = 1
		else Ai = 0;
		if (Ai == 1)
		{
			for (int i = 0; i < mask + 1; i++)
			{
				a = a ^ (1 << i);			// ���� ��� � != 1 << i 
			}
			break;
		}
	}
}

bool Vidnoshenya(int A, int B){
	int Num_1, Num_2;
	bool flag = false;
	for (int mask = sizeof(int) * 8 - 1; mask >= 0; mask--)
	{
		Num_1 = A & (1 << mask);
		Num_2 = B & (1 << mask);
		if (Num_1 > Num_2)	//��������
		{
			flag = true;
			break;
		}
		else
			if (Num_1 < Num_2) //��������
			{
				flag = false;
				break;
			}
	}
	return flag;
}