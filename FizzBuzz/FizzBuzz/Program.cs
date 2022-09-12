// Given a number N, print out the numbers 1 through N where the following replacements are made:
// If a number is divible by 3, print "Fuzz".
// If anumber is divisible by 5, print "Buzz".
// If a number is divible by both print "FizzBuzz"
// If none are the case, print the number

var N = 47;
for (var i = 1; i <= N; i++)
{
    if (i % 5 == 0 && i % 3 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    Console.WriteLine(i);

}
