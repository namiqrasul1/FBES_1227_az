#include <iostream>
#include <assert.h>
#include <queue>
using namespace std;

// queue
template<class T>
class Queue {
	T* arr;
	int capacity;
	int count;
	int front; // novbede olan elementi
	int rear; // current index(novbeye gelen harda dayanacaq)
public:
	Queue(int size) {
		capacity = size;
		arr = new T[capacity];
		front = 0;
		rear = -1;
		count = 0;
	}

	bool IsEmpty() { return rear == -1; }
	bool IsFull() { return count == capacity; }

	void Enqueue(T value) {
		assert(!IsFull() && "Queue is full");
		arr[++rear] = value;
		count++;
	}

	void Dequeue() {
		assert(!IsEmpty() && "Queue is empty");
		for (int i = 0; i < count - 1; i++) {
			arr[i] = arr[i + 1];
		}
		count--;
		rear--;
	}

	T Peek() {
		assert(!IsEmpty() && "Queue is empty");
		return arr[front];
	}

	~Queue() { delete[] arr; }
};

void main() {
	//Queue<long> qu(5);
	//qu.Enqueue(1);
	//qu.Enqueue(2);
	//qu.Enqueue(3);
	//qu.Enqueue(4);
	//qu.Enqueue(5);

	//for (; !qu.IsEmpty();) {
	//	cout << qu.Peek() << endl;
	//	qu.Dequeue();
	//}

	// stl
	queue<int> q;
	q.push(2);
	q.push(21);
	q.push(22);
	q.push(322);
	q.push(12432);
	q.push(2123);
	q.push(782);
	q.push(92);
	q.push(8);
	q.push(2657);

	cout << q.front() << endl;
	q.pop();
	q.pop();
	q.pop();
	q.pop();
	cout << q.front() << endl;
}