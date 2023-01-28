/* Напишите программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать
на старте выполнения алгоритма*/

// set input data
string text = "A string is a sequential collection of characters that's used to represent text." +
                " A String object is a sequential collection of System.Char objects that represent a string;" +
                " a System.Char object corresponds to a UTF-16 code unit. The value of the String object is " +
                "the content of the sequential collection of System.Char objects, and that value is immutable " +
                "(that is, it is read-only). For more information about the immutability of strings, see the " +
                "Immutability and the StringBuilder class section. The maximum size of a String object in memory " +
                "is 2-GB, or about 1 billion characters.";

Console.Clear();
// output string array taken from original string
PrintData("ИСХОДНЫЙ МАССИВ:");
Console.ForegroundColor = ConsoleColor.Yellow;
PrintArray(FillArrayFromTxt(text)); Console.WriteLine();
Console.ResetColor();

// output resulting array
PrintData("ИТОГОВЫЙ МАССИВ:");
Console.ForegroundColor = ConsoleColor.Green;
PrintArray(CreateArrayWithSelectedItems(FillArrayFromTxt(text)));
Console.ResetColor();

// METHODS
void PrintData(string msg)      // print data method
{
    Console.WriteLine(msg);
}

void PrintArray(string[] col)      // print array method
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < (count - 1))
    {
        Console.Write(col[position]); Console.Write(", ");
        position++;
    }
    Console.Write((col[count - 1]) + "]");
    Console.WriteLine();
}

string[] FillArrayFromTxt(string line) // method for fill string array from text 
{
    line = line.Replace(",", "").Replace(".", "");
    string[] strArray = line.Split(" ");
    return strArray;
}

string[] CreateArrayWithSelectedItems(string[] arr) // method for creating new array with selected elements from input array
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            count++;        // counting elements with lenght < 4 chars
        }
    }

    string[] resultArr = new string[count];     // creating array with lenght = numbers of elements with lenght < 4 chars in input array
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {

        if (arr[i].Length < 4)
        {
            resultArr[index] = arr[i];      // coping elements to new array
            index++;
        }
    }
    return resultArr;
}




