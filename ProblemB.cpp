#include <iostream>
#include <string>
using namespace std;

int alefba[26] = {0};

int main()
{
	string text;
	getline(cin, text);
	int len = text.length();
	for (int i = 0; i < len; i++)
	{
		if (isalpha(text[i]))
		{
			text[i] = tolower(text[i]);
			alefba[text[i] - 97]++;
		}
	}
	int sum = 0;
	for (int i= 0; i< 26; i++)
	{
		if (alefba[i] > 0)
		{
			sum++;
		}
	}
	cout << sum;
}