﻿// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

void DayOfWeek(int day)
{
    if (day % 6 == 0 || day % 7 == 0 && day > 0)
    {
        Console.WriteLine("Ура Выходной!");
    }
    else
    {
        Console.WriteLine("Работаем товарищи!");
    }
}

DayOfWeek(7);


// По двум заданным числам проверять является ли одно квадратом другого
void Square(int numberOne, int numberTwo)
{
    if (numberOne == numberTwo * numberTwo)
    {
        Console.WriteLine("Первое число- это квадрат второго");
    }
    else
    {
        Console.WriteLine("Никто, ничей не квадрат");
    }
}

Square(4, 2);

// Задать номер четверти, показать диапазоны для возможных координат
void plane(int x)
{
    if (x > 0 && x < 5)
    {
        if (x == 1)
        {
            Console.WriteLine("x > 0 && y > 0");
        }
        if (x == 2)
        {
            Console.WriteLine("x < 0 && y > 0");
        }
        if (x == 3)
        {
            Console.WriteLine("x < 0 && y < 0");
        }
        else
        {
            Console.WriteLine("x > 0 && y < 0");
        }
    }
    else
    {
        Console.WriteLine("Такой плоскости не существует");
    }
}

plane(3);

// Найти расстояние между точками в пространстве 2D/3D

    char selection;
    Double x1, x2, y1, y2, z1, z2, distance;

    Console.WriteLine("1. Расстояние между двумя точками на плоскости.");
    Console.WriteLine("2. Расстояние между двумя точками в пространстве.");
    Console.WriteLine("Выберите нужный пункт (1 или 2):");

    selection = Convert.ToChar(Console.ReadLine());

    switch (selection)
    {
        case '1':
            Console.Write("Введите координаты x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между двумя точками на плоскости равно {distance}");
            Console.ReadKey();
            break;
        case '2':
            Console.Write("Введите координаты x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты z1: ");
            z1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты z2: ");
            z2 = Convert.ToDouble(Console.ReadLine());

            distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
            Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("Вы ввели неверный символ");
            Console.ReadKey();
            break;
    }
