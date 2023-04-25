void FillRandom(int[] numbers)
{
    Random rnd = new Random();
    for(int i = 0; i < numbers.Length; i++)
    numbers[i] = rnd.Next(1, 9);
}


void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        System.Console.WriteLine($"{numbers[i]} ");
    }
    System.Console.WriteLine();  
}


int Sum(int[] numbers)
{
    int summ = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] % 2 == 0)
        {
            summ += 1;
        }
    }
    return summ;
}


int IndexSum(int[] numbers)
{
    int summ = 0;
    for(int i = 1; i < numbers.Length; i = i + 2)
    {
        summ = summ + numbers[i];
    }
    return summ;
}

 
void CreateArray()
{
    int size = 7;
    int[] array = new int[size];
    FillRandom(array);
    PrintArray(array);
    Sum(array);
    System.Console.WriteLine(Sum(array));
    IndexSum(array);
    System.Console.WriteLine(IndexSum(array));
}

CreateArray();
