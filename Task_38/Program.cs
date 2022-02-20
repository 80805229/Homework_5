// Найти сумму чисел одномерного массива, стоящих на нечётной позиции.

void Mass(int[] array)
{
    int index = 0;

    while (index < array.Length)
    {
        array[index] = new Random().Next(0, 1000);
        index++;
    }
}

void PrintArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write(mass[i] + "\t");
    }
}


Console.Write("Введите длину массива ");
int n = int.Parse(Console.ReadLine());

int[] array2 = new int[n];

Mass(array2);
PrintArray(array2);

int i2 = 0;
int sum = 0;

while (i2 < n)
{
    if (array2[i2] % 2 != 0)
    {
        sum = sum + array2[i2];

    }

    i2++;

}
Console.WriteLine(" ");
Console.WriteLine("Сумма нечетных чисел равна " + sum);



