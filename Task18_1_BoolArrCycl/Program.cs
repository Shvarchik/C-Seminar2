﻿// Проверить истинность ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// Замороченный вариант, с массивами и циклами

bool Statement1 (bool X, bool Y)
 {
    bool result1 = !(X|Y);
    return result1;
 }
bool Statement2 (bool X, bool Y)
 {
    bool result2 = !X & !Y;
    return result2;
 }

Boolean [] arX = {false,true};
Boolean [] Check = new Boolean [4];
int Xindex, Yindex, CheckIndex = 0;

for (Xindex=0; Xindex <=1; Xindex++)
    {
        for (Yindex=0; Yindex <=1; Yindex++)
            {
                if (Statement1(arX[Xindex],arX[Yindex]) == Statement2(arX[Xindex],arX[Yindex]))
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
//bool FinalCheck = Check[0] & Check[1] & Check[2] & Check[3];
//if (FinalCheck == true)
if (Check[0] & Check[1] & Check[2] & Check[3])
            Console.WriteLine ("Высказывание верно");
    else 
            Console.WriteLine ("Высказывание ложно");
        