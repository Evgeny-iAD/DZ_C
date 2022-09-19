int [,] IntArray = CreateRandomArray(4,4);

PrintTextArray2D(IntArray);
Console.WriteLine();
PrintTextArray2D(ArrangeArray(IntArray));

int [,] CreateRandomArray(int m, int n)
{
  int [,] array = new int [m,n];
  Random random = new Random();

  for (int i = 0; i<array.GetLength(0); i++)
  {
      for (int j = 0; j<array.GetLength(1); j++)
      {
          array[i,j] = random.Next(1, 100);
      }
  }
  return array;
}

int [,] ArrangeArray(int [,] array)
{
  int [,] result = new int [array.GetLength(0),array.GetLength(1)];
  int buffer = 0;

  for (int i = 0; i<array.GetLength(0); i++)
  {
    for (int q = array.GetLength(1)-1; q>=0; q--)
    {
     if(q!=0)
     {
      for (int j = 0; j<q; j++)
      {
        if(array[i,j]>array[i,j+1])
        {
          buffer =  array[i,j];
          array[i,j] = array[i,j+1];
          array[i,j+1]=buffer;
        }
        else
        {
          buffer =array[i,j+1];
        }
      }
        result[i,array.GetLength(1)-q-1]=buffer;
      }
      else {result[i,array.GetLength(1)-q-1]=array[i,0];}
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

