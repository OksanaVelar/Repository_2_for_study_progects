// Задать двум.масс. размером m*n, заполненный случайными вещественными числами
int n = 5; 
int m = 5;

double [,] mass = new double[m,n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = Math.Round (new Random().NextDouble()*100,3);
        Console.Write(mass[i,j] + " ");
    }
    Console.WriteLine();
}

