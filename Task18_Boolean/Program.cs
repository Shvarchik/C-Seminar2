// Проверить истинность ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool X = true;
bool Y = false;
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
Console.WriteLine ("Ура"); 

