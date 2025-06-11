namespace FizzBuzz;

public class FizzBuzz4 : IFizzBuzz
{
    public string Process(int number)
    {
        return (number.DivisibleBy(3), number.DivisibleBy(5)) switch
        {
            (true, true) => "FizzBuzz",
            (true, false) => "Fizz",
            (false, true) => "Buzz",
            _ => number.ToString()
        };
    }
}

static class NumberExtensions
{
    public static bool DivisibleBy(this int number, int otherNumber)
    {
        return number % otherNumber == 0;
    }
}
