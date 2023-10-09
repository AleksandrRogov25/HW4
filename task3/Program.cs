System.Console.Write("Введите длину массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] SetArray(int lenght, int min, int max)
{
int[] array = new int[lenght];
Random random = new Random();

    for (int i = 0; i < lenght; i++)
    {
        array[i] = random.Next(min, max);
    }
    return array;
  }
  int[] array = SetArray(lenght, min, max);
System.Console.WriteLine(string.Join(", ", array));


