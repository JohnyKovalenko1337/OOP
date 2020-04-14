#include<iostream>
#include<iomanip>
#include<cmath>

using namespace std;
//==================================================================������� ����=======================================
class Line
{
private: 
		struct Point{ // �����
		public:
			double x;
			double y;
		};
		Point A, B, C;
public: 
	Line();
	Line(double a1, double b1, double a2, double b2){ //�����������
			A.x = a1;
			A.y = b1;
			B.x = a2;
			B.y = b2;
			C.x = a2 - a1;
			C.y = b2 - b1;
		}
	double LineLeng()	//����������� �������
		{
			double result = sqrt(pow((C.x), 2) + pow((C.y), 2));
			return result;
		}
};
//=====================================================���� ��������======================================
class Segment : public Line
	{
	private:
		struct Point //�����
		{
		public:
			double x;
			double y;
		};
		Point A, B, C;
	public: 
		Segment(double a1, double b1, double a2, double b2) :Line(a1,b1,a2,b2)
		{
			A.x = a1;		//�����������
			A.y = b1;
			B.x = a2;
			B.y = b2;
			C.x = a2 - a1;
			C.y = b2 - b1;
		}
		void Print()	//���������
		{
			cout << "( " << C.x << ", " << C.y << " )" << endl;
		}
		Segment* Zmenshennya(double n)	//���������
		{


			this->C.x = B.x - (B.x - A.x) / this->LineLeng() * n;
			this->C.y = B.y - (B.y - A.y) / this->LineLeng() * n;
			cout << sqrt(pow((C.x), 2) + pow((C.y), 2)) << endl;
			return this;
		}
		
};

int main()
{
	setlocale(LC_CTYPE, "rus");
	cout << ("Kovalenko Yevhen Is-93 Variant #10") << endl;

	Line* l1 = new Line(1, 0, 1, 7);

	cout<<"������� �i�ii"<<endl;

	cout<< l1->LineLeng() <<endl;

	Segment* seg1 = new Segment(0, 1, 10, 1);

	cout << "������� �i��i���" << endl;
	cout<<seg1->LineLeng()<<endl;
	cout<<"���������� �i��i���"<<endl;
	seg1->Print();

	cout<<"������� �i��i��� �i��� ���������"<<endl;
	seg1->Zmenshennya(5);

	cout<<"���������� �i��i��� �i��� ���������"<<endl;
	seg1->Print();

	system("pause");
	return 0;
}
