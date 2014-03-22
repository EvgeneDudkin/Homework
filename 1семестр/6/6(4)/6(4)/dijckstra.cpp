#include <string>
#include "stack.h"
#include "dijcktsra.h"

using namespace std;

int priority(char symbol)
{
	switch (symbol)
	{
	case '*':
	case '/':
		return 2;
	case '+':
	case '-':
		return 1;
	default:
		return 0;
	}

}

string dijckstra(string expression,bool test)
{
	string output = "";
	int count = 0;
	Stack *stack = createStack();
	while (count != expression.length())
	{
		char symbol = expression[count];
		if (symbol == ' ')
		{
			count++;
			continue;
		}
		if (symbol >= '0' && symbol <= '9')
		{
			output += symbol;
			output += " ";
			count++;
			continue;
		}
		if (symbol == '*' || symbol == '/' || symbol == '+' || symbol == '-')
		{
			if (size(stack) != 0)
			{
				while (priority(top(stack)) >= priority(symbol))
				{
					output += top(stack);
					output += " ";
					pop(stack);
					if (size(stack) == 0)
					{
						break;
					}
				}
			}
			push(stack, symbol);
			count++;
			continue;
		}
		if (symbol == '(')
		{
			push(stack, symbol);
			count++;
			continue;
		}
		if (symbol == ')')
		{
			if (size(stack) == 0)
			{
				test = true;
				deleteStack(stack);
				return output;
			}
			while (top(stack) != '(')
			{
				if (size(stack) == 0)
				{
					test = true;
					deleteStack(stack);
					return output;
				}
				output += top(stack);
				output += " ";
				pop(stack);
			}
			pop(stack);
			count++;
			continue;
		}
	}
	while (size(stack) != 0)
	{
		if (top(stack) == '(')
		{
			test = true;
			deleteStack(stack);
			return output;
		}
		output += top(stack);
		output += " ";
		pop(stack);
	}
	deleteStack(stack);
	return output;
}