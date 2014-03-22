#include "cmp.h"
#include <string>

int  *prefixFunction(std::string string)
{
	int lenght = string.length();
	int *array = new int[lenght];
	array[0] = 0;
	int count = 0;
	for (int i = 1; i < lenght; i++) {
		while ((count > 0) && (string[count] != string[i]))
			count = array[count - 1];
		if (string[count] == string[i])
			count++;
		array[i] = count;
	}
	return array;
}

int CMP(std::string string, std::string subString)
{
	int lenghtOfSubStr = subString.length();
	subString = subString + '#' + string;
	int *prefixFunc = prefixFunction(subString);
	for (int i = 0; i != subString.length(); i++)
	{
		if (prefixFunc[i] == lenghtOfSubStr)
		{
			delete []prefixFunc;
			return i - 2 * lenghtOfSubStr + 1;
		}
	}
	delete []prefixFunc;
	return -1;
}