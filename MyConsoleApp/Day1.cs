
namespace MyConsoleApp;

    
public static class Day1 {
public static void P1() {
// Program 1
Console.WriteLine("Enter first Number :");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Operator (+ , - , * , /) ");

char ops = Console.ReadKey().KeyChar;
Console.WriteLine();

Console.WriteLine("Enter second Number :");
double num2 = Convert.ToDouble(Console.ReadLine());

double result = 0;

switch(ops)
{
    case '+' : result = num1 + num2; break;
    case '-' : result = num1 - num2; break;
    case '*' : result = num1 * num2; break;
    case '/' : result = num2 != 0 ? num1 / num2 :  double.NaN ; break;
    default : Console.WriteLine("Invalid Operator");return;
}

Console.WriteLine($"{num1} {ops} {num2} = {result}");
}

//°F = (°C × 9/5) + 32
//°C = (°F - 32) × 5/9
public static void P2()
    {
        Console.WriteLine("For Convert Celsius to Fahrenheit press F else C");
        char ops = Console.ReadKey().KeyChar;
        if(ops == 'C')
        {
            Console.WriteLine("Provide Fahrenheit Value :");
            double FahrenheitValue = Convert.ToDouble(Console.ReadLine());
            double CelsiusValue = (FahrenheitValue - 32 ) * (5.0/9.0);
            Console.WriteLine($" {FahrenheitValue} °F = {CelsiusValue} °C");
        }
        else
        {
            Console.WriteLine("Provide Celsius Value :");
            double CelsiusValue = Convert.ToDouble(Console.ReadLine());
            double FahrenheitValue = (CelsiusValue * 1.8) + 32;
            Console.WriteLine($" {CelsiusValue} °C = {FahrenheitValue} °F");
        }
        
    }

}


