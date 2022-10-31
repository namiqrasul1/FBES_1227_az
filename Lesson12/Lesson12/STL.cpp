#include <iostream>
#include <list>
#include <forward_list>
#include <initializer_list>

using namespace std;

void foo(initializer_list<int> l) {
	for (auto i : l) {
		cout << i << " ";
	}
}

void main() {
	//foo({ 1,2,132,31,23,123,12,3 });
	list<int> listt;
	listt.assign({ 1,2,213,12,3,123,12,312,3,12,3 });
	//listt.assign(10, 99);
	//
	//for (auto i = listt.begin(); i != listt.end(); i++) {
	//	cout << *i << " ";
	//}cout << endl;

	//for (auto i = --listt.end(); i != listt.begin(); i--) {
	//	cout << *i << " ";
	//}
	//cout << *listt.begin();
	//cout << endl;

	/*for (auto i : listt) {
		cout << i << " ";
	}*/

	forward_list<int> fl;
	fl.assign({ 12,3123,123,123,12,3,123 });
	for (auto i = fl.begin(); i != fl.end(); i++) {
		cout << *i << " ";
	}cout << endl;

	//for (auto i = --fl.end(); i != fl.begin(); i--) {
	//	cout << *i << " ";
	//}
	cout << *fl.begin();
	cout << endl;

}