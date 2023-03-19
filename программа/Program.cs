/* Программа, которая из имеющегося массива строк (задается с клавиатуры) формирует массив из строк,
длина которых меньше или равна 3 символам*/
using static System.Console;

Clear();
string[] array = InputStringArray();
WriteLine("Входной массив:");
PrintStringArray(array);
string[] resultArray = ArrayOfNotMoreThan3CharsStrings(array);
WriteLine("Выходной массив:");
PrintStringArray(resultArray);


void PrintStringArray(string[] arr)
{
    WriteLine($"[{String.Join(", ", arr)}]");
}

string[] InputStringArray()
{
    Write("Введите массив строк через пробелы: ");
    string line = ReadLine();
    string[] result = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    return result;
}

string[] ArrayOfNotMoreThan3CharsStrings(string[] inputArray)
{
    int count = 0;
    foreach (string line in inputArray)
    {
        if (line.Length <= 3)
        {
            count ++;
        }
    }
    string[] result = new string[count];
    for (int i = 0, j = 0; j < count; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            result[j] = inputArray[i];
            j++;
        }
    }
    return result;
}