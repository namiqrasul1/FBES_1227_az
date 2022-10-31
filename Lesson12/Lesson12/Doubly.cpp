//#include <iostream>
//
//using namespace std;
//class Node {
//public:
//	Node* prev;
//	string data;
//	Node* next;
//	Node(const string& value) {
//		prev = nullptr;
//		data = value;
//		next = nullptr;
//	}
//};
//
//class DoublyList {
//	Node* head = nullptr;
//	Node* tail = nullptr;
//public:
//	void AddFront(const string& value) {
//		Node* newNode = new Node(value);
//		if (head == nullptr && tail == nullptr) {
//			head = newNode;
//			tail = newNode;
//			return;
//		}
//		newNode->next = head;
//		head->prev = newNode;
//		head = newNode;
//	}
//
//	void AddEnd(const string& value) {
//		Node* newNode = new Node(value);
//		if (head == nullptr && tail == nullptr) {
//			head = newNode;
//			tail = newNode;
//			return;
//		}
//		newNode->prev = tail;
//		tail->next = newNode;
//		tail = newNode;
//	}
//
//	void DeleteEnd() {
//		if (tail != nullptr) {
//			tail = tail->prev;
//			delete tail->next;
//			tail->next = nullptr;
//		}
//	}
//
//	void DeleteBefore() {
//		if (head != nullptr) {
//			head = head->next;
//			delete head->prev;
//			head->prev = nullptr;
//		}
//	}
//
//	void Print() {
//		Node* temp = head;
//		while (temp != nullptr) {
//			cout << temp->data << " ";
//			temp = temp->next;
//		}
//		cout << "\n";
//	}
//};
//
//
//void main() {
//	DoublyList dl;
//	dl.AddEnd("Ayshan");
//	dl.AddFront("Rustam");
//	dl.AddFront("Rasul");
//	dl.Print();
//	dl.DeleteBefore();
//	dl.Print();
//	dl.DeleteEnd();
//	dl.Print();
//}