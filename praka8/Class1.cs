using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wrireSpeedTest
{
    internal class write
    {
        int posicion_x = 0;
        int posicion_y = 0;
        public int window = 0;
        public int window1 = 0;
        int count = 0;
        int count_rrr = 0;

        public void wr(string txt, string name)
        {
            char[] c = txt.ToArray();
            if (window == 0)
            {

                foreach (char i in c)
                {
                    Console.SetCursorPosition(0, 25);
                    ConsoleKeyInfo key = Console.ReadKey();
                    char kkk = key.KeyChar;
                    Console.SetCursorPosition(0, 25);
                    Console.WriteLine("     ");
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine("     ");
                    if (Class2.time == 0)
                    {
                        window = 1;
                        break;
                    }
                    try
                    {
                        if (kkk == i)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(posicion_x, posicion_y);
                            Console.WriteLine(kkk);
                            count_rrr++;
                            posicion_x++;
                        }
                        else if (kkk != i)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(posicion_x, posicion_y);
                            Console.WriteLine(kkk);
                            count++;
                            count_rrr++;
                            posicion_x++;
                        }
                    }
                    catch { posicion_y += 1; posicion_x = 0; }

                }
                //time = 0;
                window = 1;
                Class2.islitenning = false;
            }
            else if (window == 1)
            {
                window = 1;
                double sec = ((double)count_rrr / (double)Class2.time) / 60;
                double min = ((double)count_rrr / (double)Class2.time);
                Console.SetCursorPosition(0, 14);
                Console.WriteLine("Имя - " + name);
                Console.WriteLine("Ваш результат символов в секунду - " + sec);
                Console.WriteLine("Ваш результат символов в минуту - " + min);
                Console.WriteLine("Количевство ошибок - " + count);
                Console.WriteLine("Нажмите enter чтобы сохранить");
                ConsoleKeyInfo keyn = Console.ReadKey();
                if (keyn.Key == ConsoleKey.Enter)
                {
                    class4 statistic = new class4();
                    statistic.Name = name;
                    statistic.word_second = sec;
                    statistic.word_minute = min;
                    statistic.word_error = count;
                    class3.Statistic_User(statistic);
                }
                else if (keyn.Key == ConsoleKey.F1)
                {
                    window = 2;
                    window1 = 2;
                }

            }
        }

        public void menu(string name)
        {
            window1 = 0;
            Class2.time = 60;
            Console.Clear();
            string txt = "Текст - зафиксированная на каком-либо материальном носителе человеческая мысль; в общем плане связная и полная последовательность символов.";
            Class2.islitenning = true;
            Console.WriteLine(txt);
            if (window != 2)
            {
                Class2.th.Start();
            }

            window = 0;
            posicion_x = 0;
            posicion_y = 0;
            count = 0;
            wr(txt, name);
        }
    }
}