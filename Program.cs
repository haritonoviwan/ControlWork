string[] GetArrayFromUser()
{
    Console.Write("Введите количество строк в массиве: ");
    int n = int.Parse(Console.ReadLine());

    string[] inputArray = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите строку {i + 1}: ");
        inputArray[i] = Console.ReadLine();
    }
    return inputArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int index = 0; index < array.Length; index++)
    {
        if (index < array.Length - 1)
        {
            Console.Write($"{array[index]}, ");
        }
        else
        {
            Console.Write(array[index]);
        }
    }
    Console.Write("]");
}