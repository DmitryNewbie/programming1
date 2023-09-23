Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int z = a%2;
if (z == 0)
{
    Console.WriteLine("Число " + a + " четное");
}
else
{
    Console.Write("Число " + a + " не четное");
}

