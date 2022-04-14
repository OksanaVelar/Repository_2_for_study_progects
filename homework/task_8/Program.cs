Console.WriteLine("Введите максимальное число исходного числового множества:  ");
string usernumber = Console.ReadLine();
int firstArg = Convert.ToInt32(usernumber);
int[] numbers = {1,firstArg};
int index = 1;
int size = firstArg;
while (index < size){
if(numbers[index]%2 == 0){
    Console.WriteLine($"{numbers[index]}");}
    index = index + 1;
}
