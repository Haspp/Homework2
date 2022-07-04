Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());

int second_number = a % 100;
int average = second_number / 10;

Console.WriteLine("Среднее число: " + average);


