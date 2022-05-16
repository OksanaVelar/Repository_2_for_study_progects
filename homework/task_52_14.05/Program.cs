// В каждом столбце двумерного массива целых чисел найти значение 
// среднего арифметического
int a = 3; 
int b = 3;
double sum = 0;
double result = 0;

int [,] mass = new int[a,b];
void Print (int[,] mass)
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
   
   for (int j = 0; j < mass.GetLength(1); j++)
   {
       for (int i = 0; i < mass.GetLength(0); i++)
       {
           sum = sum + mass[i,j];
       }
   result = sum/mass.GetLength(0);
   Console.WriteLine();
   Console.Write(Math.Round(result, 2) + " ");
   }
}
Print(mass);


