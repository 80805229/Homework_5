// Написать программу для замены элементов массива на противоположные. (на отрицательное значение)

void PrintArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write(mass[i] + "\t");
    }
}

int[] array1 = { 1, 5, 8, 2, 9, 4, 6 };
PrintArray(array1);

int i1 = 0;

while (i1 != array1.Length)
{

    int n = array1[i1];
    array1[i1] = - array1[i1];
    i1++;

}
Console.WriteLine();
PrintArray(array1);