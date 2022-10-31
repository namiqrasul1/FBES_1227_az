#include <iostream>

/*
class: Computer
fields:
id(static)
object_Id
model(char*)
vendor(char*)
videocard(char*)
monitor(char*)
cpu_hz
core
ram
disk_size
isSSD(bool)
cin, cout overload
constructors
destructor
*/

//class Computer {
//	static int Id;
//	int objectId;
//	char* model;
//	char* vendor;
//	char* videoCard;
//	char* Monitor;
//	double cpuHz;
//	int core;
//	int ram;
//	int discSize;
//	bool isSSD;
//public:
//	// setter getter
//	// constructors
//
//
//
//	// destructor
//};
//int Computer::Id = 0;
///*
//class: ComputerStore
//store_name(char*)
//store_address(char*)
//Computer** computers; (array)
//addComputer();
//deleteComputer(int id);
//cin, cout overload
//constructors
//destructor
//*/
//
//class ComputerStore {
//	char* storeName;
//	char* storeAddress;
//	Computer* computers;
//public:
//	void addComputer(const Computer& obj);
//	void deleteComputer(int id);
//	//constructors
//	//destructor
//};


class A {
public:
	static int staticId;
	int id;

	A() {
		id = staticId++;
	}
};
int A::staticId = 100;

void main() {
	A a;
	A a1;
	A a2;
	A a3;


}
