#include<iostream>
#include<iomanip>
#include<cmath>

using namespace std; 

class Romb{
private:
	struct Point{			//структура точки
	public:
		double x;
		double y;
	};
	Point A;
	Point B;
	Point C;
	Point D;
public:
	static Romb* Multiply(Romb rhomb, double number); //метод множення точок ромбу на число
	Romb();																				//три конструктори
	Romb(int a1, int  a2, int  b1, int  b2, int  c1, int  c2, int  d1, int  d2);
	Romb(Romb* other);
	double Perimetr();
	double Square();
	Romb* operator *(double number);				//перевантаження операції множення для множення точок ромбу на число
	Romb* operator -(Romb* second);					//перевантаження операції віднімання для віднімання площ двох ромбів
};

//==========================================================Construktor 1==================================================
Romb::Romb(){
	A.x = 0;
	A.y = 0;

	B.x = 2;
	B.y = 2;

	C.x = 4;
	C.y = 0;

	D.x = -2;
	D.y = -2;
}
//==========================================================Construktor 2==================================================
Romb::Romb(int a1, int  a2, int  b1, int  b2, int  c1, int  c2, int  d1, int  d2){
	A.x = a1;
	A.y = a2;

	B.x = b1;
	B.y = b2;

	C.x = c1;
	C.y = c2;

	D.x = d1;
	D.y = d2;
}
//==========================================================Construktor 3==================================================
Romb::Romb(Romb* other)
{
	A.x = other->A.x;
	A.y = other->A.y;

	B.x = other->B.x;
	B.y = other->B.y;

	C.x = other->C.x;
	C.y = other->C.y;

	D.x = other->D.x;
	D.y = other->D.y;
}
//==========================================================Method Square==================================================
double Romb::Square(){
	double d1 = sqrt(pow(A.x - C.x, 2) + pow(A.y - C.y, 2));
	double d2 = sqrt(pow(B.x - D.x, 2) + pow(B.y - D.y, 2));

	return d1 * d2 / 2;
}
//==========================================================Method Perimetr==================================================
double Romb::Perimetr(){
	double result = 4 * sqrt((D.x - A.x)*(D.x - A.x) + (D.y - A.y)*(D.y - A.y));
	return result;
}
//==========================================================Multiply method==================================================
Romb* Romb::Multiply(Romb rhomb, double number)
{
	Romb* result = new Romb(rhomb);

	result->A.x = result->A.x * sqrt(number);
	result->A.y = result->A.y * sqrt(number);

	result->B.x = result->B.x * sqrt(number);
	result->B.y = result->B.y * sqrt(number);

	result->C.x = result->C.x * sqrt(number);
	result->C.y = result->C.y * sqrt(number);

	result->C.x = result->C.x * sqrt(number);
	result->C.y = result->C.y * sqrt(number);

	return result;
}
//======================================Перезавантаження оператору множення==================================================
Romb* Romb::operator *(double number)
{
	Romb* temp = this->Multiply(*this, number);
	return temp;
}
//=================================перезавантаження оператору віднімання==============================================
Romb* Romb::operator- (Romb* obj){
	Romb* temp = new Romb();
	double subtraction = this->Square() - obj->Square();
	temp = *this * (subtraction / this->Square());

	return temp;
}

int main(){
	cout << "Kovalenko Yevhen IS-93 Variant#10" << endl;
	Romb P1 = new Romb();
	Romb* P2 = new Romb(2, 0, 4, 2, 6, 0, 4, -2);
	Romb* P3 = new Romb((*P2 * 2));
	cout << "Perimetr 1: " << P1.Perimetr() << endl;
	cout << "Perimetr 2: " << P2->Perimetr() << endl;
	cout << "Perimetr 3: " << P3->Perimetr()<< endl;
	cout << "Square 1: " << P1.Square()<< endl;
	cout << "Square 2: " << P2->Square() << endl;
	cout << "Square 3: " << P3->Square() << endl;
	P1 = *P3 - P2;
	cout << " After P1: " << P1.Square() << endl;
	system("pause");
	return 0;
}