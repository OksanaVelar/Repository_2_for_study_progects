int[] numbers = {2,3,7};
int size = 3;
int index = 0;
int max = numbers[0];
Console.WriteLine("В массиве чисел 2,3,7 максимальное значение:");
while(index < size){
    if(numbers[index] > max){
        max = numbers[index];
    }
    index = index + 1;
}
Console.Write($"{max}");
  