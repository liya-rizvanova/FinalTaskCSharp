Console.Clear();

int TakeEnteredNumber(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int userArray = TakeEnteredNumber("Введите количество элементов массива: ");
void GetUserArray(string[] userArray)
{
    for (int i = 0; i < userArray.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        userArray[i] = Console.ReadLine();
    }
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"‘{arr[i]}’");
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.Write("]");
}

string[] stringArray = new string[userArray];
GetUserArray(stringArray);

System.Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Blue;
PrintArray(stringArray);

Console.Write("");
Console.ForegroundColor = ConsoleColor.Green;
System.Console.Write(" -> ");

string[] ConditionalArray(string[] array)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            count++;
    }
    string[] result = new string[count];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            result[index++] = array[i];
    }
    return result;
}

PrintArray(ConditionalArray(stringArray));