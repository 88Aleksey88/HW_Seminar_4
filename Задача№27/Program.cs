Console.Clear();
Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int f(int number)
{
    int result = 0;
    while (number > 0)
        {
        result = result + (number % 10); 
        number /=10;
        }       
    return result;
}
Console.WriteLine(f(number));
