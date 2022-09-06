Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number < 1)
{
    Console.Write("0");
}
else
{
   int product = 1;
   for (int i = 1; i <= number; i++)
{
    product = product * i;
}
Console.Write(product);
}