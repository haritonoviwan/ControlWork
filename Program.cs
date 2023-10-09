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