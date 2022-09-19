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

int  result = SumRealNumbers(m,n);
Console.WriteLine($"{result}");

int SumRealNumbers(int m, int n, int sum = 0)
{
    sum += m;
    if (m == n )
    {
        return sum;
    }
    else
    {
        return SumRealNumbers( m+1, n, sum);
    }
}

//void PrintTextArray1D(int[] array)
//{
//  Console.Write($"Натуральные числа в промежутке от М до N: ");
//  Console.Write($"|");
//  for (int i = 0; i<array.Length; i++)
//  {
//       Console.Write($" {array[i]};");
//  }
//  Console.Write($"|");
//  Console.WriteLine();
//}
