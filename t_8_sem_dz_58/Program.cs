
int [,] IntArray1 = CreateRandomArray(2,2);
int [,] IntArray2 = CreateRandomArray(2,2);


Console.WriteLine($"Матрица № 1:");
PrintTextArray2D(IntArray1);
Console.WriteLine();
Console.WriteLine($"Матрица № 2:");
PrintTextArray2D(IntArray2);
Console.WriteLine();
Console.WriteLine($"Матрица произведений: ");
PrintTextArray2D(MultiplyArray(IntArray1, IntArray2));

int [,] CreateRandomArray(int m, int n)
{
  int [,] array = new int [m,n];
  Random random = new Random();

  for (int i = 0; i<array.GetLength(0); i++)
  {
      for (int j = 0; j<array.GetLength(1); j++)
      {
          array[i,j] = random.Next(1, 6);
      }
  }
  return array;
}

int [,] MultiplyArray(int [,] array1, int [,] array2)
{
    int [,] result = new int [array2.GetLength(0),array2.GetLength(1)];

    for (int i=0; i<array1.GetLength(0); i++)
    {
       for(int k=0; k<array1.GetLength(0); k++)
       {
        for (int j=0; j<array1.GetLength(1); j++)
        {
            result[i,k] = result[i,k] + array1[i,j]*array2[j,k];
        }
       }
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
                  case 4: Console.Write($"  "); break;
          }
          Console.Write($"{array[i,j]}");
      }
      Console.WriteLine("|");
  }
}


