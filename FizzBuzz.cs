using System;

public abstract class FizzBuzz
{
    public abstract string Get(int n);

    public void Run(int limit)
    {
        for (int i = 1; i < limit; i++)
        {
            Console.WriteLine(Get(i));
        }
    }
}
