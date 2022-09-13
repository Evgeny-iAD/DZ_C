Console.WriteLine("Введите числа через пробел:");
string Something  = new string(Console.ReadLine());
Console.WriteLine(Something);

if(ConvertStrInt(ConvertLinStr(Something)) != null)
{
    Console.Write("[");
    Console.Write(PrintText(ConvertStrInt(ConvertLinStr(Something))));
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine($"Сумма чисел > 0 равна: {SumRealNum(ConvertStrInt(ConvertLinStr(Something)))}");
}
else
{
    Console.WriteLine("Последовательность чисел введена неверно!");
}

string []  ConvertLinStr(string arrayCh)
{
    string [] s = new string [] {};
    string buffer = string.Empty;

    for(int i=0; i < arrayCh.Length; i++)
    {
        if (arrayCh[i] != ' ')
        {
            buffer = buffer + arrayCh[i];
            if (i == arrayCh.Length-1) {s = s.Concat(new string[] {buffer}).ToArray();}
        }
        else
        {
            s = s.Concat(new string[] {buffer}).ToArray();
            buffer = string.Empty;
        }
    }
   return s;
}

int [] ConvertStrInt(string [] arrayStr)
{
    int [] arrayInt = new int [arrayStr.Length];
    for(int j=0; j<arrayStr.Length; j++)
    {
        bool isFigure = int.TryParse(arrayStr[j], out int x);
        if(isFigure != true)
        {
            return null;
        }
    }
    for(int i = 0; i<arrayStr.Length; i++)
    {

        arrayInt[i] = Convert.ToInt32(arrayStr[i]);
    }
    return arrayInt;
}

int SumRealNum(int [] arrayInt)
{
    int result = 0;
    for(int i=0; i<arrayInt.Length; i++)
    {
        if(arrayInt[i] > 0) {result = result + 1;}
    }
    return result;
}

string PrintText(int [] array)
{
  string result = String.Empty;
  if(array == null){return result;}
  for (int i=0; i<array.Length; i++)
  {
    if(i == array.Length-1) {result= result + $"{array[i]}";}
    else {result= result + $"{array[i]}"+ ", ";}
  }
  return result;
}

