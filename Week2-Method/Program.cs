Void();
int remainder = GenerateRandomNumber();
Console.WriteLine($"The remainder of the generated random number divided by 2: {remainder}");
int result = MultiplyNumbers(5, 10);
Console.WriteLine($"The result of 5 and 10: {result}");
PrintWelcome("Gizem", "Gunes");

// Void method that does not return any value
// Prints my favorite song lyrics to the console.
static void Void()
{
    Console.WriteLine("My favorite song lyrics: New person same old mistakes :)");
}
// Method that returns an integer value
// Generates a random number and returns the remainder of dividing that number by 2.
static int GenerateRandomNumber()
{
    Random random = new Random();
    int randomNumber = random.Next(1,100);
    Console.WriteLine($"Generated random number: {randomNumber}");
    return randomNumber % 2;
}
// Returns the product of two numbers passed as parameters.
static int MultiplyNumbers(int number1, int number2)
{
    return number1 * number2;
}
// Takes first name and last name and prints "Welcome {first name} {last name}" to the console.
static void PrintWelcome(string firstName, string lastName)
{
    Console.WriteLine($"Welcome {firstName} {lastName}");
}
