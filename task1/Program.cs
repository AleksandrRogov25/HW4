System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите степень: ");
int exponent = Convert.ToInt32(Console.ReadLine());

int Power(int number, int exponent)
{
    int result = 1;
    for (int i = 0; i < exponent; i++)
    {
        result *= number;
    }
    return result;
}
int result = Power(number, exponent);
System.Console.WriteLine($"Число {number} в степени {exponent} равно {result}");

