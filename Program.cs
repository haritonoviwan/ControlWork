Console.Clear();
string[] myArray = GetArrayFromUser();
string[] resultArray = FilterShortStrings(myArray);
PrintArray(myArray);
Console.Write(" -> ");
PrintArray(resultArray);

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

string[] FilterShortStrings(string[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            counter++;
        }
    }
    string[] newArray = new string[counter];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;
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