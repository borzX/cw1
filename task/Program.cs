string[] testArray = new string[4]{"Hello", "2", "world", ":-)"};
int arrayTempLength = 0;

for (int i=0; i<testArray.Length; i++)
{
    if (testArray[i].Length<=3)
    {
        arrayTempLength++;
        Console.WriteLine($"Длина а {arrayTempLength}");
        
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
        Console.WriteLine($"Длина б {arrayTempLength}");
    }
}

Console.WriteLine(string.Join(", ", arrayTemp));