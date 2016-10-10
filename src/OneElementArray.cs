using System;

// FizzBuzz without if, using array of size 1 or 0 and "looping" through them
public class OneElementArray : FizzBuzz
{
    public override string Get(int n)
    {
        return If<string>(n % 15 == 0, // Si divisible par 15
            "FizzBuzz", 
            If<string>(n % 3 == 0, // Sinon, si divisible par 3
                "Fizz",
                If<string>(n % 5 == 0, // Sinon, si divisible par 5
                    "Buzz",
                    n.ToString()))); // Sinon
    }

    public void If(bool condition, Action thenDo, Action elseDo = null)
    {
        int i = Convert.ToInt32(condition);
        var array = new int[i];
        foreach (var item in array)
        {
            thenDo();
            return;
        }
        elseDo?.Invoke();
    }

    public  T If<T>(bool condition, T thenReturn, T elseReturn)
    {
        int i = Convert.ToInt32(condition);
        var array = new int[i];
        foreach (var item in array)
        {
            return thenReturn;
        }
        return elseReturn;
    }
}
