// Проверить истинность ¬(A ⋁ Y) = ¬A ⋀ ¬Y
// Замороченный вариант, с массивами и циклами

bool Statement1 (bool A, bool Y)
 {
    bool result1 = !(A|Y);
    return result1;
 }
bool Statement2 (bool A, bool Y)
 {
    bool result2 = !A & !Y;
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
bool FinalCheck = Check[0] & Check[1] & Check[2] & Check[3];
if (FinalCheck == true)
    {
        Console.WriteLine ("Высказывание верно");
    }
else 
    {
        Console.WriteLine ("Высказывание ложно");
    }    