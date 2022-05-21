// В двумерном массиве упорядочить по убыванию элементы каждой строки
int a = 2; 
int b = 3;

int[,] mass = new int[a,b];

   int count1 = mass.GetLength(1);
   int count0 = mass.GetLength(0);
    for (int i = 0; i < count0; i++)
    {
        for (int j = 0; j < count1; j++)
        {
            mass[i,j] = new Random().Next(1,10);
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
    Console.WriteLine("------------------");
    return matr;
}

Console.WriteLine();
int[,] SelectionSort(int[,] mass)
{
  int count1 = mass.GetLength(1);
  int count0 = mass.GetLength(0);

    for (int i = 0; i < count0; i++)
    {
        for (int j = 0; j < count1-1; j++)
        {
            for (int k = j+1; k < count1; k++)
            {
                if(mass[i,k] > mass[i,j])
                {
                    int temporary = mass[i,j];
                    mass[i,j] = mass[i,k];
                    mass[i,k] = temporary;
                }
            }
        }
    }
    return mass;
}

PrintArray (mass);
PrintArray (SelectionSort(mass));


