// На входе - число; на выходе - сумма цифр в этом числе

//Console.WriteLine("Введите число и нажмите клавишу Enter");
//int numberA = int.Parse(Console.ReadLine());
int a = 3864;
string str = a.ToString();
int[] b = new int[str.Length];
for(int i = 0; i  < str.Length; i++)
{
    b[i] = int.Parse(str[i].ToString());
}
//Console.WriteLine(str[a]);


    


