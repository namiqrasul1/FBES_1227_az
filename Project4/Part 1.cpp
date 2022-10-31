//#include <iostream>
//using namespace std;
//
//
//class MyClass {
//public:
//	static int staticField;
//	int id;
//	MyClass() { id = staticField++; }
//
//	static void StaticMethod() { cout << "Hello, I'm static method!!\n" << staticField << endl; }
//};
//int MyClass::staticField = 0;
//
//
//class Random {
//public:
//	static int GetRandomInt(int min, int max) {
//		return min + rand() % (max - min + 1);
//	}
//	static double GetRandomDouble(int min, int max) { return 4.2; }
//	static const char* GetRandomString(int size) { return "asdjhagsd"; }
//};
//
//
//void main() {
//	int a = Random::GetRandomInt(1, 5);
//	cout << a << endl;
//	// :: => scope resolution
//	//MyClass mc;
//	//MyClass mc1;
//	//MyClass mc2;
//	//MyClass mc3;
//	//MyClass mc4;
//
//	//cout << mc.id << endl;
//	//cout << mc1.id << endl;
//	//cout << mc2.id << endl;
//	//cout << mc3.id << endl;
//	//cout << mc4.id << endl;
//
//	//MyClass::StaticMethod();
//}
//
//
//
//
//#pragma region Question
//
//
////class A {
////public:
////	A() { cout << "default\n"; }
////	A(int a) { cout << "with params\n"; }
////	~A() { cout << "destructor\n"; }
////};
////
////void main() {
////
////	// Ayshan + + + - - - - 6
////	// Elchin + + + - + + 10
////	// Nigar  + + - + + - 8
////	// Rasul  + + - + +   9
////	// Sarxan + + - + + - 8
////	// Vamil  + + + + + - 5
////	// Huseyn + + - + + - 8
////	// Islam  + + + + + - 10
////	// Azar   + + + + + + 12
////	// Online + + + + +   12
////}
//
//
//#pragma endregion