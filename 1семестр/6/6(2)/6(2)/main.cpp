#include <stdio.h>
#include <iostream>
#include <fstream>
#include "stack.h"
#include <string>

using namespace std;

int main()
{
	char expression[255];
	cout << "Enter the expression " << endl;
	gets_s(expression, 255);
	Stack *stack = createStack();
	for (int i = 0; expression[i] != '\0'; i++)
	{
		if (expression[i] == ' ')
		{
			continue;
		}
		if (expression[i] >= '0' && expression[i] <= '9')
		{
			push(stack, expression[i] - 48);
		}
		else if (expression[i] == '+')
		{
			if (size(stack) == 1)
			{
				cout << "Error" << endl;
				deleteStack(stack);
				return 1;
			}
			int firstElement = top(stack);
			pop(stack);
			int secondElement = top(stack);
			pop(stack);
			push(stack, firstElement + secondElement);
		}
		else if (expression[i] == '*')
		{
			if (size(stack) == 1)
			{
				cout << "Error" << endl;
				deleteStack(stack);
				return 1;
			}
			int firstElement = top(stack);
			pop(stack);
			int secondElement = top(stack);
			pop(stack);
			push(stack, firstElement * secondElement);
		}
		else if (expression[i] == '-')
		{
			if (size(stack) == 1)
			{
				cout << "Error" << endl;
				deleteStack(stack);
				return 1;
			}
			int firstElement = top(stack);
			pop(stack);
			int secondElement = top(stack);
			pop(stack);
			push(stack, secondElement - firstElement);
		}
		else if (expression[i] == '/')
		{
			if (size(stack) == 1)
			{
				cout << "Error" << endl;
				deleteStack(stack);
				return 1;
			}
			int firstElement = top(stack);
			pop(stack);
			int secondElement = top(stack);
			pop(stack);
			if (firstElement == 0)
			{
				cout << "Error " << endl;
				deleteStack(stack);
				return 1;
			}
			push(stack, secondElement / firstElement);
		}
	}
	if (size(stack) != 1)
	{
		cout << "Error " << endl;
		deleteStack(stack);
		return 1;
	}
	cout << "result = " << top(stack) << endl;
	deleteStack(stack);
	return 0;
}