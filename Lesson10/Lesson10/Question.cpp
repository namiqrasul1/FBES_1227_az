//#include <iostream>
//
//using namespace std;
//
//class User {
//public:
//	string username;
//	string password;
//
//	User(){}
//
//	User(string us, string pass) {
//		username = us;
//		password = pass;
//	}
//
//	bool operator==(const User& user) {
//		return username == user.username && password == user.password;
//	}
//};
//
//class Database {
//	bool FindByUsername(string username) {
//		for (int i = 0; i < size; i++) {
//			if (users[i].username == username)
//				return true;
//		}
//		return false;
//	}
//public:
//	User* users = nullptr;
//	int size = 0;
//
//	bool SingUp(const User& user) { 
//		if (FindByUsername(user.username))
//			return false;
//		User* temp = new User[size + 1];
//
//		for (int i = 0; i < size; i++) {
//			temp[i] = users[i];
//		}
//		temp[size] = user;
//		delete[] users;
//		users = temp;
//		size++;
//		temp = nullptr;
//		return true;
//		
//	}
//
//	bool SingIn(const User& user) { 
//		for (int i = 0; i < size; i++) {
//			if (users[i] == user)
//				return true;
//		}
//		return false;
//	}
//
//};
//
//
//
//void main() {
//
//}