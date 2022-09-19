int [,,] IntArray = CreateRandom3DArray(2,2,2);

Console.WriteLine();
PrintTextArray3D(IntArray);


int [,,] CreateRandom3DArray(int m, int n, int h)
{
  int [,,] array = new int [m,n,h];
  int [] ramArray = new int [m*n*h];
  Random random = new Random();
  int buffer = 0;
  int q = 0;

  for (int i = 0; i<array.GetLength(0); i++)
  {
      for (int j = 0; j<array.GetLength(1); j++)
      {
          for (int k = 0; k<array.GetLength(2); k++)
          {
               while (ramArray[q]==0)
               {
                   buffer = random.Next(1, 11);
                   ramArray[q] = FindNum(ramArray,buffer);;
               }
               array[i,j,k] = ramArray[q];
//               Console.WriteLine($"{array[i, j, k]} ({i},{j},{k})");
               q++;
          }
      }
  }
  return array;
}

int FindNum(int [] ramArray, int r)
{
  for (int i = 0; i<ramArray.Length; i++)
  {
      if(r == ramArray[i]) {return 0;}
  }
  return r;
}

void PrintTextArray3D(int[,,] array)
{
  for (int i = 0; i<array.GetLength(0); i++)
  {
     Console.WriteLine($"Слой № {i+1}");
     for (int j = 0; j<array.GetLength(1); j++)
     {
      Console.Write("|");
      for (int k = 0; k<array.GetLength(2); k++)
      {
          string line = Convert.ToString(array[i,j,k]);
          switch (line.Length)
          {
                  case 1: Console.Write($"     "); break;
                  case 2: Console.Write($"    "); break;
                  case 3: Console.Write($"   "); break;
                  case 4: Console.Write($"  "); break;
          }
          Console.Write($"{array[i,j,k]} ({i},{j},{k})");
      }
      Console.Write("|");
      Console.WriteLine();
     }

  }
}
