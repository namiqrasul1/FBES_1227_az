#pragma once
#include <iostream>

using namespace std;

class Box {
public:
	int width;
	int length;
	int height;

	Box();

	Box(int w, int l, int h);

	void Print();

};