
int [,] IntArray = CreateRandomArray(3,4);

PrintTextArray2D(IntArray);
Console.WriteLine();
Console.WriteLine($"Минимальная сумма в строке: {MinLineArray(IntArray)}");

int [,] CreateRandomArray(int m, int n)
{
  int [,] array = new int [m,n];
  Random random = new Random();

  for (int i = 0; i<array.GetLength(0); i++)
  {
      for (int j = 0; j<array.GetLength(1); j++)
      {
          array[i,j] = random.Next(1, 5);
      }
  }
  return array;
}

int  MinLineArray(int [,] array)
{
//  int [,] result = new int [array.GetLength(0),array.GetLength(1)];
  int [] sum = new int [array.GetLength(0)];
  int   minsum = 0;

  for (int i = 0; i<array.GetLength(0); i++)
  {
      for (int j = 0; j<array.GetLength(1); j++)
      {
          sum[i] = sum[i] + array[i,j];
      }
  }
  for (int i = 1; i<array.GetLength(0); i++)
  {
      if (sum[i-1] < sum[i])
      {
         minsum = sum[i-1];
         sum[i] = sum[i-1];
      }
      {
         minsum = sum[i];
      }
  }
  return Array.IndexOf(sum, minsum) + 1;
}

void PrintTextArray2D(int[,] array)
{
  for (int i = 0; i<array.GetLength(0); i++)
  {
      Console.Write("|");
      for (int j = 0; j<array.GetLength(1); j++)
      {
          string line = Convert.ToString(array[i,j]);
          switch (line.Length)
          {
                  case 1: Console.Write($"     "); break;
                  case 2: Console.Write($"    "); break;
                  case 3: Console.Write($"   "); break;
                  case 4: Console.Write($"  "); break;
          }
          Console.Write($"{array[i,j]}");
      }
      Console.WriteLine("|");
  }
}

