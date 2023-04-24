
int number_from_user = UserCreateArray("Введите число ");

int UserCreateArray(string numbers)
{
    System.Console.Write(numbers);
    int i;
    while(!int.TryParse(System.Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число");
    }
    return i;
}

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
        System.Console.WriteLine(numbers[i]);
    }
    System.Console.WriteLine();
}


void FillArray ()
{
    int[] array = new int [number_from_user];
    FillRandom(array);
    PrintArray(array);
}

FillArray();


