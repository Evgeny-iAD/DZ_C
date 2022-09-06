Console.WriteLine("Генерирую массив из 8 элементов................ ");
int [] newArray = new int[8];

int [] RandomArray8 = CreateArray(newArray);
string PrintArray8 =  PrintText(RandomArray8);
Console.Write("[");
Console.Write(PrintArray8);
Console.Write("]");

int[] CreateArray(int [] array)
{
 Random random = new Random();
// int randomNumber = random.Next(1,100);

 for (int i = 0; i<array.Length; i++)
    {
     array[i] = random.Next(1,100);
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
