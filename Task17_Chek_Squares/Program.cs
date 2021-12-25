Console.Write("Введите первое число:");
string number1 = Console.ReadLine();
int num1 = int.Parse(number1);
Console.Write("Введите второе число:");
string number2 = Console.ReadLine();
int num2 = int.Parse(number2);

if (num1 == num2 * num2)
    Console.WriteLine("число {0} является квадратом {1}", num1, num2);

else if (num2 == num1 * num1)
       Console.WriteLine("число {0} является квадратом {1}", num2, num1);
     else
       Console.WriteLine("ни одно из чисел не является квадратом другого");