//Введены числа. Надо установить сколько чисел больше "0"
int summ = 0;
int[] mass = new int[10];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-10, 10);
    Console.Write(mass[i]+ " ");
    if( mass[i] > 0)
{
summ = summ+1;
}
}
Console.WriteLine();
Console.WriteLine($"Положительных чисел в заданном массиве - {summ}");

// int N = Convert.ToInt32(Console.ReadLine());
// int[] Fillarray(int N);
// {
//     int[] array = new int[N];
// for (int i = 0; i < N; i++)
// {
//    array[i] = new Random().Next(-10, 10); 
// }
// return array;
// }
// void printArray(int[] R)
// {
//     for (int i = 0; i < R.Length; i++)
//     {
//         Console.Write(R[i]+ " ");
//     }
//     Console.WriteLine();
// }

// printArray(Fillarray(N));