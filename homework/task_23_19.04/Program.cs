// Создание таблицы кубов значений от 1 до N
Console.WriteLine("Введите число и нажмите клавишу Enter");
int usernumber = int.Parse(Console.ReadLine());
int r = 1;
while(r <= usernumber)
{
  if(r < usernumber)
   {
    Console.Write(Math.Pow(r,3));
    r++;
   }
  else
   {
    Console.Write(Math.Pow(usernumber,3));
   }
}

