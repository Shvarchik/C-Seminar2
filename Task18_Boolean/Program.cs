// Проверить истинность ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// Простой вариант, где X и Y вводятся вручную

Console.Write("Введите значение Х: ");
string x = Console.ReadLine();
bool X = Boolean.Parse(x);

Console.Write("Введите значение Y: ");
string y = Console.ReadLine();
bool Y = Boolean.Parse(y);

bool Statement1 (bool Х, bool Y)
 {
    bool result1 = !(X|Y);
    return result1;
 }
bool Statement2 (bool Х, bool Y)
 {
    bool result2 = !X & !Y;
    return result2;
 }
   //bool S1 = Statement1(X,Y)
if (Statement1(X,Y) == Statement2(X,Y))
Console.WriteLine ("Высказывание истинно"); 

