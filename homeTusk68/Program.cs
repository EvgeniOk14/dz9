Console.Write("Введите первое число m: ");
Double m = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите первое число n: ");
double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("первое число равно " + m);
Console.WriteLine("второе число равно " + n);
double AkkermanRec(double m, double n)
{
  if (m == 0) return (n + 1);
  else if (n == 0) return AkkermanRec(m-1, 1);
  else  return AkkermanRec(m -1, AkkermanRec(m, n-1)); 
}
Console.WriteLine(AkkermanRec(m, n)); 