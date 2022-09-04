// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число:");
bool isFigure = int.TryParse(Console.ReadLine(), out int x);

if(isFigure != true)
{
  Console.WriteLine("Число введено неверно!");
  return;
}

string result = GetСube(x);
Console.WriteLine($"Кубы от 1 до {x} -> {result}.");

string GetСube(int x)
{
  string xStr = x.ToString();
  string cubeX = String.Empty;

  for(int i=1; i<=x; i++)
  {
        cubeX = cubeX + " " + i*i*i;
  }
  return $"{cubeX}";
}