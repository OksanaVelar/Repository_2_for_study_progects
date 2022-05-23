// Заполнить спирально массив 4 / 4 
// int b = 4;
// int c = 4;

// int[,] mass = new int[b,c];
// for (int i = 0; i < length; i++)
// {
    
// }

int[,] Snail = new int[7, 7];
int s = 1;
int j = 0;
int i = 0;
// for (int i = j; i < 4; i++)
// {
    for (j = 0; j < 4; j++)
    {
        Snail[0,j] = s;
        s++;
    }
    for (i = 1; i < 4; i++)
    {
        Snail[i, 3] = s;
        s++;
    }
    for (j = 2; j >= 0; j--)
    {
        Snail[3, j] = s;
        s++;
    }
    for (i = 2; i > 0; i--)
    {
        Snail[i, 0] = s;
        s++;
    }
    for (j = 1; j < 3; j++)
    {
        Snail[1,j] = s;
        s++;
    }
    for(j = 2; j > 0; j--)
    {
        Snail[2, j] = s;
        s++;
    }
//     break;

// }
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
    Console.WriteLine("------------------");
    return matr;
}
PrintArray(Snail);