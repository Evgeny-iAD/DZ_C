// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
Random random = new Random();
int randomKal = random.Next(1,8);

bool FindRelax(int number)
{
   if(number == 6)
   {
     return true;
   }
   else
   {
     if(number == 7)
     {
        return true;
     }
     else
     {
        return false;
     }
   }
}

bool result = FindRelax(randomKal);
Console.WriteLine($"Число дня недели: {randomKal}");
if(result == true)
{
Console.WriteLine($"Выходной!");
}
else
{
Console.WriteLine($"Рабочий день!");
}


