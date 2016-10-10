using System;

// FizzBuzz without if, using division by 1 or 0 to branch to the catch or not
public class DivideByZero : FizzBuzz
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
        try
        {
            int a = 1 / i;
            thenDo();
        }
        catch (DivideByZeroException)
        {
            elseDo?.Invoke();
        }
    }

    public T If<T>(bool condition, T thenReturn, T elseReturn)
    {
        int i = Convert.ToInt32(condition);
        try
        {
            int a = 1 / i;
            return thenReturn;
        }
        catch (DivideByZeroException)
        {
            return elseReturn;
        }
    }
}
