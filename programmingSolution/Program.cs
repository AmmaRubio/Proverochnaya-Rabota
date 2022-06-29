// input: 
string[] input = { "1234", "1679", "089", "Maksim", "Max" };

int resultLength = 0;

// Getting length of result array
int lengthOfResult(string[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result++;
        }
        i++;
    }
    return result;
}

// Populating result array 
string[] result = keepingSmallerThanThreeChar(input);
string[] keepingSmallerThanThreeChar(string[] array)
{
    string[] result = new string[lengthOfResult(array)];
    int j = 0; // j - indexing of result array
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[j] = array[i];
            j++;
        }
        i++;
    }
    return result;
}

// Printing array
void printArrayInLine(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write($"'{array[i]}'");
        }
        else
        {
            Console.Write($"'{array[i]}', ");
        }
    }
    Console.Write("]");
}

printArrayInLine(input); 
Console.Write(" -> ");
printArrayInLine(result); 