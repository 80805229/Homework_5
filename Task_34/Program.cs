// Написать программу для замены элементов массива на противоположные.(поменять местами первое число массива с последним и т.д.)

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
int i2 = array1.Length - 1;

while (i1 != i2)
{

    int n = array1[i1];
    array1[i1] = array1[i2];
    array1[i2] = n;
    i1++;
    i2--;

}
Console.WriteLine();
PrintArray(array1);