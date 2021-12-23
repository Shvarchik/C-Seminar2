Console.Write("Введите число N: ");
string Number = Console.ReadLine();
int num = int.Parse(Number);
if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine ("{0} кратно 7 и 23 одновременно", num);
}
else
{
    Console.WriteLine("{0} не кратно 7 и 23 одновременно", num);
}

