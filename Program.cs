Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 10000;
int n2 = n / 1000 % 10;
int n4 = n / 10 % 10;
int n5 = n % 10;
Console.WriteLine($" n1 = {n1} n2 = {n2} n4 = {n4} n5 = {n5}");
if (n1 == n5 && n2 == n4)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}