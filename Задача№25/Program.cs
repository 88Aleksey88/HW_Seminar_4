Console.Clear();
Console.Write("Введите первое число:");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число:");
double number2 = Convert.ToDouble(Console.ReadLine());
double f(double number1, double number2)
{
    double result = Math.Pow(number1, number2);
    return result;
}
Console.WriteLine(f(number1,number2));