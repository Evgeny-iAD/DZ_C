Console.WriteLine("Генерирую массив из 8 элементов................ ");
double [] newArray = new double[8];

double [] RandomArray = CreateArrayReal(newArray);
Console.Write("[");
Console.Write($"исходный массив: {PrintText(RandomArray)}");
Console.Write("]");
Console.WriteLine();
Console.WriteLine("Массив минимального и максимального числа: ");
Console.Write("[");
Console.Write($"{PrintText(SearchMinMax(RandomArray))}");
Console.Write("]");
Console.WriteLine();
Console.Write($"Разница максимального и минимального числа: {SearchMinMax(RandomArray)[1]-SearchMinMax(RandomArray)[0]}");

double[] CreateArrayReal(double [] array)
{
 Random random = new Random();

 for (int i = 0; i<array.Length; i++)
    {
     array[i] = random.NextDouble();
    }
return array;
}

string PrintText(double[] array)
{
  string result = String.Empty;

  for (int i=0; i<array.Length; i++)
  {
    if(i == array.Length-1) {result= result + $"{array[i]}";}
    else {result= result + $"{array[i]}"+ ", ";}
  }
  return result;
}

double[] SearchMinMax(double[] array)
{
    double [] resultArray = new double [2];
    double max = array[0];
    double min = array[0];

    for (int i=1; i<array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    for (int i=1; i<array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    resultArray[0] = min;
    resultArray[1] = max;

    return resultArray;
}

