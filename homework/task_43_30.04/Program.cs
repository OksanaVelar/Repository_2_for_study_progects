// Найти точку пересечения двух прямых, заданных как: y = k1*x + b1 и y = k2*x + b2
Console.WriteLine("Введите значение переменной k1: ");
double k1 = double.Parse(Console.ReadLine());
//Console.WriteLine($"k1 = {k1}");
Console.WriteLine("Введите значение переменной k2: ");
double k2 = double.Parse(Console.ReadLine());
//Console.WriteLine($"k2 = {k2}");
Console.WriteLine("Введите значение переменной b1: ");
double b1 = double.Parse(Console.ReadLine());
//Console.WriteLine($"b1 = {b1}");
Console.WriteLine("Введите значение переменной b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine($"k1 = {k1}, k2 = {k2}, b1 = {b1}, b2 = {b2}");
double X = 0;
double Y1;
double Y2;
Y1 = k1*X+b1;
Y2 = k2*X+b2;
X = (b2 - b1)/(k1-k2);
double Y = k1*X + b1;
if(k1==k2)
{
Console.WriteLine("Функции не пересекаются");
}
    Console.WriteLine(X+", "+Y);
