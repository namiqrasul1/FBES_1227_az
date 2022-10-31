#include <iostream>

using namespace std;

//class SomeClass {
//public:
//	int* a;
//	SomeClass(){}
//	SomeClass(int val) { SetA(val); }
//
//	void SetA(int val) { a = new int(val); }
//	// copy constructor
//	SomeClass(const SomeClass& other) {
//		SetA(*other.a);
//	}
//
//	~SomeClass() {
//		cout << "des\n";
//		delete a;
//	}
//};
//
//void foo(SomeClass s){}
//
//void main() {
//#pragma region ShallowVsDeepCopy
//
//
//	// shallow copy => uzden kopyalama
//	//int* a = new int(12);
//	//int* b = a;
//	//*a = 42;
//	//cout << *b << endl;
//	//delete a;
//	//delete b;
//
//	// deep copy => derinden kopyalama
//	//int* a = new int(12);
//	//int* b = new int(*a);
//	//cout << *b << endl;
//	//*a = 42;
//	//cout << *b << endl;
//	//delete a;
//	//delete b;
//
//#pragma endregion
//
//	SomeClass sc(2);
//	SomeClass obj(sc);
//	//cout << *obj.a << endl;
//
//}


class Student {
	char* name;
	char* surname;
	int age;
public:

#pragma region SetterGetter
	const char* GetName() { return name; }
	const char* GetSurname() { return surname; }
	int GetAge() { return age; }

	void SetName(const char* val) {
		delete[] name;
		name = new char[strlen(val) + 1];
		strcpy_s(name, strlen(val) + 1, val);
	}

	void SetSurname(const char* val) {
		delete[] surname;
		surname = new char[strlen(val) + 1];
		strcpy_s(surname, strlen(val) + 1, val);
	}

	void SetAge(int val) { age = 15 < val ? val : 16; }
#pragma endregion

#pragma region Constructors

	Student() {
		SetName("Anonim");
		SetSurname("Anonim");
		SetAge(16);
		cout << "default\n";
	}

	Student(const char* name, const char* surname, int age) {
		SetName(name);
		SetSurname(surname);
		SetAge(age);
		cout << "with params\n";
	}

	//Student(const Student& other) {
	//	SetName(other.name);
	//	SetSurname(other.surname);
	//	SetAge(other.age);
	//	cout << "copy\n";
	//}

#pragma endregion

	~Student() {
		delete[] name;
		delete[] surname;
		cout << "Destructor\n";
	}

};

class Group {
	Student* studs = new Student[10];
};

void main() {
	Student st("vamil", "kamil", 12);
	Student st1 = st;
	cout << st.GetName() << endl;
	cout << st1.GetName() << endl;
}