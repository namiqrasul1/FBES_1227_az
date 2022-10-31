//#include <iostream>
//
//using namespace std;
//
//class Node {
//public:
//	string data;
//	Node* next;
//	Node(const string& data) : data(data), next(nullptr) {}
//};
//
//class SinglyList {
//	Node* head = nullptr;
//public:
//	void AddFront(const string& value) {
//		Node* newNode = new Node(value);
//		newNode->next = head;
//		head = newNode;
//	}
//
//	void AddEnd(const string& value) {
//		Node* newNode = new Node(value);
//		if (head == nullptr) {
//			head = newNode;
//			return;
//		}
//		Node* temp = head;
//
//		while (temp->next != nullptr)
//			temp = temp->next;
//
//		temp->next = newNode;
//		temp = nullptr;
//	}
//
//	void DeleteFront() {
//		if (head != nullptr) {
//			Node* temp = head;
//			head = head->next;
//			delete temp;
//		}
//	}
//
//	void DeleteEnd() {
//		if (head != nullptr) {
//			Node* temp = head;
//			while (temp->next->next != nullptr) {
//				temp = temp->next;
//			}
//			delete temp->next;
//			temp->next = nullptr;
//		}
//	}
//
//	void Print() {
//
//		Node* temp = head;
//		while (temp != nullptr)
//		{
//			cout << temp->data << " ";
//			temp = temp->next;
//		}
//	}
//	//							"Kamil", "Vamil"
//	void AddElementBefore(const string& x, const string value);
//	void AddElementAfter(const string& x, const string value);
//	void DeleteByValue(const string value);
//
//};
//
//void main() {
//	SinglyList sl;
//	sl.AddFront("Islam");
//	sl.AddFront("Ayshan");
//	sl.AddEnd("Nigar");
//	sl.AddEnd("Bahruz");
//	sl.Print();
//	sl.DeleteFront();
//	sl.DeleteEnd();
//	cout << endl;
//	sl.Print();
//}