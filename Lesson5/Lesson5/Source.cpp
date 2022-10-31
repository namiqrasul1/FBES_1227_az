#include <iostream>

using namespace std;

//class SomeClass {
//public:
//	int* a;
//
//	void SetA(int value) { delete a;  a = new int(value); }
//
//	SomeClass() { a = new int(0); cout << "default\n"; }
//
//	SomeClass(int val) {
//		SetA(val);
//		cout << "with params\n";
//	}
//
//	SomeClass(const SomeClass& o) { 
//		cout << "copy\n";
//		SetA(*o.a);
//	}
//
//	SomeClass& operator=(const SomeClass& o) {
//		cout << "Hi, I'm copy assing operator!!!\n";
//		SetA(*o.a);
//		return *this;
//	}
//
//	SomeClass& operator=(const int& o) {
//		cout << "Hi, I'm copy assing operator!!!\n";
//		SetA(o);
//		return *this;
//	}
//
//	~SomeClass() { delete a; cout << "destructor\n"; }
//};


class Student {
	char* name = nullptr;
	char* surname = nullptr;
	int age = 0;
public:
#pragma region Setter
	void SetName(const char* value) {
		delete[] name;
		int len = strlen(value) + 1;
		name = new char[len];
		strcpy_s(name, len, value);
	}
	void SetSurname(const char* value) {
		delete[] surname;
		int len = strlen(value) + 1;
		surname = new char[len];
		strcpy_s(surname, len, value);
	}

	void SetAge(int value) { age = value < 16 ? 16 : value; }

	const char* GetName() const {
		// name = new char[]; // error
		// SetAge(21); // error
		//GetSurname();
		return name;
	}
	const char* GetSurname() const { return surname; }
	int GetAge() const { return age; }
#pragma endregion

	Student() = default;

	Student(const char* name, const char* surname, int age) {
		SetName(name);
		SetSurname(surname);
		SetAge(age);
	}

	Student(const Student& other) {
		SetName(other.name);
		SetSurname(other.surname);
		SetAge(other.age);
	}

	Student& operator=(const Student& other) {
		SetName(other.name);
		SetSurname(other.surname);
		SetAge(other.age);
		return *this;
	}

	void Print() const {
		int a = 1;
		a = 3242;
		cout << name << " " << surname << " " << age << endl;
	}
	// studs[0].operator>(studs[1])
	bool operator>(const Student& obj) const {
		return strlen(name) > strlen(obj.name);
	}

	~Student() { delete[] name; delete[] surname; }
};

void addStudent(Student*& students, int& size, const Student& value) {
	Student* temp = new Student[size + 1];
	for (int i = 0; i < size; i++) {
		temp[i] = students[i];
	}

	temp[size] = value;
	size++;
	delete[] students;
	students = temp;
}

float& operator% (const float f, const Student f1) {

}

void main() {
	////SomeClass sc = 1;
	////SomeClass o;
	////o = sc;
	////o = 12;
	////cout << sc.a  << " -> " << *sc.a << endl;
	////cout << o.a << " -> " << *o.a << endl;

	//int size = 2;
	//Student* studs = new Student[size]{
	//	Student("vvamil", "vvamo", 12),
	//	Student("john", "doe", 22)
	//};
	//Student st("hakuna", "matata", 42);
	//addStudent(studs, size, st);
	//for (int i = 0; i < size; i++) {
	//	studs[i].Print();
	//}


	//const Student* student = new Student("vamil", "2v ile", 23);
	//student->~Student();
	//Student* st = new Student("vamil", "2v ile", 23);
	//st->operator=(*student);
	//*st = *student;

	int size = 2;
	const Student* studs = new Student[size]{
		Student("vvamil", "vvamo", 16),
		Student("john", "doe", 22)
	};

	float f = 0;


	cout << (studs[1] > studs[0]);
	

}