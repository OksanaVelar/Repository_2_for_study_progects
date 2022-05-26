//Задать значения M N , найти сумму натуральных значений в заданном промежутке
Console.WriteLine("Обозначте начало убывающего массива чисел (n) - введите число его верхней границы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Обозначте конец массива (m) - введите число его нижней границы: ");
int m = Convert.ToInt32(Console.ReadLine());
int sum = 0;
void PrintNumbers(int n, int m)
{
    if (m - 1 == n)
    {
        return;
    }
        Console.Write(n + " ");
    
    PrintNumbers(n - 1, m);
    if(n>0)
    {
    sum = sum+n;
    }
    //Console.WriteLine();
    Console.Write(" - " + sum);
}

Console.WriteLine();
Console.WriteLine("Массив натуральных чисел в заданном промежутке: ");


PrintNumbers(n, m);





