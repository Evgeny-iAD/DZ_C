// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите координату x точки А:");
bool isCoorXA = int.TryParse(Console.ReadLine(), out int xa);   // конверт в бул
Console.WriteLine("Введите координату y точки А:");
bool isCoorYA = int.TryParse(Console.ReadLine(), out int ya);
Console.WriteLine("Введите координату z точки А:");
bool isCoorZA = int.TryParse(Console.ReadLine(), out int za);

Console.WriteLine("Введите координату x точки B:");
bool isCoorXB = int.TryParse(Console.ReadLine(), out int xb);
Console.WriteLine("Введите координату y точки B:");
bool isCoorYB = int.TryParse(Console.ReadLine(), out int yb);
Console.WriteLine("Введите координату z точки B:");
bool isCoorZB = int.TryParse(Console.ReadLine(), out int zb);

if(!isCoorXA|| !isCoorYA|| !isCoorZA|| !isCoorXB|| !isCoorYB || !isCoorZB )
{
  Console.WriteLine("Координаты введены неверно.");
  return;
}

double result = GetLine(xa,ya, za, xb, yb, zb);
Console.WriteLine($"Длина отрезка =  {result}");

double GetLine(int xa, int ya, int za, int xb, int yb, int zb)
{
  return Math.Sqrt(Math.Pow((xb-xa),2) + Math.Pow((yb-ya),2) + Math.Pow((zb-za),2));
}