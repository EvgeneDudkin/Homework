#include <stdio.h>
#include <iostream>
#include <fstream>
#include <list>
#include <string>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");
	ifstream text("Text.txt");
	int numberOfCity = 0;
	int numberOfRace = 0;
	text >> numberOfCity;
	text >> numberOfRace;
	int **matrix = new int*[numberOfCity];
	for (int i = 0; i != numberOfCity; i++)
	{
		matrix[i] = new int[numberOfCity];
		for (int k = 0; k != numberOfCity; k++)
		{
			matrix[i][k] = 0;
		}
	}
	int count = numberOfRace;
	while (count > 0 )
	{
		int firstCity = 0;
		int secondCity = 0;
		int lenght = 0;
		text >> firstCity;
		text >> secondCity;
		text >> lenght;
		matrix[firstCity-1][secondCity-1] = lenght;
		matrix[secondCity-1][firstCity-1] = lenght;
		count--;
	}
	int numberOfCapitals = 0;
	text >> numberOfCapitals;
	int *masOfCapitals = new int[numberOfCapitals];
	int *masOfCities = new int[numberOfCity];
	for (int i = 0; i != numberOfCity; i++)
	{
		masOfCities[i] = -1;
	}
	for (int i = 0; i != numberOfCapitals; i++)
	{
		int capital = 0;
		text >> capital;
		masOfCapitals[i] = capital - 1;
		masOfCities[capital - 1] = capital-1;
	}
	int temp = 0;
	int countOfCities = numberOfCity - numberOfCapitals;
	while (countOfCities != 0)
	{
		for (int i = 0; i != numberOfCapitals; i++)
		{
			int minLenght = 99999;
			int cityWithMinLength = -1;
			for (int j = 0; j != numberOfCity; j++)
			{
				if (masOfCities[j] == masOfCapitals[i])
				{
					for (int k = 0; k != numberOfCity; k++)
					{
						if (matrix[j][k] < minLenght && matrix[j][k] != 0 && masOfCities[k] == -1)
						{
							minLenght = matrix[j][k];
							cityWithMinLength = k;
						}
					}
				}
			}
			masOfCities[cityWithMinLength] = masOfCapitals[i];
			if (countOfCities == 0)
			{
				break;
			}
		}
		countOfCities--;
	}
	for (int i = 0; i != numberOfCity; i++)
	{
		for (int k = 0; k != numberOfCity; k++)
		{
			cout << matrix[i][k] << " ";
		}
		cout << endl;
	}
	cout << endl;
	for (int i = 0; i != numberOfCity; i++)
	{
		cout << i + 1 << " город принадлежит  ";
		cout << masOfCities[i]+1 << " cтолице";
		cout << endl;
	}
	cout << endl;
	for (int i = 0; i != numberOfCity; i++)
	{
		delete[] matrix[i];
	}
	delete[] matrix;
	return 0;
}