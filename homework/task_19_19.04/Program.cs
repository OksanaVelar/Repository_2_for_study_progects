// Проверка числа - является ли полиндромом
Console.WriteLine("Введите пятизначное число и нажмите клавишу Enter");
int usernumber = int.Parse(Console.ReadLine());
int a = usernumber%100;
int b = usernumber/1000;
int c = a%10;
int r = a/10;
int t = b%10;
int i = b/10;

if((i==c)&(t==r)) //сравнение символов равноудаленных от центра "c"
{
    Console.Write("Введенное Вами число является полиндромом");
}
else
{
    Console.Write("Введенное Вами число не является полиндромом");
}
