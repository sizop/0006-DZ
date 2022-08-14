// #1
/*
Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32(Console.Readline());
if (num / 10000 == num % 10 && (num % 10000) / 1000 == (num % 100) / 10)
{ Console.WriteLine($"Число {num} является палиндромом"); }
else
{ Console.WriteLine($"Число {num} НЕ палиндром"); }
//Console.WriteLine($"{num / 10000}\t{num % 10}\n{(num % 10000) / 1000}\t{(num % 100) / 10}"); // проверка
*/
// #2
/*
Console.WriteLine("Введите координаты первой точки:");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки:");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());
double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine($"Расстояние =  {d:f2}");
*/
// №3

Console.WriteLine("Введите число: ");
int num=Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++)
{Console.WriteLine(Math.Pow(i,3));}



