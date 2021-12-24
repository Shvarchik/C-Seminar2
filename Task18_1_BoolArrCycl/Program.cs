// Проверить истинность ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// Замороченный вариант, с массивами и циклами

bool X = false; // не понимаю, зачем, но пока я не объявила X и Y и не присвоила им значения, не работало.
bool Y = false; // Так программа работает, но пишет, что переменной Y присвоено значение, но оно ни разу 
                // не использовано. Дык ведь и Х не использовано, но пока не было задано, не работало

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

Boolean [] arX = {false,true};
Boolean [] arY = {false,true};
Boolean [] Check = new Boolean [4];
int Xindex, Yindex, CheckIndex = 0;
for (Xindex=0; Xindex <=1; Xindex++)
    {
        for (Yindex=0; Yindex <=1; Yindex++)
            {
                if (Statement1(arX[Xindex],arY[Yindex]) == Statement2(arX[Xindex],arY[Yindex]))
                    {
                        Check[CheckIndex] = true;
                        CheckIndex++;
                    }
                else
                    {
                        Check[CheckIndex] = false;
                        CheckIndex++; 
                    }    
            }
    }
bool FinalCheck = Check[0] & Check[1] & Check[2] & Check[3];
if (FinalCheck == true)
    {
        Console.WriteLine ("Высказывание верно");
    }
else 
    {
        Console.WriteLine ("Высказывание ложно");
    }    