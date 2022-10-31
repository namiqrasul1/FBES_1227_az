//#include <iostream>
//#include <assert.h>
//using namespace std;
//
////template<typename T>
////void foo(T arg) {
////	cout << "temp\n";
////}
////
////template<>
////void foo<int>(int arg) {
////	cout << "<int> \n";
////}
////
////void main() {
////	foo(42);
////}
//
//class Car{
//	char* vendor = nullptr;
//	char* model = nullptr;
//	int year;
//public:
//	Car() { 
//		SetVendor("NoName");
//		SetModel("NoName");
//		SetYear(2000);
//	}
//
//	Car(const char* vendor, const char* model, int year) {
//		SetVendor(vendor);
//		SetModel(model);
//		SetYear(year);
//	}
//
//	Car(const Car& other) {
//		SetVendor(other.vendor);
//		SetModel(other.model);
//		SetYear(other.year);
//	}
//
//	Car& operator=(const Car& other) {
//		SetVendor(other.vendor);
//		SetModel(other.model);
//		SetYear(other.year);
//		return *this;
//	}
//
//	void SetVendor(const char* value) {
//		delete[] vendor;
//		vendor = new char[strlen(value) + 1];
//		strcpy_s(vendor, strlen(value) + 1, value);
//	}
//
//	void SetModel(const char* value) {
//		delete[] model;
//		model = new char[strlen(value) + 1];
//		strcpy_s(model, strlen(value) + 1, value);
//	}
//
//	void SetYear(int value) {
//		year = value;
//	}
//
//	friend ostream& operator<<(ostream& output, const Car& obj) {
//		output << obj.vendor << " " << obj.model << " " << obj.year << endl;
//		return output;
//	}
//
//	~Car() {
//		delete[] vendor;
//		delete[] model;
//	}
//
//};
//
//template<class T>
//class Vector {
//	T* arr = nullptr;
//	int size = 0;
//public:
//	void AddElement(const T& elem) {
//		T* temp = new T[size + 1];
//		for (int i = 0; i < size; i++) {
//			temp[i] = arr[i];
//		}
//		temp[size] = elem;
//		delete[] arr;
//		arr = temp;
//		temp = nullptr;
//		size++;
//	}
//
//	void AddElementBefore(const T& elem) {
//		T* temp = new T[size + 1];
//		temp[0] = elem;
//		for (int i = 0; i < size; i++) {
//			temp[i + 1] = arr[i];
//		}
//		delete[] arr;
//		arr = temp;
//		temp = nullptr;
//		size++;
//	}
//
//	T& operator[](int index) {
//		assert(0 <= index && index < size && "index out of range");
//		return arr[index];
//	}
//
//	void Print() {
//		for (int i = 0; i < size; i++) {
//			cout << arr[i] << " ";
//		}
//		cout << endl;
//	}
//
//	~Vector() { delete[] arr; }
//
//};
//
//
//
//void main() {
//	//Vector<double> arr;
//	//arr.AddElement(2);
//	//arr.AddElement(2.2);
//	//arr.AddElement(2.12);
//	//arr.AddElement(3.122);
//	//arr.AddElement(2.24);
//	//arr.AddElement(12.2);
//	//arr[2] = 98;
//	//arr.Print();
//	//cout << arr[2] << endl;
//
//	Vector<Car> cars;
//	cars.AddElement(Car("bmw", "e36", 1936));
//	cars.AddElement(Car("lada", "nolYeddi", 2007));
//	cars.AddElement(Car("audi", "q8", 2022));
//
//	cars.Print();
//
//	
//}