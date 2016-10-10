public static class Program
{
    public static void Main(string[] args)
    {
        FizzBuzz fb = new DivideByZero();
        fb.Run(100);

        fb = new OneElementArray();
        fb.Run(100);

        fb = new PreComputeArray();
        fb.Run(100);
    }
}
