namespace FizzBuzz;

public class FizzBuzz2 : IFizzBuzz
{
    public string Process(int number) =>
        number % 3 == 0
            ? number % 5 == 0
                ? "FizzBuzz"
                : "Fizz"
            : number % 5 == 0
                ? "Buzz"
                : number.ToString();
}
