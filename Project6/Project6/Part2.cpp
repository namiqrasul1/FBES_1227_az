//#include <iostream>
//
//using namespace std;
//
////class SomeClass {
////private:
////	int n = 42;
////public:
////	bool b = true;
////
////	friend void foo();
////	friend int kamil(SomeClass);
////};
////
////// friend (function, method, class)
////
////void foo() {
////	SomeClass obj;
////	obj.n = 2;
////}
////
////int kamil(SomeClass obj) {
////	obj.n = 2;
////}
//
////class B;
////
////class A {
////public:
////	void method();
////	void method(int);
////};
////
////void A::method() {
////	B obj;
////	cout << obj.name << endl;
////}
////
////class B {
////	char* name = new char[] {"vamil"};
////public:
////	friend void A::method();
////	friend void A::method(int);
////	~B() { delete[] name; }
////};
//
//
//class B;
//
//class A {
//public:
//	void method() {
//		B obj;
//		cout << obj.str << endl;
//	}
//};
//
//class B {
//	const char* str = "hakuna matata";
//public:
//	friend class A;
//};
//
//void main() {
//
//}