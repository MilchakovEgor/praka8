using System.ComponentModel;
using System.Diagnostics.Metrics;
using wrireSpeedTest;

write wr = new write();
Console.WriteLine("Введите имя");
string name = Console.ReadLine();

Console.Clear();
string txt = "Текст - зафиксированная на каком-либо материальном носителе человеческая мысль; в общем плане связная и полная последовательность символов.";
Console.WriteLine(txt);
Class2.th.Start();


while (true)
{
    if (wr.window1 == 0)
    {
        wr.wr(txt, name);
    }
    else if (wr.window1 == 2)
    {
        wr.menu(name);
    }
}