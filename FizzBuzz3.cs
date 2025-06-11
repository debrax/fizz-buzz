namespace FizzBuzz;

public class FizzBuzz3 : IFizzBuzz
{
    public string Process(int number)
    {
        var fizzBuzzNumber = new FizzBuzzNumber(number);

        if (fizzBuzzNumber.DivisibleBy(15))
            return DivisibleBy15Word;

        if (fizzBuzzNumber.DivisibleBy(3))
            return DivisibleBy3Word;

        if (fizzBuzzNumber.DivisibleBy(5))
            return DivisibleBy5Word;

        return fizzBuzzNumber.GetLabel();
    }

    const string DivisibleBy15Word = "FizzBuzz";
    const string DivisibleBy3Word = "Fizz";
    const string DivisibleBy5Word = "Buzz";
}

class FizzBuzzNumber
{
    readonly int number;

    public FizzBuzzNumber(int number)
    {
        if (number <= 0)
            throw new ArgumentOutOfRangeException(nameof(number));

        this.number = number;
    }

    public bool DivisibleBy(int otherNumber)
    {
        return number % otherNumber == 0;
    }

    public string GetLabel()
    {
        return number.ToString();
    }
}
