Console.Clear();

int[] array = {1, 9, 2, 8, 3, 4, 7, 5, 6, 10};
int n = 0;

int Array(int j)
{
    while(array[n] != j)
    {
        n++;
    }
    return n;
}

Console.Write("Введите число от 1 до 10: ");
int i = int.Parse(Console.ReadLine()!);

Console.Write($"Число {i} находится в array[{Array(i)}]");