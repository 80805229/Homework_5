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





// void Mass (int[] array)
// {
//     int index = 0;

//     while (index < array.Length)
//     {
//         array[index] = new Random().Next(0, 2);
//         index++;
//     }
// }

// void PrintArray(int[] mass)
// {
//     for (int i = 0; i < 8; i++)
//     {
//         Console.Write(mass[i] + "\t");
//     }
// }

// int[] array = new int [8];

// Mass(array);