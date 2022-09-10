// See https://aka.ms/new-console-template for more information
Console.WriteLine("Генерирую массив из 8 элементов................ ");
int [] newArray = new int[8];

int [] RandomArray = CreateArray3(newArray);

Console.Write("[");
Console.Write(PrintText(RandomArray));
Console.Write("]");

Console.WriteLine();
Console.WriteLine($"Количество четных чисел в текущем массиве: {SearchEveNum(RandomArray)}");

int[] CreateArray3(int [] array)
{
 Random random = new Random();

 for (int i = 0; i<array.Length; i++)
    {
     array[i] = random.Next(100,1000);
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

int SearchEveNum(int[] array)
{
    int result = 0;

    for (int i=0; i<array.Length; i++)
    {
        if((array[i] % 2) == 0) { result += 1;}
    }
    return result;
}
