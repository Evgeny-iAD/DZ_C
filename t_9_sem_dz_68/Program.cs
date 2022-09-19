Console.WriteLine("Введите число М: ");
bool isFigureM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите число N: ");
bool isFigureN = int.TryParse(Console.ReadLine(), out int n);

if(isFigureM != true || isFigureN !=true)
{
  Console.WriteLine("Числa введены неверно!");
  return;
}
if(m>n)
{
  Console.WriteLine("Натуральных чисел в промежутке от М к N нет!");
  return;
}

int  result = Ackermann(m,n);
Console.WriteLine($"{result}");

int  Ackermann(int m, int n)
{
    if(m == 0) {return n + 1;}
    else
    {
     if(n == 0) {return Ackermann(m - 1, 1);}
     else {return Ackermann(m - 1, Ackermann(m, n - 1));}
    }
}


