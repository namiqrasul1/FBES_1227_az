//#include <iostream>
//
//using namespace std;
//
///*
//1. IntArray class-i yaradin. Bu class massiv rolunu
//oynamalidir.
//Novbeti imkanlar olsun:
//- Massivin evveline reqem elave eden method
//- Massivin sonuna reqem elave eden method
//- Massivi copy etmek imkani yaradin
//- Print
//*/
//
//class IntArray {
//public:
//	int* arr;
//	int size;
//
//	IntArray() {
//		arr = nullptr;
//		size = 0;
//	}
//
//	void addElement(int elem) {
//		int* temp = new int[size + 1];
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
//	void AddElementBefore(int elem) {
//		int* temp = new int[size + 1];
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
//	void print() {
//		for (int i = 0; i < size; i++) {
//			cout << arr[i] << " ";
//		}
//		cout << endl;
//	}
//
//	~IntArray() { delete[] arr; }
//};
//
//
//
//
//
//void main() {
//	IntArray arr;
//	arr.addElement(1);
//	arr.addElement(1123);
//	arr.addElement(1123);
//	arr.addElement(1);
//	arr.addElement(1);
//	arr.addElement(1);
//	arr.addElement(1);
//	arr.addElement(1);
//	arr.addElement(1);
//
//	arr.print();
//}