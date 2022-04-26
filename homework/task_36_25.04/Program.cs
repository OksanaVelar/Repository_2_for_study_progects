//Задан массив со случайными числами. 
//Требуется показать сумму элементов на нечетных позициях
Console.Write("Дан массив случайных чисел: ");
int[] mass = new int[12];
int sum = 0;

for(int i = 0; i < mass.Length; i++)
{
   mass[i] = new Random().Next(200, 250);
   Console.Write(mass[i]+ " ");
}
Console.WriteLine();
for(int i = 1; i < mass.Length; i = i + 2)
{
    sum++;
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве = {sum}");
Console.WriteLine();

