// Указать, в какой четверти лежит точка с заданными координатами
// Точка (0,0) - в 1 четверти
// пусть точки на осях будут в 1 или 3 четвертях
// else if нужен для того, чтобы (0,0) попала только в 1 четверть,
// тогда на принадлежность к 3 она уже не будет проверяться

Console.Write("Введите координату Х: ");
string NumberX = Console.ReadLine();
int x = int.Parse(NumberX);
Console.Write("Введите координату Y: ");
string NumberY = Console.ReadLine();
int y = int.Parse(NumberY);
if (x >= 0 && y >= 0) 
    Console.WriteLine ("Точка принадлежит 1-й четверти");
else if (x < 0 && y > 0) 
        Console.WriteLine ("Точка принадлежит 2-й четверти");
    else if (x <= 0 && y <= 0) 
            Console.WriteLine ("Точка принадлежит 3-й четверти");
//if (x > 0 && y < 0) 
          else  
            Console.WriteLine ("Точка принадлежит 4-й четверти");