int [,] IntArray = CreateRandomArray(3,4);

PrintTextArray2D(IntArray);

PrintTextArray1D(FindNumArray(IntArray));


int [,] CreateRandomArray(int m, int n)
{
  int [,] array = new int [m,n];
  Random random = new Random();

  for (int i = 0; i<array.GetLength(0); i++)
  {
      for (int j = 0; j<array.GetLength(1); j++)
      {
          array[i,j] = random.Next(-10, 10);
      }
  }
  return array;
}

double [] FindNumArray(int [,] array)
{
  double [] result = new double [array.GetLength(1)];
  int sum = 0;
  for (int i = 0; i<array.GetLength(1); i++)
  {
      for (int j = 0; j<array.GetLength(0); j++)
      {
         sum = sum + array[j,i];
      }
      double average = Convert.ToDouble(sum)/Convert.ToDouble(array.GetLength(0));
      result[i] = Math.Round(average, 2, MidpointRounding.AwayFromZero);
//      Console.WriteLine($"Среднее арифметическое чисел по столбцам: {}");
      sum = 0;
  }
  return result;

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
//                  case 4: Console.Write($"  "); break;
          }
          Console.Write($"{array[i,j]}");
      }
      Console.WriteLine("|");
  }
}

void PrintTextArray1D(double[] array)
{
  Console.Write($"Среднее арифметическое каждого столбца: ");
  for (int i = 0; i<array.Length; i++)
  {
       Console.Write($" {array[i]};");
  }
  Console.WriteLine();
}