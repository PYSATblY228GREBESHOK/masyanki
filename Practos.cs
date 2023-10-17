namespace Pract_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите F2 чтобы выбрать октаву или Backspace для выхода");
            ConsoleKeyInfo nota = Console.ReadKey();
            while (nota.Key != ConsoleKey.Backspace)
            {
                if (nota.Key == ConsoleKey.F2)
                {
                    Console.WriteLine("F2");
                    while (nota.Key != ConsoleKey.F3 && nota.Key != ConsoleKey.F5 && nota.Key != ConsoleKey.Backspace)
                    {
                        nota = sound(nota, 1);
                    }
                }
                else if (nota.Key == ConsoleKey.F3)
                {
                    Console.WriteLine("F3");
                    while (nota.Key != ConsoleKey.F2 && nota.Key != ConsoleKey.F5 && nota.Key != ConsoleKey.Backspace)
                    {
                        nota = sound(nota, 2);
                    }
                }
                else if (nota.Key == ConsoleKey.F5)
                {
                    Console.WriteLine("F5");
                    while (nota.Key != ConsoleKey.F2 && nota.Key != ConsoleKey.F3 && nota.Key != ConsoleKey.Backspace)
                    {
                        nota = sound(nota, 3);
                    }
                }
                else
                {
                    Console.WriteLine(" - Такой октавы нет");
                    kl = Console.ReadKey();
                }
            }
        }
        static int Freq(int z, int x)
        {
            int[,] arr = new int[4, 12] { 
            {524, 554, 587, 622, 659, 699, 740, 784, 841, 880, 923, 988}, 
            {1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976}, 
            {2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3956}};
        }
        static ConsoleKeyInfo sound(ConsoleKeyInfo kl, int z) 
        {
            nota = Console.ReadKey();
            if (nota.Key == ConsoleKey.Q) 
            {
                int x = 0;
                int N = Freq(z, x);
                Beep(beep);
            }
            else if (nota.Key == ConsoleKey.W) 
            {
                int x = 1;
                int N = Freq(z,x);
                Beep(beep);
            }
            else if (nota.Key == ConsoleKey.E) 
            {
                int x = 2;
                int N = Freq(z, x);
                Beep(beep);
            }
            else if (nota.Key == ConsoleKey.R) 
            {
                int x = 3;
                int N = Freq(z, x);
                Beep(beep);
            }
            else if (nota.Key == ConsoleKey.T) 
            {
                int x = 4;
                int N = Freq(z, x);
                Beep(beep);
            }
            else if (nota.Key == ConsoleKey.Y) 
            {
                int x = 5;
                int N = Freq(z, x);
                Beep(beep);
            }
            else if (nota.Key == ConsoleKey.U) 
            {
                int x = 6;
                int N = Freq(z, x);
                Beep(beep);
            }
            else if (nota.Key == ConsoleKey.A)
            {
                int x = 7;
                int N = Freq(z, x);
                Beep(beep);
            }
            else if (nota.Key == ConsoleKey.S)
            {
                int x = 8;
                int N = Freq(z, x);
                Beep(beep);
            }
            else if (nota.Key == ConsoleKey.D)
            {
                int x = 9;
                int N = Freq(z, x);
                Beep(beep);
            }
            else if (nota.Key == ConsoleKey.F)
            {
                int x = 10;
                int N = Freq(z, x);
                Beep(beep);
            }
            else if (nota.Key == ConsoleKey.G)
            {
                int x = 11;
                int N = Freq(z, x);
                Beep(beep);
            }
            else if (nota.Key != ConsoleKey.F2 
            && nota.Key != ConsoleKey.F3 
            && nota.Key != ConsoleKey.F5 
            && nota.Key != ConsoleKey.Backspace)
            {
                Console.WriteLine(" - Такой нет ноты");
            }
        }

        public static void Beep(int beep)
        {
            Console.Clear();
            Console.Beep(beep, 300);
        }
    }
}
