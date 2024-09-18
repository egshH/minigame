namespace MINIGAME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool otmuchka = false;
            string username = "";
            bool artBed = false;
            bool artVent = false;
            bool artBox = false;
            bool key = false;
            bool end = false;

            Console.WriteLine("Вы проснулись в неизвестном помещении и не помните как вас зовут. Вокруг вас никого нет. \n Какое у вас имя?");
            username = Console.ReadLine();
            Console.WriteLine("Приветствую," + username + "!");

            while (end == false)
            {
                Console.WriteLine("Что вы хотите сделать? \n 1 - открыть дверь \n 2 - осмотреть тумбочку \n 3 - посмотреть вентиляцию \n 4 - посмотреть под кроватью \n 5 - осмотреть ящик \n 6 - осмотреть статую");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    if (key == false)
                    {
                        Console.WriteLine("Дверь заперта. Найдите ключ.");

                    }
                    else
                    {
                        Console.WriteLine("Поздравляю, вы сбежали от насильника!");
                        end = true;
                    }
                }
                if (choice == "2")
                {
                    if (otmuchka == false)
                    {
                        Console.WriteLine("Вы нашли отмычку.");
                        otmuchka = true;
                    }
                    else
                    {
                        Console.WriteLine("Тумбочка пуста и одинока, как и ты.");
                    }
                }
                if (choice == "3")
                {
                    if (artVent == false)
                    {
                        Console.WriteLine("В вентиляции оказался странный и некрасивый артефакт(как и твоя жизнь)");
                        artVent = true;
                    }
                    else
                    {
                        Console.WriteLine("Винтялиция пустая, темная и холодная, без единого артефакта");
                    }
                }
                if (choice == "4")
                {
                    if (artBed == false)
                    {
                        Console.WriteLine("Под кроватью оказался уродливый артефакт в виде уха кабана");
                        artBed = true;
                    }
                    else
                    {
                        Console.WriteLine("Под кроватью темно и живет мракобес");
                    }
                }
                if (choice == "5")
                {
                    if (otmuchka == true)
                    {
                        if (artBox == false)
                        {
                            Console.WriteLine("Вы нашли артефакт(*вам грустно из-за его умопомрочительной красоты*");
                            artBox = true;
                        }
                        else
                        {
                            Console.WriteLine("В ящике столь же пусто и безнадежно, что и в вашей ситуации");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ящик заперт, как и сердце той одноклассницы в 6 классе");
                    }
                }
                if (choice == "6")
                {
                    if (artBed && artBox && artVent)
                    {
                        Console.WriteLine("Из-за вашего неземного интелекта и неплохих ништяков в виде артефактов, статуя выдаёт вам ключ.");
                        key = true;
                    }
                    else
                    {
                        Console.WriteLine("Статуя косо посмтрела на вас и послала за 3 версты..");
                    }
                }

            }
        }
    }
}