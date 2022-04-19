// Проверка числа - является ли полиндромом
Console.WriteLine("Введите пятизначное число и нажмите клавишу Enter");
int usernumber = int.Parse(Console.ReadLine());
int a = usernumber%10;
int b = usernumber/10;
int c = usernumber/100;
int d = usernumber/1000;
int r = usernumber/10000;

if((a==r)&(b==d))
{
    Console.WriteLine("Введенное Вами число является полиндромом");
}
else
{
    Console.WriteLine("Введенное Вами число не является полиндромом");
}
