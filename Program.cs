/* Напишите программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать
на старте выполнения алгоритма*/

string text = "A string is a sequential collection of characters that's used to represent text."+ 
                "A String object is a sequential collection of System.Char objects that represent a string"+
                "a System.Char object corresponds to a UTF-16 code unit. The value of the String object is "+
                "the content of the sequential collection of System.Char objects, and that value is immutable "+
                "(that is, it is read-only). For more information about the immutability of strings, see the "+
                "Immutability and the StringBuilder class section. The maximum size of a String object in memory "+
                "is 2-GB, or about 1 billion characters.";


Console.WriteLine (text);
string [] mainArray = FillArrayFromTxt (text);
 PrintArray(mainArray);


// METHODS
int ReadData(string msg)        // input data method
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

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

string [] FillArrayFromTxt (string line) // method for fill string array from text 
{
    line = line.Replace(",", "");
    string[] names = line.Split(" ");
    return names;
}





