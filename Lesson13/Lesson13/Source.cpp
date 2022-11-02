//#include <iostream>
//
//using namespace std;
//
//
//// nested Class
//
////class SinglyLinkedList{
////	class Node {
////		Node* next;
////		int data;
////	};
////
////	struct MyStruct
////	{
////	public:
////	private:
////	};
////
////	enum MyEnum
////	{
////
////	};
////
////	Node* head;
////};
////class DoublyLinkedList{
////	class Node {
////		Node* next;
////		int data;
////		Node* prev;
////	};
////};
////
////void foo() {
////	Node* node = new Node(); // error
////}
//
//// has a (association) class daxilinde field yaradilir
//// use   (dependency)  classin her hansi bir method parameteri ve ya return type olaraq bashqa classdan asililigi nezerde tutulur
//// is a  (inheritance)
//
//
//// has a (association)
//// Person has a name
//// Person has a surname
//// Person has a age
//// Person has a Size
//
//class Size {
//public:
//	int height;
//	int weight;
//};
//
//class Person {
//public:
//	string name;
//	string surname;
//	int age;
//	Size size;
//};
//
//// use(dependency)  classin her hansi bir methodunun parameter kimi qebul etmesi ve ya return type olaraq bashqa classin objectini qaytarmasi nezerde tutulur
//
//// class Any uses class Some
//
////class Some{};
////
////class Any {
////public:
////	Any(Some obj){}
////
////	void foo(Some obj) {}
////
////	Some boo(){}
////};
//
//// is a
//
//

//  Base     Super    Parent  Class
// Derived    Sub     Child	  Class
//class Person {
//public:
//	string name;
//	string surname;
//	int age;
//};

// Student has a avg;
// Student is a Person; 
//class Student : public Person {
//public:
//	double avg;
//};
//
//// Teacher has a speciality;
//// Teacher is a Person;
//class Teacher : public Person {
//public:
//	string speciality;
//};
//
//// Policeman has a rank;
//// Policeman is a Person;
//class Policeman : public Person{
//public:
//	string rank;
//};
//
//// DONT REPEAT YOURSELF
//
//void main() {
//	Student st;
//	
//}