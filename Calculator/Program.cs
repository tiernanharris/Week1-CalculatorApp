Console.WriteLine("Please type in the first number followed by the Enter key");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please type in the second number followed by the Enter key");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = firstNumber +  secondNumber;

Console.WriteLine("The addition of both numbers is " + result);
Console.ReadKey();