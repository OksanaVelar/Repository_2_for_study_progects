// Задать трехмерный массив из неповторяющихся двузначных чисел. 
// Вывести строки массива с добавлением индекса каждого элемента.
int a = 2; 
int b = 3;
int c = 3;

int[,,] mass = new int[a,b,c];

   int count1 = mass.GetLength(1);
   int count0 = mass.GetLength(0);
   int count2 = mass.GetLength(2);
   int r = 20;
    for (int i = 0; i < count0; i++)
    {
        for (int j = 0; j < count1; j++)
        {
            for (int k = 0; k < count2; k++)
            {
                mass[i,j,k] = r;
                r = r+2;
            }
        }
    }

int[,,] PrintMass(int[,,] mass)
{
    for (int i = 0; i < count0; i++)
    {
        for (int j = 0; j < count1; j++)
        {
            for (int k = 0; k < count2; k++)
            {
               Console.Write($"{mass[i,j,k]}({i}, {j}, {k}) "); 
            }
            Console.WriteLine();
        }
    }
    
    return mass;
}
PrintMass (mass);
Console.WriteLine();

