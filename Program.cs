//string[] array =  {"hello", "2", "world", ":-)"};
string[] array = {"1234", "1567", "-2", "computer science"};
//string[] array = {"Russia", "Denmark", "Kazan"};
int size = array.Length;
string[] newarray = new string[size];
int length = 3;
for (int i = 0; i < size; i++)
{
    if (array[i].Length <= length)
    {
        newarray[i] = array[i];
    }
}
Console.WriteLine();
PrintArray(newarray);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

