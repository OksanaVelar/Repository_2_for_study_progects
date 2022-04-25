// На входе - число; на выходе - сумма цифр в этом числе

Console.WriteLine("Введите число и нажмите клавишу Enter");
int a = int.Parse(Console.ReadLine());
int sum = 0;
while(a > 0)
{
    sum = sum + a%10;
    a /= 10;
}
Console.WriteLine($"Сумма чиcел в введенном Вами числе = {sum}");


    


