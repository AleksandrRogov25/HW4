System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int Power(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}
int result = Power(number);
System.Console.WriteLine($"Сумма всех чисел в цифре {number} равна {result}");

