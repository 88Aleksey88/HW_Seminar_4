void InputArray (string []array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = Console.ReadLine();
}
Console.Clear();
string []array = new string[8];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");