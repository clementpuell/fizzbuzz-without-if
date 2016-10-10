// FizzBuzz without if, using a precomputed array of the expected strings
public class PreComputeArray : FizzBuzz
{
    public override string Get(int n)
    {
        var limit = new string[n + 1];
        var dataSource = new string[n * 3 * 5 + 1];

        int i = 0;
        foreach (var item in limit)
        {
            dataSource[i] = i.ToString();
            i++;
        }

        i = 0;
        foreach (var item in limit)
        {
            dataSource[i * 3] = "Fizz";
            i++;
        }

        i = 0;
        foreach (var item in limit)
        {
            dataSource[i * 5] = "Buzz";
            i++;
        }

        i = 0;
        foreach (var item in limit)
        {
            dataSource[i * 3 * 5] = "FizzBuzz";
            i++;
        }

        return dataSource[n];
    }
}
