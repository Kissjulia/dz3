Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
int kub = 1;

while (i<=N)
{
    kub = i * i * i;
    i++;
    Console.WriteLine($"Куб {kub}");
}