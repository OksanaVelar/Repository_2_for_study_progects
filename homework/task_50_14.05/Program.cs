// В двум.масс. даны позиции элемента. Необходимо вывести его значение 
// или указать, что такого элемента в массиве нет
int a = 3; 
int b = 3;

int [,] mass = new int[a,b];
{
   for (int i = 0; i < mass.GetLength(0); i++)
   {
       for (int j = 0; j < mass.GetLength(1); j++)
       {
           mass[i,j] = new Random().Next(1,100);
           Console.Write(mass[i,j] + " ");
       }
       Console.WriteLine();
   }
}

void Look (int[,] matrix, int x, int y)
    {
        if(x < matrix.GetLength(0)& y < matrix.GetLength(0))
        Console.WriteLine($"искомый элемент {matrix[x,y]}");
        else Console.WriteLine("Искомого элемента не существует");
    }

Console.WriteLine ("Введите номера столбца и строки элемента");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
Look (mass, A, B);



