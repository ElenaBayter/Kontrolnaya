Console.Clear();
string[] PrimerArray = new string[] { "medicine", "14", "table", "hey", "34", "6534", "165", "sink", "hello", "ok", "low" };
string[] NewArray = new string[PrimerArray.Length];

void ArrayWithCondition(string[] PrimarArray, string[] NewArray)
{
    int j = 0;
    for (int i = 0; i < PrimerArray.Length; i++)
    {
        Console.Write($"{PrimerArray[i]} ");
        if (PrimerArray[i].Length <= 3)
        {
            NewArray[j] = PrimerArray[i];
            j++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.WriteLine($"Primer array: ");
ArrayWithCondition(PrimerArray, NewArray);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("New array with condition:");
PrintArray(NewArray);
