Console.WriteLine("Генерирую массив из 8 элементов................ ");
int [] newArray = new int[8];

int [] RandomArray = CreateArray1(newArray);

Console.Write("[");
Console.Write(PrintText(RandomArray));
Console.Write("]");

Console.WriteLine();
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях в текущем массиве: {SearchSumEveNum(RandomArray)}");

int[] CreateArray1(int [] array)
{
 Random random = new Random();

 for (int i = 0; i<array.Length; i++)
    {
     array[i] = random.Next(-100,101);
    }
return array;
}

string PrintText(int[] array)
{
  string result = String.Empty;

  for (int i=0; i<array.Length; i++)
  {
    if(i == array.Length-1) {result= result + $"{array[i]}";}
    else {result= result + $"{array[i]}"+ ", ";}
  }
  return result;
}

int SearchSumEveNum(int[] array)
{
    int result = 0;

    for (int i=1; i<array.Length; i++)
    {
        if((i % 2) != 0) { result += array[i];}
    }
    return result;
}
