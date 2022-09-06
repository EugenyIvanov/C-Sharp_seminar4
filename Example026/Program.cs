Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
char [] array = number.ToString().ToCharArray();
Console.WriteLine(array.Length);