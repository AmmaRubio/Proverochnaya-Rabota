// input: 
string[] input = { "1234", "1679", "089", "Maksim", "Max" };

int resultLength = 0;

// Getting length of result array
resultLength = lengthOfResult(input); 
 int lengthOfResult(String[] array){
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

