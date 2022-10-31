//#include <iostream>
//
//using namespace std;
//
///*
//Point class yazilsin
//x,y fieldleri olsun ve her bir field uchun getter setterler yazilsin.
//constructor parametric, default
//Print method-u yazilsin
//*/
//
//class Point {
//	int x;
//	int y;
//public:
//	Point() { x = 0; y = 0; }
//
//	Point(int argX, int argY) {
//		SetX(argX);
//		SetY(argY);
//	}
//
//	int GetX() { return x; }
//	int GetY() { return y; }
//
//	void SetX(int argX) { x = argX; }
//	void SetY(int argY) { y = argY; }
//
//
//
//	void Print() {
//		cout << "X: " << x << "\nY: " << y << endl;
//	}
//};
//
///*
//Counter c(0,100);//min,max,currentData
//c.increment();
//cout<<getCurrent();//1
//c.increment();
//cout<<getCurrent();//2
//2.Rəqəmsal sayğac məhdud diapazonlu dəyişəndir. Onun tam qiyməti təyin edilmiş maksimum qiymət həddinə
// (məsələn, k 0-100 diapazonunda qiymət alır) çatdığı zaman sıfırlanır.
//Bu cür sayğacın parametri kimi rəqəmsal saatı, kilometrölçən sayğacı nümunə göstərmək olar.
// Bu cür sayğac üçün sinfi təyin edin. Maksimal və minimal qiymətlərin verilməsini,
//sayğacın qiymətinin 1 vahid artırılmasını, cari qiymətin qaytarılmasını təmin edin.
//*/
//
//class Counter {
//	int min;
//	int max;
//	int currentData;
//public:
//	Counter(int min, int max) {
//		this->min = min;
//		this->max = max;
//		this->currentData = min;
//	}
//
//	void SetCurrent(int val) {
//		currentData = val <= max ? val : min;
//	}
//
//	int GetCurrent() { return currentData; }
//
//	void Increment() {
//		SetCurrent(currentData + 1);
//	}
//
//	Counter Copy() {
//		return *this;
//	}
//};
//
//int a = 42;
//
//// address-> yeni ki, *(address).
//
//class Kamil {
//	char* str = nullptr;
//public:
//	explicit Kamil(const char* str) {
//		SetStr(str);
//	}
//
//	Kamil(int v) {
//	}
//
//	void SetStr(const char* str) {
//		delete[] this->str;
//		this->str = new char[strlen(str) + 1];
//		strcpy_s(this->str, strlen(str) + 1, str);
//	}
//};
//
//
//void main() {
//	// Kamil s = "wamil"; // implicit, error!
//	Kamil s1("wamil"); // explicit
//	Kamil s5 = 1;
//	//Counter c(1,2);
//	//Counter c2(10,20);
//
//	//Counter c3 = c2.Copy();
//
//	
//}