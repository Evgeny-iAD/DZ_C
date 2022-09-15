int [,] IntArray = CreateRandomArray(3,4);
Console.Write($"Введите целое однозначное число: ");
bool isFigure = int.TryParse(Console.ReadLine(), out int targetNum);
if(!isFigure)
{
  Console.WriteLine();
  Console.WriteLine("Это не число!");
  return;
}

PrintTextArray(IntArray);
FindNumArray(IntArray, targetNum);


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

void FindNumArray(int [,] array, int targetNum)
{
  bool buffer = false;
  for (int i = 0; i<array.GetLength(0); i++)
  {
      for (int j = 0; j<array.GetLength(1); j++)
      {
          if (array[i,j] == targetNum)
          {
               buffer = true;
               Console.WriteLine($"Индекс числа {targetNum} в массиве: [{i},{j}]");
          }
      }
  }
  if (buffer == false) {Console.WriteLine($"Число {targetNum} в массиве не найдено!");}
}

void PrintTextArray(int[,] array)
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