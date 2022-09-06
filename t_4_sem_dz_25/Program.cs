// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число A:");
bool isFigureA = int.TryParse(Console.ReadLine(), out int a);

Console.WriteLine("Введите число B:");
bool isFigureB = int.TryParse(Console.ReadLine(), out int b);


if(!isFigureA || !isFigureB)
{
  Console.WriteLine("Это не число!");
  return;
}

double result = GetNatDegree(a,b);
Console.WriteLine($"Число А {a} в степени B {b} -> {result}.");

double GetNatDegree(int a, int b)
{
  double ab = a;
  if(b>0)
  {
      for(int i=1; i<b; i++)
      {
        ab = ab*a;
      }
  }
  else
  {
      if(b<0)
      {
         for(int i=1; i<Math.Abs(b); i++)
         {
           ab = ab*a;
         }
         ab = 1 / ab;
      }
      else ab = 1;
  }
  return ab;
}
