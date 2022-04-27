// В массиве вещественных чисел найти разность между max и min значениями
Console.WriteLine("Дан массив случайных чисел: ");
double[] mass = new double[5];

for(int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().NextDouble();
    Console.WriteLine(mass[i]);
}

Console.WriteLine();

double temp;
for(int i = 0; i < mass.Length - 1; i++)
{
for(int j = i+1; j < mass.Length; j++)

if(mass[i] > mass[j])
{
    temp = mass[i];
    mass[i] = mass[j];
    mass[j] = temp;
}
}
Console.WriteLine("Отсортированный массив:");

for(int i = 0; i < mass.Length; i++)
{
   Console.WriteLine(mass[i]);
}
Console.WriteLine();
double A = mass[0];
double B = mass[mass.Length - 1];
double Z = B - A;
Console.WriteLine($"Разность max и min значений в массиве = {Z}");

