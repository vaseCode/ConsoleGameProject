namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы проснулись, в загадочной комнате, потяряв память...\nКак ваше имя?\n");
            string name = Console.ReadLine();
            Console.WriteLine("\n" + name + ", Вам нужно выбратьтся из комнаты.");
            string one = "первый артефакт";
            string two = "второй артефакт";
            string tried = "третий артефакт";
            int count = 0;
            string kot ="";
            bool actiuve_state = false;
            bool otm = false;
            bool game_over = true;

            while (game_over == true)
            {
             
                Console.WriteLine("\nВыберите действие:\na. Открыть дверь\nb. Заглянуть под кровать\nc. Открыть ящик в углу комнаты\nd. Открыть вентиляцию\ne. Взглянуть на тумбочку\nf. Взглянуть на статую рядом с дверью\n");
                string variant = Console.ReadLine();

                switch (variant)
                {
                    case "a":
                        if (otm == true)
                        {
                            Console.WriteLine("\n" + name + ", Дверь открыта! Доброго пути!");
                            game_over = false;
                        }

                        else
                        {
                            Console.WriteLine("\n" + name + ", Дверь заперта! Прооверить другие места, чтобы найти предмет, способный открыть её!");
                        }
                        break;

                    case "b":
                        Console.WriteLine("\n" + name + ", Вы нашли " + one);
                        kot += 1;
                        break;

                    case "c":
                        if (actiuve_state == true)
                        {
                            Console.WriteLine("\nВнутри ящика оказаклась отмычка. " + name + ", Вы можете её использовать!");
                            otm = true;
                        }
                        else
                        {
                            Console.WriteLine("\n" + name + ", Вам нужно найти ключ от ящика!");
                        }
                            break;

                    case "d":
                        count = count+1;
                        if (count == 3)
                        {
                            Console.WriteLine("\n" + name + ", Вы нашли " + two);
                            kot += 2;
                        }

                        else
                        {
                            Console.WriteLine("\n" + name + ", Попробуйте еще раз!");
                        }
                        break;

                    case "e":
                        Console.WriteLine("\n" + name + ", Вы нашли " + tried);
                        kot += 3;
                        break;

                    case "f":
                        if (kot == "123")
                        {
                            Console.WriteLine("\n" + name + ", Вы активировали статую. Внтури небольшой тайник с ключом. Ключ теперь ваш, " + name + '!');
                            actiuve_state = true;
                        }

                        else
                        {
                            Console.WriteLine("\n" + name + ", Вам нужно найти три артефакта!");
                        }
                        break;
                }
                                 
            }
            
        }
    }
}
