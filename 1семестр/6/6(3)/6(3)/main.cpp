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
		if (expression[i] == '(' || expression[i] == '[' || expression[i] == '{')
		{
			push(stack, expression[i]);
		}
		else if (expression[i] == ')')
		{
			if (size(stack) == 0)
			{
				cout << "Error" << endl;
				deleteStack(stack);
				return 1;
			}
			if (top(stack) == '(')
			{
				pop(stack);
				continue;
			}
			else
			{
				cout << "Error" << endl;
				deleteStack(stack);
				return 1;
			}
		}
		else if (expression[i] == ']')
		{
			if (size(stack) == 0)
			{
				cout << "Error" << endl;
				deleteStack(stack);
				return 1;
			}
			if (top(stack) == '[')
			{
				pop(stack);
				continue;
			}
			else
			{
				cout << "Error" << endl;
				deleteStack(stack);
				return 1;
			}
		}
		else if (expression[i] == '}')
		{
			if (size(stack) == 0)
			{
				cout << "Error" << endl;
				deleteStack(stack);
				return 1;
			}
			if (top(stack) == '{')
			{
				pop(stack);
				continue;
			}
			else
			{
				cout << "Error" << endl;
				deleteStack(stack);
				return 1;
			}
		}

	}
	if (size(stack) != 0)
	{
		cout << "Error" << endl;
		deleteStack(stack);
		return 1;
	}
	else
	{
		cout << "All right " << endl;
	}
	deleteStack(stack);
	return 0;
}