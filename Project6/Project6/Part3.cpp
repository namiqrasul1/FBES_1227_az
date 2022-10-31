#include <iostream>

using namespace std;

class Car {
	char* vendor = nullptr;
	char* model = nullptr;
	int year = 0;
public:
	Car(const char* vendor, const char* model, int year) {
		SetVendor(vendor);
		SetModel(model);
		SetYear(year);
	}

	void SetVendor(const char* value) {
		delete[] vendor;
		vendor = new char[strlen(value) + 1];
		strcpy_s(vendor, strlen(value) + 1, value);
	}

	void SetModel(const char* value) {
		delete[] model;
		model = new char[strlen(value) + 1];
		strcpy_s(model, strlen(value) + 1, value);
	}

	void SetYear(int value) {
		year = value;
	}

	void Print()const {
		cout << "=============== Car Info===============\n"
			<< "Vendor: " << vendor
			<< "\nModel: " << model
			<< "\nYear: " << year << endl;
	}

	~Car() {
		delete[] vendor;
		delete[] model;
	}

	//// type cast operator overload

	operator int() {
		return year;
	}

	operator bool() {
		return year > 2000;
	}

	// cin cout overload

	friend ostream& operator<<(ostream& out, const Car& obj) {
		out << "=============== Car Info===============\n"
			<< "Vendor: " << obj.vendor
			<< "\nModel: " << obj.model
			<< "\nYear: " << obj.year << endl;
		return out;
	}

	friend istream& operator>>(istream& in, Car& obj) {
		char* bf = new char[20];
		cout << "Vendor: ";
		in.getline(bf, 20);
		obj.SetVendor(bf);

		cout << "Model: ";
		in.getline(bf, 20);
		obj.SetModel(bf);

		cout << "Year: ";
		int y;
		cin >> y;
		obj.SetYear(y);
		delete[] bf;
		return in;
	}

};

void main() {
	Car mercedes("mercedes", "GLE", 2022);

	cin >> mercedes;

	cout << mercedes;

	//int year = int(mercedes);
	//cout << year << endl;
	//cout << bool(mercedes) << endl;


}