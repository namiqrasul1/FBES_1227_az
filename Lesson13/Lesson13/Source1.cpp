#include <iostream>

using namespace std;

//class BaseClass {
//private:
//	int a;
//protected:
//	int b;
//public:
//	int c;
//};
//
//class DerivedClass : protected BaseClass {
//	void foo() {
//		b;
//		c;
//	}
//};
//
//void main() {
//	DerivedClass dc;
//	dc;
//}

class Person {
public:
	string name;
	string surname;
	int age;

	Person(string name, string surname, int age) {
		this->name = name;
		this->surname = surname;
		this->age = age;
	}

	void Show() {
		cout << name << endl << surname << endl << age << endl;
	}
};

class Student : public Person {
public:
	string school;
	float avg;
	Student(string name, string surname, int age, string school, float avg) : Person(name, surname, age) {
		this->school = school;
		this->avg = avg;
	}

	void Show() {
		Person::Show();
		cout << school << endl << avg << endl;
	}
};


void foo(){
	Student st("Vamil", "2 V ile", 13, "2 nomreli baxcha", 33);
	st.name = "VVamil";
	st.Show();
}

class Water{};
class Sirab : public Water {};
class Badamli : public Water{};

class Human {
public:
	void Drink(Water* obj) {

	}
};

void main() { 
	//foo();
	
	//Person* st = new Student("Vamil", "2 V ile", 13, "2 nomreli baxcha", 33);
	//st->Show();
	//Person& p = *st;
	//delete st;

	// SOLID
	// Single Responsibility
	// Open Closed Principle
	// Liskov Substitution Principle
	// Interface Segregation
	// Dependency Inversion

}