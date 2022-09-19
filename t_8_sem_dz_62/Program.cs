
int [,] IntArray = CreateRandomArray(4,4);

Console.WriteLine($"Матрица 4x4, заполненная по спирали: ");
PrintTextArray2D(IntArray);
Console.WriteLine();


//Колхозный способ спирального заполнения массива:
int [,] CreateRandomArray(int m, int n)
{
  int [,] array = new int [m,n];
  Random random = new Random();
  int i = 1;

      for (int j = 0; j<4; j++)
      {
          array[0,j] = i;
          i++;
      }
      for (int q = 1;q<4; q++)
      {
          array[q,3] = i;
          i++;
      }
      for (int k = 2;k>0; k--)
      {
          array[3,k] = i;
          i++;
      }
      for (int z=3; z>0; z--)
      {
          array[z,0] = i;
          i++;
      }
      for (int b=1; b<3; b++)
      {
          array[1,b] = i;
          i++;
      }
      for (int c=2; c>0; c--)
      {
          array[2,c] = i;
          i++;
      }

  return array;
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



