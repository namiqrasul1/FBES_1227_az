//#include <iostream>
//
//using namespace std;
//
//class Int {
//public:
//	int n; // field (member variable of class, SINIFIN uzv deyisheni)
//	Int() { n = 0; }
//	Int(int n) : n(n) {}
//	Int(const Int& other) { n = other.n; }
//
//	Int operator+(const Int& obj) {
//		return Int(this->n + obj.n);
//	}
//
//	Int operator/(const Int& obj) {
//		return Int(this->n / obj.n);
//	}
//
//	// increment
//	// prefix
//
//	Int& operator++() {
//		++n;
//		return *this;
//	}
//	// postfix
//	Int& operator++(int) {
//		Int temp = n;
//		n++;
//		return temp;
//	}
//
//	// relational operators overloading
//
//	bool operator>(const Int& obj) {
//		return this->n > obj.n;
//	}
//
//	bool operator<(const Int& obj) {
//		return this->n < obj.n;
//	}
//
//	bool operator>=(const Int& obj) {
//		return this->n >= obj.n;
//	}
//
//	bool operator<=(const Int& obj) {
//		return this->n <= obj.n;
//	}
//
//	bool operator==(const Int& obj) {
//		return this->n == obj.n;
//	}
//
//	bool operator!=(const Int& obj) {
//		return this->n != obj.n;
//	}
//};
//
////Int operator+(const  Int& obj, const Int& obj1) {
////	return Int(obj.n + obj1.n);
////}
//
//void main() {
//	Int obj = 12;
//	Int n1 = 42;
//	Int result = obj + n1;
//	cout << result.n << endl;
//	cout << (++obj).n << endl;
//	cout << (obj++).n << endl;
//	cout << obj.n << endl;
//
//	cout << boolalpha << (n1 > obj) << endl;
//	cout << boolalpha << (n1 < obj) << endl;
//	cout << boolalpha << (n1 >= obj) << endl;
//	cout << boolalpha << (n1 <= obj) << endl;
//	cout << boolalpha << (n1 == obj) << endl;
//	cout << boolalpha << (n1 != obj) << endl;
//
//}