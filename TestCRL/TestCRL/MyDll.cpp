// MyDll.cpp
#include <stdio.h>
#include "MyDll.h"

int sum(int a, int b) {
	return a + b;
}

void MyMessage(char& ch) {
	printf("%s", ch);
}