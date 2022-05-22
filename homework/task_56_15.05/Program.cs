// В массиве найти строчку с наименьшей суммой значений элементов

int a = 3;
int b = 3;

int[,] mass = new int[a, b];
int count1 = mass.GetLength(1);
int count0 = mass.GetLength(0);
for (int i = 0; i < count0; i++)
{
    for (int j = 0; j < count1; j++)
    {
        mass[i, j] = new Random().Next(1, 10);
    }
}
int[,] PrintMass(int[,] mass)
{
    for (int i = 0; i < count0; i++)
    {
        for (int j = 0; j < count1; j++)
        {
            Console.Write(mass[i, j] + " ");
        }
        Console.WriteLine();
    }

    return mass;
}
PrintMass(mass);
Sum(mass);
void Sum(int[,] array)
{
    int temp = 1000;
    int minstring = 0;
    
    for (int i = 0; i < count0; i++)
    {
        int sum = 0;
        for (int j = 0; j < count1; j++)
        {
            sum = sum + array[i, j];
        }
        if (sum < temp)
        {
            temp = sum;
            minstring = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой: {minstring + 1}");
}


