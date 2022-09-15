double [,] targetArray = CreateRealArray(3,4);
PrintTextArray(targetArray);

double [,] CreateRealArray(int m, int n)
{
  double [,] array = new double [m,n];
  Random random = new Random();

  for (int i = 0; i<array.GetLength(0); i++)
  {
      for (int j = 0; j<array.GetLength(1); j++)
      {
          array[i,j] = Convert.ToDouble(random.Next(-100, 100)/10.0);
      }
  }
  return array;
}

void PrintTextArray(double[,] array)
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