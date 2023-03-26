string[] MainArray(string[] arr)
{
    string[] mainarray = new string[size];
    for (int i = 0; i < mainarray.Length; i++)
    {
        Console.Write($"Введите {i + 1} строку: ");
        mainarray[i] = Console.ReadLine();
    }
    return mainarray;
}

void ShowArray(string[] array)//показать массив
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

string[] arr = ("fg", "jkl");

ShowArray(arr);