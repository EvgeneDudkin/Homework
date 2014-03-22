#include <stdio.h>
#include <iostream>
#include <fstream>
#include "stack.h"
#include <string>
#include "dijcktsra.h"

using namespace std;

int main()
{
	string expression = "";
	cout << "Enter the expresion  " << endl;
	getline(cin, expression);
	bool test = false;
	expression = dijckstra(expression, test);
	if (test)
	{
		cout << "Error " << endl;
		return 1;
	}
	cout << "Postfix notation: " << expression << endl;
	return 0;
}