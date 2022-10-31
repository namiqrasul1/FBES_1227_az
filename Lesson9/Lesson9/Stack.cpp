//#include <iostream>
//#include <assert.h>
//#include <stack>
//
//using namespace std;
////
////class Computer {
////	static int staticId;
////	int id;
////	string vendor;
////	string model;
////	string videoCard;
////	string monitor;
////	double cpuHz;
////	int core;
////	int ram;
////	int discSize;
////	bool isSSD;
////public:
////	void SetVendor(string value) {
////		vendor = value;
////	}
////	void SetModel(string value) {
////		model = value;
////	}
////	void SetVideoCard(string value) {
////		videoCard = value;
////	}
////	void SetMonitor(string value) {
////		monitor = value;
////	}
////	void SetCpuHz(double value) {
////		cpuHz = value;
////	}
////	void SetCore(int value) {
////		core = value;
////	}
////	void SetRam(int value) {
////		ram = value;
////	}
////	void SetDiscSize(int value) {
////		discSize = value;
////	}
////	void SetIsSSD(bool value) {
////		isSSD = value;
////	}
////
////	int GetId() const { return id; }
////	string GetVendor() const { return vendor; }
////	string GetModel() const { return model; }
////	string GetVideoCard() const { return videoCard; }
////	string GetMonitor() const { return monitor; }
////	double GetCpuHz() const { return cpuHz; }
////	int GetCore() const { return core; }
////	int GetRam() const { return ram; }
////	int GetDiscSize() const { return discSize; }
////	bool GetIsSSD() const { return isSSD; }
////
////	Computer() {
////		id = staticId++;
////		vendor = "";
////		model = "";
////		videoCard = "";
////		monitor = "";
////		SetCpuHz(0);
////		SetCore(0);
////		SetRam(0);
////		SetDiscSize(0);
////		SetIsSSD(0);
////	}
////
////	Computer(string vendor, string model, string videoCard, string monitor, double cpuHz, int core, int ram, int discSize, bool isSsd) {
////		id = staticId++;
////		SetVendor(vendor);
////		SetModel(model);
////		SetVideoCard(videoCard);
////		SetMonitor(monitor);
////		SetCpuHz(cpuHz);
////		SetCore(core);
////		SetRam(ram);
////		SetDiscSize(discSize);
////		SetIsSSD(isSSD);
////	}
////
////	Computer(const Computer& comp) {
////		id = comp.id;
////		SetVendor(comp.vendor);
////		SetModel(comp.model);
////		SetVideoCard(comp.videoCard);
////		SetMonitor(comp.monitor);
////		SetCpuHz(comp.cpuHz);
////		SetCore(comp.core);
////		SetRam(comp.ram);
////		SetDiscSize(comp.discSize);
////		SetIsSSD(comp.isSSD);
////	}
////
////	Computer& operator=(const Computer& comp) {
////		SetVendor(comp.vendor);
////		SetModel(comp.model);
////		SetVideoCard(comp.videoCard);
////		SetMonitor(comp.monitor);
////		SetCpuHz(comp.cpuHz);
////		SetCore(comp.core);
////		SetRam(comp.ram);
////		SetDiscSize(comp.discSize);
////		SetIsSSD(comp.isSSD);
////		return *this;
////	}
////
////	friend ostream& operator<<(ostream& out, const Computer& obj) {
////		out << "=============== Computer Info ===============\n"
////			<< "ObjectId:" << obj.id
////			<< "\nVendor: " << obj.vendor
////			<< "\nModel: " << obj.model
////			<< "\nMonitor: " << obj.monitor
////			<< "\nCpu-Hz: " << obj.cpuHz
////			<< "\nCore: " << obj.core
////			<< "\nRam: " << obj.ram
////			<< "\nDiskSize: " << obj.discSize
////			<< "\nSSD: " << obj.isSSD;
////		return out;
////	}
////
////	friend istream& operator>>(istream& in, Computer& obj) {
////		char* bf = new char[40];
////		cout << "Model: ";
////		in.getline(bf, 40);
////		obj.SetModel(bf);
////
////		cout << "Vendor: ";
////		in.getline(bf, 40);
////		obj.SetVendor(bf);
////
////		cout << "Videocard: ";
////		in.getline(bf, 40);
////		obj.SetVideoCard(bf);
////
////		cout << "Monitor: ";
////		in.getline(bf, 40);
////		obj.SetMonitor(bf);
////
////		cout << "Cpu-Hz: ";
////		double y;
////		cin >> y;
////		obj.SetCpuHz(y);
////
////		cout << "Core: ";
////		int c;
////		cin >> c;
////		obj.SetCore(c);
////
////		cout << "Ram: ";
////		int r;
////		cin >> r;
////		obj.SetRam(r);
////
////		cout << "Disc Size: ";
////		int d;
////		cin >> d;
////		obj.SetDiscSize(d);
////
////		cout << "is SSD ? (1 = Yes, 0 = No) : ";
////		int i;
////		cin >> i;
////		obj.SetIsSSD(i);
////
////		delete[] bf;
////		return in;
////	}
////};
////int Computer::staticId = 100;
////void main() {
////	Computer* comp = new Computer("asus", "zenbook", "gtx", "aoc", 2.1, 2, 5, 12, 0);
////	cout << *comp;
////	delete comp;
////}
//
//
//class Book{};
//// Stack
//template<class T>
//class Stack {
//	T* arr;
//	int capacity;
//	int top;
//public:
//	Stack(int size) {
//		capacity = size;
//		arr = new T[capacity];
//		top = -1;
//	}
//	
//	bool IsFull() { return capacity - 1 == top; }
//	bool IsEmpty() { return top == -1; }
//
//	void Push(T value) {
//		assert(!IsFull() && "Stack overflow");
//		arr[++top] = value;
//	}
//
//	void Pop() {
//		assert(!IsEmpty() && "Stack is empty");
//		top--;
//	}
//
//	T Top(){ 
//		assert(!IsEmpty() && "Stack is empty");
//		return arr[top];
//	}
//
//	~Stack() { delete[] arr; }
//};
//
//void main() {
//	Stack<double> st(5);
//
//	st.Push(1.1);
//	st.Push(2.1);
//	st.Push(3.1);
//	st.Push(4.1);
//	st.Push(5.1);
//
//	cout << st.Top() << endl;
//	st.Pop();
//	cout << st.Top() << endl;
//	st.Push(10);
//	cout << st.Top() << endl;
//
//	while (!st.IsEmpty()) {
//		cout << st.Top() << endl;
//		st.Pop();
//	}
//	//Stack<Book> stt;
//
//	// stl => standard template library
//	// <> is generic
//	stack<double> s;
//	s.push(1.1);
//	s.push(2.1);
//	s.push(3.1);
//	s.push(4.1);
//	s.push(5.1);
//
//	cout << s.top() << endl;
//	s.pop();
//	cout << s.top() << endl;
//	s.push(10);
//	cout << s.top() << endl;
//
//	while (!s.empty()) {
//		cout << s.top() << endl;
//		s.pop();
//	}
//}