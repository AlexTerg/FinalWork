string[] array = { "hello", "2", "world", ":-)" };

PrintArray(array);
Console.WriteLine();
PrintArray(FindStringMoreThanThree(array));

string[] CreateEmptyArray(string[] arr)
{
    int cnt = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            cnt++;
        }
    }
    string[] array = new string[cnt];
    return array;
}

string[] FindStringMoreThanThree(string[] arr)
{
    array = CreateEmptyArray(arr);
    for (int i = 0, j = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            array[j] = arr[i];
            j++;
        }
    }
    return array;
}

void PrintArray(string[] array)
{
    foreach (var item in array)
    {
        Console.WriteLine(item);
    }
}