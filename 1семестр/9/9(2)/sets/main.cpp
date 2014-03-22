#include <stdio.h>
#include <iostream>
#include <math.h>

using namespace std;

int factorial(int number)
{
	if (number == 0)
	{
		return 1;
	}
	return number * factorial(number - 1);
}

// Возвращает кол-во биективных отображений
int bijection(int n, int m)
{
	if (n == m)
	{
		return factorial(n);
	}
	else
	{
		return 0;
	}

}

// Возвращает кол-во сюръективных отображений.
int injection(int n, int m)
{
	if (m >= n)
	{
		return factorial(m) / factorial(m - n);
	}
	else
	{
		return 0;
	}
}

// Возвращает кол-во всех отображений.
int mapping(int n, int m)
{
	return pow(m, n);
}

// Возвращает кол-во сюръективных отображений.
double surjection(int n, int m)
{
	double result = 0;
	for (int k = 0; k != m; k++)
	{
		result += pow(-1, k) * factorial(m) * pow(m - k, n) / (factorial(k) * factorial(m - k));
	}
	return result;
}


int main()
{
	int firstSet = 0;
	int secondSet = 0;
	cout << "Enter the first set" << endl;
	cin >> firstSet;
	cout << "Enter the second set" << endl;
	cin >> secondSet;
	cout << "Bijection = " << bijection(firstSet, secondSet) << endl;
	cout << "Surjetion = " << surjection(firstSet, secondSet) << endl;
	cout << "Mapping = " << mapping(firstSet, secondSet) << endl;
	cout << "Injection = " << injection(firstSet, secondSet) << endl;
	return 0;
}