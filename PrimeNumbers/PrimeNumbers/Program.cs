using System;
using System.IO.IsolatedStorage;
using System.Diagnostics;

int numbers = 2000000;
bool[] isNotPrime = new bool[2 * (int) (numbers * Math.Log(numbers))];

Stopwatch s = Stopwatch.StartNew();

for (int i = 2; i < isNotPrime.Length; i++)
{
    if (!isNotPrime[i])
    {
        numbers--;
        if (numbers == 0)
        {
            Console.WriteLine(i);
            break;
        }
        for (int j = i * 2; j < isNotPrime.Length; j += i)
        {
            isNotPrime[j] = true;
        }
    }
}
s.Stop();
Console.WriteLine(s.ElapsedMilliseconds);