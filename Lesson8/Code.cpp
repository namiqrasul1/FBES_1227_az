#include <iostream>

using namespace std;

class String {
	char* str;
	int capacity;
	int length;
public:

};

void main() {
	string str = "hakuna";
	//str = "kamil";
	//cout << str << endl;
	cout << str.at(2) << endl;
	cout << str.capacity() << endl;
	str = "aaaaaaaaaaaaaaaa";
	cout << str.capacity() << endl;
	str += "aaaaaaaaaaaaaaaa";
	cout << str.capacity() << endl;
	str = "1111";
	str.shrink_to_fit();
	cout << str.length() << endl;
	cout << str.capacity() << endl;

	str.insert(2, 5, 'K');
	str.insert(2, "vamil");
	str.insert(1, "hakuna", 2, 3);
	cout << str << endl;
	//cout << str.max_size(); 
	str.reserve(100);
	cout << str.capacity() << endl;
	str.reserve(50);
	cout << str.capacity() << endl;
	str = "hakuna";
	string s = "kamil";
	str.swap(s);

	cout << s << endl;
	cout << str;
}