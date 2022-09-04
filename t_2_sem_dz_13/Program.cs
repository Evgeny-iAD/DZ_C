// See https://aka.ms/new-console-template for more information
Random random = new Random();
int randomNumber = random.Next(1,10000);

int NumberThree(int number)
{
   string Number_str = number.ToString();
   int len = Number_str.Length;
   int count = 0;
   int numberBuf = number;
   int [] array = new int [len];

   while (count<len)
   {
     int numberX = numberBuf % 10;
     array[count] = numberX;
     numberBuf = numberBuf / 10;
     count++;
   }

   if (len<3)
   {
     return -1;
   }
   else
   {
     return array[len-3];
   }

}

int result = NumberThree(randomNumber);
Console.WriteLine($"Рандомное число: {randomNumber}");
if(result == -1)
{
Console.WriteLine($"Третьей цифры нет!");
}
else
{
Console.WriteLine($"Третья цифра числа: {result}");
}

