// Заполнить спирально массив 4 / 4 

int a = 4;
int b = 4;
int[,] Spiral = new int[a, b];

int step = 1;
int start = Spiral.GetLength(0)/2; 
int newpoint; 

PrintArray(Spiral);

for (int i = start; i <= Spiral.GetLength(0);i++)
{
    for (int j = start; j <= Spiral.GetLength(1);j++)
    {   
        for (int k = start; k <= Spiral.GetLength(0);k--)
        {
           for (int z = start; z <= Spiral.GetLength(0);z--)
           {
               newpoint = start+step;
           }
        }
    }
}
int [,] PrintArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i,j] + " ");
        }
        Console.WriteLine();
    }
    //Console.WriteLine("------------------");
    return matr;
}


