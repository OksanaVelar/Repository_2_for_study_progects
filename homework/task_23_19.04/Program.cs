// Создание таблицы кубов значений от 1 до N
Console.WriteLine("Введите число и нажмите клавишу Enter");
int usernumber = int.Parse(Console.ReadLine());
int r = 1;

  while(r <= usernumber)
   {
    Console.WriteLine(r*r*r);
    r++;
   }
  
