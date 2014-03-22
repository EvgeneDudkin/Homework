#include <stdio.h>
#include <iostream>
#include <string>
#include <fstream>
#include <vector>
#include "prima.h"

using namespace std;

int main()
{
	ifstream file("Text.txt");
	int mainTop = 0;
	int numberOfTops = 0;
	file >> mainTop;
	file >> numberOfTops;
	int **matrix = new int*[numberOfTops];
	for (int i = 0; i != numberOfTops; i++)
	{
		matrix[i] = new int[numberOfTops];
		for (int k = 0; k != numberOfTops; k++)
		{
			matrix[i][k] = 0;
		}
	}
	for (int i = 0; i != numberOfTops; i++)
	{
		for (int k = 0; k != numberOfTops; k++)
		{
			int temp = 0;
			file >> temp;
			matrix[i][k] = temp;
		}
	}
	int **osTree = prima(matrix, numberOfTops, mainTop);
	cout << "Answer: " << endl;
	for (int i = 0; i != numberOfTops; i++)
	{
		for (int k = 0; k != numberOfTops; k++)
		{
			cout << "  " << osTree[i][k] << "  ";
		}
		cout << endl;
	}
	for (int i = 0; i != numberOfTops; i++)
	{
		delete matrix[i];
	}
	delete [] matrix;
	for (int i = 0; i != numberOfTops; i++)
	{
		delete osTree[i];
	}
	delete [] osTree;
	return 0;
}