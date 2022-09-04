// See https://aka.ms/new-console-template for more information
Random random = new Random();
int randomNumber = random.Next(100,1000);

Console.WriteLine($"Рандомное число {randomNumber}");

int NumberTwo(int number)
{
   int Num1 = number / 10;
   int Num2 = Num1 % 10;
   return Num2;
}

int result = NumberTwo(randomNumber);


Console.WriteLine($"Вторая цифра числа: {result}");
