Console.WriteLine("Введите число для определения его четности:  ");
string usernumber = Console.ReadLine();
int firstArg = Convert.ToInt32(usernumber);

int result = firstArg%2;

if(result == 0)
{
    Console.WriteLine($"Число {firstArg} четное");
}
else
{
    Console.WriteLine($"Число {firstArg} нечетное");
}


