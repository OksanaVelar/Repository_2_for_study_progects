﻿//Вывод третьей цифры заданного числа или сообщение об ее отсутствии
int a = 7;
Console.WriteLine($"Задано число {a}");
int b = a % 1000;
int c = a % 10;

if(b > 0) 
{
    Console.WriteLine($"Третья цифра в заданном числе - {c}");
}
else
{
    Console.WriteLine("Третьей цифры в заданном числе нет");
}


