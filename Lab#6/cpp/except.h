#include <iostream>
#include <cmath>
#include <windows.h>
using namespace std;

class Exept{
private:
	double a, b, c, d;
public:
	Exept(double a1, double b1, double c1, double d1){
		this->a = a1;
		this->b = b1;
		this->c = c1;
		this->d = d1;
		try{
			if (b1 == 0){
				throw "wrong number of b";
			}
		}
		catch (const char* ch) {
			MessageBoxA(GetActiveWindow(), ch, "Error!", MB_ICONERROR);
			//exit(1);
		}
		try{
			if (24 + d1 - c1 < 0)
			{
				throw "sqrt < 0";
			}
		}
		catch (const char* ch) {
			MessageBoxA(GetActiveWindow(), ch, "Error!", MB_ICONERROR);
			//exit(1);
		}
	}
	double calc(){

		try{
			
			if ((sqrt(24 + d - c) + a / b) == 0){
				throw "znamennik = 0";
			}
		}
		catch (const char* ch){
			MessageBoxA(GetActiveWindow(), ch, "divide by zero Exeption", MB_ICONERROR);
		}
		return (1 + a - b / 2) / (sqrt(24 + d - c) + a / b);
	}
};