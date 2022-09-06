// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число:");
bool isFigure = int.TryParse(Console.ReadLine(), out int x);

if(!isFigure)
{
  Console.WriteLine("Это не число!");
  return;
}

int result = GetSum(Math.Abs(x));
Console.WriteLine($"Сумма чисел в числе {x} -> {result}.");

int GetSum(int x)
{
    string xStr = x.ToString();
    int len = xStr.Length;
    int xi = x;
    int sum = 0;

    for(int i=1; i<=len; i++)
    {
      xi = x % 10;
      x = x / 10;
      sum = sum + xi;
    }
    return sum;
}
