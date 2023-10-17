using System;

class Ejednevnik
{
    static void Main()
    {
        ConsoleKeyInfo key;
        int pos = 3;
        DateTime dateTime = DateTime.Now;

        do
        {
            Console.Clear();
            Console.WriteLine("Дата сейчас: " + dateTime);
            Console.WriteLine("что запустить");
            Console.WriteLine("---------------------------");
            if (dateTime.Date == new DateTime(2023, 10, 17))
            {
                Console.WriteLine("   1. сходить в магазин");
                Console.WriteLine("   2. сыграть в игру ");
            }
            else if (dateTime.Date == new DateTime(2023, 10, 18))
            {
                
                Console.WriteLine("   1. сходить в кино ");
        


            }
            else if (dateTime.Date == new DateTime(2023, 10, 16))
            {
                Console.WriteLine("   1. сходить в цирк ");

            }

            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");

            key = Console.ReadKey();

            Console.SetCursorPosition(0, pos);
            Console.WriteLine("  ");

            if (key.Key == ConsoleKey.UpArrow)
            {
                pos--;
                if (pos == 2 && dateTime.Date == new DateTime(2023, 10, 18))
                    pos = 3;
                if (pos == 2 && dateTime.Date == new DateTime(2023, 10, 16))
                    pos = 3;
                else if (pos == 2)
                    pos = 4;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                pos++;
                if (pos == 4 && dateTime.Date == new DateTime(2023, 10, 18))
                    pos = 3;
                if (pos == 4 && dateTime.Date == new DateTime(2023, 10, 16))
                    pos = 3;
                else if (pos == 5)
                    pos = 3;
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                dateTime = dateTime.AddDays(1);

                Console.SetCursorPosition(0, 6);
                Console.WriteLine(dateTime);

            }
            else if (key.Key == ConsoleKey.LeftArrow)
            {

                dateTime = dateTime.AddDays(-1);


                Console.SetCursorPosition(0, 6);
                Console.WriteLine(dateTime);
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                if (pos == 3 && dateTime.Date == new DateTime(2023, 10, 17))
                {
                    Console.Clear();
                    Console.WriteLine("Сходить в магазин");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("   Купить молоко и хлеб.");
                    Console.WriteLine("Дата: ");
                    Console.SetCursorPosition(0, 4);
                    Console.WriteLine(dateTime);

                    Console.ReadKey();
                }
                else if (pos == 3 && dateTime.Date == new DateTime(2023, 10, 18))
                {
                    Console.Clear();
                    Console.WriteLine("Сходить в кино");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("   Посмотреть фильм.");
                    Console.WriteLine("Дата: ");
                    Console.SetCursorPosition(0, 4);
                    Console.WriteLine(dateTime);

                    Console.ReadKey();
                }
                else if (pos == 3 && dateTime.Date == new DateTime(2023, 10, 16))
                {
                    Console.Clear();
                    Console.WriteLine("Сходить в цирк");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("   Посмотреть представление.");
                    Console.WriteLine("Дата: ");
                    Console.SetCursorPosition(0, 4);
                    Console.WriteLine(dateTime);

                    Console.ReadKey();
                }
                else if (pos == 4)
                {

                    Console.Clear();
                    Console.WriteLine("Сыграть в игру");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("   Сыграть в Counter Strike 2");
                    Console.WriteLine("Дата: ");
                    Console.SetCursorPosition(0, 4);
                    Console.WriteLine(dateTime);
                    Console.ReadKey();


                }
            }
        } while (key.Key != ConsoleKey.Escape);
    }

}
