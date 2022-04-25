// На входе два числа; На выходе - первое возводится в степень, равную второму числу

Console.WriteLine("Введите первое число и нажмите клавишу Enter");
  int A = int.Parse(Console.ReadLine());
    Console.WriteLine();
Console.WriteLine("Введите второе число и нажмите клавишу Enter");
  int B = int.Parse(Console.ReadLine());
    Console.WriteLine();

int result = (int)Math.Pow(A,B);
    Console.WriteLine(result);

