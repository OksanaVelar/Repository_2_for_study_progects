// Задан массив со случайными трехзначными числами. 
//Требуется показать кол-во четных чисел в нем.
Console.Write("Дан массив случайных чисел: ");
int[] mass = new int[10];
int sum = 0;
for(int i = 0; i < mass.Length; i++)
{
   mass[i] = new Random().Next(200, 211);
   Console.Write(mass[i]+ " ");
}
Console.WriteLine();
for(int i = 0; i < mass.Length; i++)
{
    if(mass[i]%2 == 0)
    {
        //sum += mass[i]; 
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма четных чисел в массиве = {sum}");
Console.WriteLine();



