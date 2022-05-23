// Найти произведение двух матриц
int a = 4;
int b = 3;

int[,] mass = new int[a, b];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, 10);
    }
}
int[,] PrintMass(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i,j] + " ");
        }
        Console.WriteLine();
    }
    return mass;
}

int t = 3;
int l = 2;

int[,] array = new int[t, l];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}
PrintMass (mass);
Console.WriteLine();
PrintMass (array);
Console.WriteLine();
SumProduct (mass,array);

void SumProduct(int[,] mass, int[,] array)
{
int[,] matrix = new int[mass.GetLength(0),array.GetLength(1)]; 
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int q = 0; q < mass.GetLength(1); q++)
        {
            matrix[i, j] = matrix[i, j] + (mass[i, q] * array[q, j]);
        }
        
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
}
