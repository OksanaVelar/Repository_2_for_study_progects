// Найти произведение двух матриц
int a = 2;
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
Product (mass,array);

void Product(int[,] mass, int[,] array)
{
    int k = 0;
    int l = 0;
    int m = 0;
    int n = 0;

   int[,] matrix = new int[mass.GetLength(0),array.GetLength(1)]; 
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sum = 0;
        for (int q = 0; q < matrix.GetLength(1); q++)
        {
            sum = sum + (mass[i,j] * array [j,i]);
        }
        matrix[i,j] = sum;
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
}
