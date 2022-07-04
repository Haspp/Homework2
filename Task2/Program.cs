Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a < 99)
{
    Console.WriteLine("Третьего числа нет");
}
else if(a > 99)
{
    Console.Write("Третье число: ");
    Console.WriteLine(a.ToString()[2]);
}
