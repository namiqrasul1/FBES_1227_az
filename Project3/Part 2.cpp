#include <iostream>

using namespace std;

//class Car {
//	char* vendor;
//	char* model;
//	int horsePower;
//public:
//
//	Car() : vendor(nullptr), model(nullptr), horsePower(0) {}
//
//	Car(const char* vendor) : Car() {
//		SetVendor(vendor);
//	}
//
//	Car(const char* vendor, const char* model) : Car(vendor) {
//		SetModel(model);
//	}
//
//	Car(const char* vendor, const char* model, int hp) : Car(vendor, model) {
//		SetHorsePower(hp);
//	}
//	
//#pragma region Getters&Setters
//	// Suitable
//	const char* GetVendor() { return vendor; }
//
//	const char* GetModel() { return model; }
//
//	int GetHorsePower() { return horsePower; }
//
//	void SetVendor(const char* vendor) {
//		delete[] this->vendor;
//		this->vendor = new char[strlen(vendor) + 1];
//		strcpy_s(this->vendor, strlen(vendor) + 1, vendor);
//	}
//
//	void SetModel(const char* model) {
//		delete[] this->model;
//		this->model = new char[strlen(model) + 1];
//		strcpy_s(this->model, strlen(model) + 1, model);
//	}
//
//	void SetHorsePower(int hp) {
//		horsePower = 0 < hp ? hp : 1;
//	}
//#pragma endregion
//
//	void Print() {
//		cout << "Vendor: " << vendor << " Model: " << model << " Hp: " << horsePower << endl;
//	}
//
//	~Car() {
//		delete[] vendor;
//		delete[] model;
//	}
//};
//
//void main() {
//	Car* car = new Car("tesla", "model-x", 2000);
//
//	car->Print();
//	delete car;
//}

class MC {
public:
	MC() { cout << "def\n"; }
	MC(int a) { cout << "cwp\n"; }
	~MC() { cout << "des\n"; }
};

void main() {
	MC* obj = new MC[2];
	delete[] obj;
}

// Ayshan - des
// Rustam + 
// Rasul  - 
// Elchin -
// Nigar  +
// Wamil  +
// Islam  +
// Nahid  - cwp des
// Azer   +
// Huseyn - des
// Saxa   - def des
// Online +
