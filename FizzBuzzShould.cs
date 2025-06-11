using Xunit;

namespace FizzBuzz;

public class FizzBuzzShould
{
    readonly IFizzBuzz fizzBuzz = new FizzBuzz4();

    [Fact]
    void Return_Fizz_when_number_divisible_by_3()
    {
        foreach (var number in new[] { 3, 6, 9, 12, 18, 999 })
            Assert.Equal("Fizz", fizzBuzz.Process(number));
    }

    [Fact]
    void Return_Buzz_when_number_divisible_by_5()
    {
        foreach (var number in new[] { 5, 10, 20, 25, 35, 995 })
            Assert.Equal("Buzz", fizzBuzz.Process(number));
    }

    [Fact]
    void Return_FizzBuzz_when_number_divisible_by_3_and_5()
    {
        foreach (var number in new[] { 15, 30, 45, 60, 75, 990 })
            Assert.Equal("FizzBuzz", fizzBuzz.Process(number));
    }

    [Fact]
    void Return_number_otherwise()
    {
        foreach (var number in new[] { 1, 2, 4, 8, 11, 998 })
            Assert.Equal(number.ToString(), fizzBuzz.Process(number));
    }

    //[Fact]
    //void Return_Wazza_when_number_divisible_by_7()
    //{
    //    foreach (var number in new[] { 7, 14, 21, 28, 35 })
    //        Assert.Equal("Wazza", fizzBuzz.Process(number));
    //}

    //[Fact]
    //void Return_formatted_number_otherwise()
    //{
    //    foreach (var number in new[] { 1, 2, 4, 8, 11, 998 })
    //        Assert.Equal($"*{number}*", fizzBuzz.Process(number));
    //}
}
