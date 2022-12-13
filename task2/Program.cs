using static Common.Helper;
/*Задача 42: 
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
 45 -> 101101 , 3 -> 11 , 2 -> 10*/
int number = InputInt();
int InputInt()
{
    bool isParsed = int.TryParse(Console.ReadLine(), out int num);

    if (!isParsed)
    {
        Console.WriteLine("Incorrect number");
        return -1;
    }
    else
    {
        return num;
    }
}
int[] binNumber = TenToBin(number);
PrintArray1(binNumber);
int[] TenToBin(int num)
{
    int numRange = 0;
    int numTemp = num;  
    while (numTemp > 0)
    { 
        numTemp /= 2;
        numRange++;
        Console.WriteLine(numRange);
    }
    int length = numRange;
    //return numRange;
    int[] arr = new int[length];
    for(int i = length - 1;i >= 0; i--)
    {
        arr[i] = num % 2;
        num = num / 2;
    }
    
    return arr;
}

/*string GetttoBin(int number) //преобразование через строчку
{
    string binar = string.Empty;
    while(number != 0)
    {
        binar = number % 2 + binar;
        number /= 2;
    }
    return binar;
}*/

/*int a = InputInt();
int b = InputInt();
int c = InputInt();

bool res = IsTriangle(a, b, c);
Console.WriteLine(res);

bool IsTriangle(int a, int b, int c)
{
    return(a <(b + c) && b < (a + c) && c < (a + b));
}*/
