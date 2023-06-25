Console.Write($"Введите длинну массива: ");
int arrayTestLength = Convert.ToInt32(Console.ReadLine());
string[] testArray = new string[arrayTestLength];
int arrayTempLength = 0;

for (int i=0; i<arrayTestLength; i++)
{
    Console.Write($"Введите значение {i}-го индекса массива: ");
    testArray[i] = Console.ReadLine()!.ToString();
}

Console.WriteLine($"Исходный массив:");
Console.WriteLine(string.Join(", ", testArray));

for (int i=0; i<testArray.Length; i++)
{
    if (testArray[i].Length<=3)
    {
        arrayTempLength++;      
    }
}

int arrayTempIndex = 0;
string[] arrayTemp = new string[arrayTempLength];
for (int i=0; i<testArray.Length; i++)
{
    if (testArray[i].Length<=3)
    {
        arrayTemp[arrayTempIndex]=testArray[i];
        arrayTempIndex++;
    }
}

Console.WriteLine($"Полученный массив:");
Console.WriteLine(string.Join(", ", arrayTemp));