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

int [] result = RealNumbers(m,n,new int[n-m+1],0);
PrintTextArray1D(result);

int [] RealNumbers(int m, int n, int [] array, int i = 0)
{
    array[i] = m;
    if (m == n || i == (n-m+1))
    {
        return array;
    }
    else
    {
        return RealNumbers( m+1, n, array, i+1);
    }
}

void PrintTextArray1D(int[] array)
{
  Console.Write($"Натуральные числа в промежутке от М до N: ");
  Console.Write($"|");
  for (int i = 0; i<array.Length; i++)
  {
       Console.Write($" {array[i]};");
  }
  Console.Write($"|");
  Console.WriteLine();
}