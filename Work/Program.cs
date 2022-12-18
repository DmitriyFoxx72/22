string[] array1 = new string[6] {"hello", "23", "23232", "world", "Fin","res"};
string[] array2 = new string[array1.Length];

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }       
    Console.WriteLine();
}

void SecondArrayThree(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
SecondArrayThree(array1, array2);
Console.Write("Новый массив из строк, длина которых меньше, либо равна 3 символам :");
Console.WriteLine();
ShowArray(array2);


