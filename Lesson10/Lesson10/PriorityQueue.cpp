#include <iostream>
#include <assert.h>
#include <queue>
#include <vector>

using namespace std;
class Student{
public:
	string name;
	double avg;

	Student() {
		name = "";
		avg = 0;
	}

	Student(string name, double avg) {
		this->name = name;
		this->avg = avg;
	}
	
	// operator >
	bool operator>(const Student& obj) {
		return avg > obj.avg;
	}
	 
	// operator <<
	friend ostream& operator<<(ostream& out, const Student& obj) {
		out << obj.name << " " << obj.avg << endl;
		return out;
	}
};

template<class T>
class PriorityQueue {
	T* arr;
	int capacity;
	int count;
	int rear;

	int GetMaxIndex() {
		int maxIndex = 0;
		for (int i = 0; i < count; i++) {
			if (arr[i] > arr[maxIndex])
				maxIndex = i;
		}
		return maxIndex;
	}

public:
	PriorityQueue(int size) {
		arr = new T[size];
		capacity = size;
		count = 0;
		rear = -1;
	}

	bool IsFull() const { return capacity == count; }
	bool IsEmpty() const { return 0 == count; }

	void Push(T value) {
		assert(!IsFull());
		arr[++rear] = value;
		count++;
	}

	void Pop() {
		assert(!IsEmpty());
		int index = GetMaxIndex(); 

		for (int i = index; i < count - 1; i++) {
			arr[i] = arr[i + 1];
		}
		count--;
	}

	void Print() {
		for (int i = 0; i < count; i++) {
			cout << arr[i] << " ";
		}
		cout << endl;
	}

	~PriorityQueue()
	{
		delete[] arr;
	}
};

int main() {
	//PriorityQueue pq(5);
	//pq.Push(1);
	//pq.Push(4);
	//pq.Push(14);
	//pq.Push(5);
	//pq.Push(591);

	//pq.Print();
	//pq.Pop();
	//pq.Pop();
	//pq.Print();

	//vector<int> vc;
	//vc.push_back(1);
	//vc.push_back(2);
	//vc.push_back(3);
	//vc.push_back(4);
	//vc.push_back(5);

	//for (int i = 0; i < vc.size(); i++) {
	//	cout << vc[i] << " ";
	//}cout << endl;

	//vc.erase(vc.begin() + 2);
	//cout << *vc.begin() << endl;
	//for (int i = 0; i < vc.size(); i++) {
	//	cout << vc[i] << " ";
	//}
	//cout << endl;
	//string s;
	//cin >> s;


	PriorityQueue<Student> pq(4);
	pq.Push(Student("vvamil", 3));
	pq.Push(Student("Rustan", 3.6));
	pq.Push(Student("ISO File", 4));
	pq.Push(Student("Huseyn", 9));

	pq.Print();
	cout << "*********************************************\n";
	pq.Pop();
	pq.Print();
	cout << "*********************************************\n";
	pq.Pop(); 
	pq.Print();
	cout << "*********************************************\n";


}