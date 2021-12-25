// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Write("Введите номер дня недели: ");
string Number = Console.ReadLine();
int num = int.Parse(Number);
string[]  Week = {"понедельник","вторник","среда","четверг","пятница","суббота","воскресенье"};

if (num <= 1 && num > 8)
    Console.WriteLine ("В неделе только 7 дней, дня {0} нет", num);
    else if (Week[num-1] == "cуббота" || Week[num-1] == "воскресенье")
            Console.WriteLine ("{0} - выходной день", Week[num-1]);
         else 
            Console.WriteLine ("{0} - рабочий день", Week[num-1]);

