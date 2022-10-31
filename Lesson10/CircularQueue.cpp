//#include <iostream>
//#include <assert.h>
//using namespace std;
//
//class Book{
//public:
//	void foo(){}
//
//};
//
//template <class T>
//class CircularQueue {
//	T* arr;
//	int front;
//	int rear;
//	int capacity;
//	int count;
//public:
//	CircularQueue(int size) {
//		arr = new T[size];
//		capacity = size;
//		rear = -1;
//		front = -1;
//		count = 0;
//	}
//
//	bool IsFull() const { return capacity == count; }
//	bool IsEmpty() const { return 0 == count; }
//
//	void Enqueue(T value) {
//		assert(!IsFull());
//		if (front == -1) front = 0;
//		rear = (rear + 1) % capacity;
//		arr[rear] = value;
//		count++;
//	}
//
//	void Dequeue() {
//		assert(!IsEmpty());
//		if (front == rear) {
//			front = -1;
//			rear = -1;
//			count = 0;
//		}
//		else {
//			front = (front + 1) % capacity;
//			count--;
//		}
//	}
//
//	T Front() {
//		assert(!IsEmpty());
//		return arr[front];
//	}
//	~CircularQueue() { delete[] arr; }
//};
//
//int main() {
//	CircularQueue<int> cq(5);
//	cq.Enqueue(1);
//	cq.Enqueue(21);
//	cq.Enqueue(1123);
//	cq.Enqueue(41);
//	cq.Enqueue(112);
//	cout << cq.Front() << endl; // 1
//	cq.Dequeue();
//	cout << cq.Front() << endl; // 21
//	cq.Dequeue();
//	cout << cq.Front() << endl; // 1123
//	cq.Dequeue();
//	cq.Dequeue();
//	cout << cq.Front() << endl; // 112
//	cq.Dequeue();
//}