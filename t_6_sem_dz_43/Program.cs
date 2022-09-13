Console.WriteLine("Введите k1 и k2 через пробел:");
string K1K2  = new string(Console.ReadLine());
Console.WriteLine("Введите b1 и b2 через пробел:");
string B1B2  = new string(Console.ReadLine());

if(ConvertStrDoub(ConvertLinStr(K1K2)) != null && ConvertStrDoub(ConvertLinStr(B1B2)) != null)
{
    double [] K =  ConvertStrDoub(ConvertLinStr(K1K2));
    double [] B =  ConvertStrDoub(ConvertLinStr(B1B2));
    Console.Write($"Собран массив из k1 и k2 : [{PrintText(K)}]");
    Console.WriteLine();
    Console.Write($"Собран массив из b1 и b2 : [{PrintText(B)}]");
    Console.WriteLine();
    Console.WriteLine($"Координата пересечения прямых: [{PrintText(InterPoint(K, B))}]");
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

double [] ConvertStrDoub(string [] arrayStr)
{
    double [] arrayDoub = new double [2];
    if(arrayStr.Length > 2) {return null;}
    for(int j=0; j<arrayStr.Length; j++)
    {
        bool isFigure = int.TryParse(arrayStr[j], out int x);
        if(isFigure != true) {return null;}
    }
    for(int i = 0; i<arrayStr.Length; i++)
    {
        arrayDoub[i] = Convert.ToInt32(arrayStr[i]);
    }
    return arrayDoub;
}

string PrintText(double [] array)
{
  string result = String.Empty;
  if(array == null){return result;}
  for (int i=0; i<array.Length; i++)
  {
    if(i == array.Length-1) {result= result + $"{array[i]}";}
    else {result= result + $"{array[i]}"+ "; ";}
  }
  return result;
}

double [] InterPoint(double [] arrayK, double [] arrayB)
{
    if (arrayK[0]==arrayK[1])
    {
        Console.WriteLine("Прямые параллельны!");
        return null;
    }
    double [] result = new double [2];
    //поиск  х
    double x = (arrayB[0]-arrayB[1])/(arrayK[1] - arrayK[0]);
    //поиск у
    double y = arrayK[1]*x+arrayB[1];
    result[0] = x;
    result[1] = y;

    return result;
}



