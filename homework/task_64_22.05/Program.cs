// Задать значения M,N и вывести все натуральные числа в промежутке между ними
Console.WriteLine("Обозначте начало убывающего массива чисел (n) - введите число его верхней границы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Обозначте конец массива (m) - введите число его нижней границы: ");
int m = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int n, int m)
{
    if(m-1 == n)
    {
    return;
    }
    Console.Write(n + " ");
    PrintNumbers(n-1, m);
}
Console.WriteLine("________________");
Console.WriteLine();
Console.WriteLine("Массив натуральных чисел в заданном промежутке: ");
PrintNumbers(n,m);





