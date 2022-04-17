// Ввод цифры и проверка ее соответствия субботе и воскресенью
int n = 7;
int g = 6;
Console.WriteLine("Введите номер дня недели и нажмите клавишу Enter");
int usernumber = int.Parse(Console.ReadLine());

if((usernumber == g)|(usernumber == n))
{
Console.WriteLine("Введенный Вами номер соответствует выходному дню");
}
else
{
Console.WriteLine("Введенный Вами номер не соответствует выходному дню");
}
