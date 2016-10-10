using NUnit.Framework;

[TestFixture]
public class DivideByZeroTests
{
    FizzBuzz _fizzBuzz = new DivideByZero();

    [Test()]
    public void Should_Return_Input_By_Default()
    {
        Assert.AreEqual("1", _fizzBuzz.Get(1));
        Assert.AreEqual("2", _fizzBuzz.Get(2));
        Assert.AreEqual("4", _fizzBuzz.Get(4));
        Assert.AreEqual("7", _fizzBuzz.Get(7));
    }

    [Test]
    public void Should_Return_Fizz_When_Divisible_By_3()
    {
        Assert.AreEqual("Fizz", _fizzBuzz.Get(3));
        Assert.AreEqual("Fizz", _fizzBuzz.Get(6));
        Assert.AreEqual("Fizz", _fizzBuzz.Get(9));
        Assert.AreEqual("Fizz", _fizzBuzz.Get(12));
    }

    [Test]
    public void Should_Return_Buzz_When_Divisible_By_5()
    {
        Assert.AreEqual("Buzz", _fizzBuzz.Get(5));
        Assert.AreEqual("Buzz", _fizzBuzz.Get(10));
        Assert.AreEqual("Buzz", _fizzBuzz.Get(20));
        Assert.AreEqual("Buzz", _fizzBuzz.Get(25));
    }

    [Test]
    public void Should_Return_FizzBuzz_When_Divisible_By_15()
    {
        Assert.AreEqual("FizzBuzz", _fizzBuzz.Get(15));
        Assert.AreEqual("FizzBuzz", _fizzBuzz.Get(30));
        Assert.AreEqual("FizzBuzz", _fizzBuzz.Get(45));
        Assert.AreEqual("FizzBuzz", _fizzBuzz.Get(60));
    }
}
