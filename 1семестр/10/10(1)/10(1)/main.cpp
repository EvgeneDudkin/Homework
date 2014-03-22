#include <stdio.h>
#include <iostream>
#include <fstream>
#include <string>
#include "cmp.h"

using namespace std;

int main()
{
	string expression = "";
	cout << "Enter the expression " << endl;
	ifstream file("Text.txt");
	while (!file.eof())
	{
		expression += file.get();
	}
	cout << expression << endl;
	string subString = "";
	cout << "Enter the substring " << endl;
	getline(cin, subString);
	int position = CMP(expression, subString);
	if (position == -1)
	{
		cout << "subString is not exist " << endl;
	}
	else
	{
		cout << position << endl;
	}
	file.close();
	return 0;
}