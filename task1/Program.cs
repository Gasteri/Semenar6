using static Common.Helper;


int[] array = CreateRandomArray();
PrintArray(array);
Console.WriteLine();
int[] reversed = ReverseArray(array);
PrintArray(array);
int[] ReverseArray(int[] array)
{
    int[] reversedArray = new int[array.Length];

    for (var i = 0; i < array.Length; i++)
    {
        reversedArray[i] = array[array.Length - 1 - i];
    }

    return reversedArray;
}

