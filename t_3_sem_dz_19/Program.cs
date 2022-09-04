// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите пятизначное число:");
bool isFigure = int.TryParse(Console.ReadLine(), out int x);

if(isFigure != true)
{
  Console.WriteLine("Число введено неверно!");
  return;
}

string result = IsPalin(x);
Console.WriteLine($"Это число {result}.");

string IsPalin(int x)
{
  string xStr = x.ToString();
  string palStr = String.Empty;

  for(int i=xStr.Length-1; i>=0; i--)
  {
        palStr = palStr + xStr[i];
  }
  if(xStr == palStr)  {return $"палиндром";}
  else {return $"не палиндром";}
}


