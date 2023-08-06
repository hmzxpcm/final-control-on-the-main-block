string[] arr = new string[] { "123", "1234", "234", "2356" };
int maxLength = 3;

void PrintStringArray(string[] stringsArray)
{
    for (int i = 0; i < stringsArray.Length; i++)
    {
        Console.Write(stringsArray[i]);

        if (i + 1 != stringsArray.Length) Console.Write(", ");
    }
}

string[] GetStringsByMaxLength(string[] stringsArray, int maxLength)
{
    return Array.FindAll(stringsArray, (str) => str.Length <= maxLength);
}

PrintStringArray(
GetStringsByMaxLength(arr, maxLength)
);
