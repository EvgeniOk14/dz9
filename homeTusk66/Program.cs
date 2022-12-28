Console.Write("Введите первое число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число n: ");
int n = Convert.ToInt32(Console.ReadLine());
while (m > n)
{
  Console.Write("Вы ввели первое число меньше второго! Введите заного! \n");
  m = Convert.ToInt32(Console.ReadLine());
  n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("первое число равно " + m);
Console.WriteLine("второе число равно " + n);
int SumRec(int m, int n)
{
  if (m>n) return 0;
  else return n + SumRec(m, n-1);
}
Console.WriteLine(SumRec(m, n));