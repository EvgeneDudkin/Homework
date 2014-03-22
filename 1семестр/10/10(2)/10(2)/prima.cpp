#include "prima.h"

int **prima(int **matrix, int numberOfTops, int mainTop)
{
	bool *test = new bool[numberOfTops];
	for (int i = 0; i != numberOfTops; i++)
	{
		test[i] = false;
	}
	test[mainTop] = true;
	int **osTree = new int*[numberOfTops];
	for (int i = 0; i != numberOfTops; i++)
	{
		osTree[i] = new int[numberOfTops];
		for (int k = 0; k != numberOfTops; k++)
		{
			osTree[i][k] = 0;
		}
	}
	bool testOfEnd = false;
	for (int n = 0; n != numberOfTops - 1; n++)
	{
		int leftEdge = 0;
		int rightEdge = 0;
		int beeline = 99999;
		for (int i = 0; i != numberOfTops; i++)
		{
			if (test[i])
			{
				for (int k = 0; k != numberOfTops; k++)
				{
					if (matrix[i][k] < beeline && matrix[i][k] != 0 && test[k] != 1)
					{
						leftEdge = i;
						rightEdge = k;
						beeline = matrix[i][k];
					}
				}
			}
		}
		test[rightEdge] = true;
		osTree[leftEdge][rightEdge] = beeline;
		osTree[rightEdge][leftEdge] = beeline;
	}

	delete []test;
	return osTree;
}