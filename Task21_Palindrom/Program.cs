// Программа проверяет пятизначное число на палиндром.

Console.Write ("Введите пятизначное число:");
string Number = Console.ReadLine();
int Num = int.Parse (Number);

int n1 = Num / 10000;
int n5 = Num % 10;
int n4 = (Num % 100 - Num % 10) / 10;
int n2 = (Num / 1000) % 10;
  
if (n1 == n5 && n2 == n4)
    Console.WriteLine ("Число {0} является палиндромом", Num);
else 
    Console.WriteLine ("Число {0} не является палиндромом", Num);

