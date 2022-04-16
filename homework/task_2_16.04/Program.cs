// вывод случайного трёхзначного числа и удаление второй цифры в нем

int a = new Random().Next(222, 799);
Console.WriteLine($"Исходное число: {a}");
int b = a%10;
int c = a/100;

Console.WriteLine($"Новое число:{c}{b}");
