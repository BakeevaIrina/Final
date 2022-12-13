void Array (string []array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            Console.WriteLine(array[i] + " ");
        }
    }
}

string[] arr = new string[] {"hello", "2", "world", ":)"};
Array(arr);