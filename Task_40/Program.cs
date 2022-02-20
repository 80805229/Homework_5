// В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.

void PrintArray(double[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write(mass[i] + "\t");
    }
}

double[] array = { 8.6, 5.9, 8.4, 2.6, 7.6, 4.1, 6.8 };
PrintArray(array);

Console.WriteLine();

int ind = 1;
double max = array[0];
double min = array[0];
double dif = 0;

while (ind < array.Length)
{
    if (array[ind] > max)
    {
        max = array[ind];
    }

    if (array[ind] < min)
    {
        min = array[ind];
    }
    ind++;
    dif = max - min;
}



Console.WriteLine("Максимальное число равно " + max);
Console.WriteLine("Минимальное число равно " + min);
Console.WriteLine("Разница между max и min равна " + dif);

