#include "Box.h"

Box::Box() {
	width = 0;
	height = 0;
	length = 0;
}

Box::Box(int w, int l, int h) {
	width = w;
	length = l;
	height = h;
}

void Box::Print() {
	cout << "width: " << width << endl;
	cout << "length: " << length << endl;
	cout << "height: " << height << endl;
}