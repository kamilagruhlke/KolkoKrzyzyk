using System;
using System.Collections.Generic;

namespace Gra.Logika
{
    public class KolkoKrzyzyk
    {
        private readonly Dictionary<string, string> Gracze;

        private readonly string[,] plansza = new string[3, 3];

        public KolkoKrzyzyk(string gracz1, string gracz2)
        {
            Gracze = new Dictionary<string, string>()
            {
                { "X", gracz1 },
                { "O", gracz2 }
            };
        }

        public void Uruchom()
        {
            foreach (var gracz in Gracze)
            {
                Console.WriteLine($"{gracz.Value} jest {gracz.Key}");
            }

            var ostatniZnak = "X";
            while (true)
            {
                var znak = Console.ReadKey();
                bool zmianaZnaku = false;

                if (znak.KeyChar == '7')
                {
                    if (string.IsNullOrWhiteSpace(plansza[0, 0]))
                    {
                        plansza[0, 0] = ostatniZnak;
                        zmianaZnaku = true;
                    }
                    else
                    {
                        Console.WriteLine("To pole jest już zajęte");
                    }
                }
                else if (znak.KeyChar == '8')
                {
                    if (string.IsNullOrWhiteSpace(plansza[0, 1]))
                    {
                        plansza[0, 1] = ostatniZnak;
                        zmianaZnaku = true;
                    }
                    else
                    {
                        Console.WriteLine("To pole jest już zajęte");
                    }
                }
                else if (znak.KeyChar == '9')
                {
                    if (string.IsNullOrWhiteSpace(plansza[0, 2]))
                    {
                        plansza[0, 2] = ostatniZnak;
                        zmianaZnaku = true;
                    }
                    else
                    {
                        Console.WriteLine("To pole jest już zajęte");
                    }
                }
                else if (znak.KeyChar == '4')
                {
                    if (string.IsNullOrWhiteSpace(plansza[1, 0]))
                    {
                        plansza[1, 0] = ostatniZnak;
                        zmianaZnaku = true;
                    }
                    else
                    {
                        Console.WriteLine("To pole jest już zajęte");
                    }
                }
                else if (znak.KeyChar == '5')
                {
                    if (string.IsNullOrWhiteSpace(plansza[1, 1]))
                    {
                        plansza[1, 1] = ostatniZnak;
                        zmianaZnaku = true;
                    }
                    else
                    {
                        Console.WriteLine("To pole jest już zajęte");
                    }
                }
                else if (znak.KeyChar == '6')
                {
                    if (string.IsNullOrWhiteSpace(plansza[1, 2]))
                    {
                        plansza[1, 2] = ostatniZnak;
                        zmianaZnaku = true;
                    }
                    else
                    {
                        Console.WriteLine("To pole jest już zajęte");
                    }
                }
                else if (znak.KeyChar == '1')
                {
                    if (string.IsNullOrWhiteSpace(plansza[2, 0]))
                    {
                        plansza[2, 0] = ostatniZnak;
                        zmianaZnaku = true;
                    }
                    else
                    {
                        Console.WriteLine("To pole jest już zajęte");
                    }
                }
                else if (znak.KeyChar == '2')
                {
                    if (string.IsNullOrWhiteSpace(plansza[2, 1]))
                    {
                        plansza[2, 1] = ostatniZnak;
                        zmianaZnaku = true;
                    }
                    else
                    {
                        Console.WriteLine("To pole jest już zajęte");
                    }
                }
                else if (znak.KeyChar == '3')
                {
                    if (string.IsNullOrWhiteSpace(plansza[2, 2]))
                    {
                        plansza[2, 2] = ostatniZnak;
                        zmianaZnaku = true;
                    }
                    else
                    {
                        Console.WriteLine("To pole jest już zajęte");
                    }
                }

                Console.WriteLine();

                //kolumny
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (string.IsNullOrWhiteSpace(plansza[i, j]))
                        {
                            Console.Write("  ");
                        }
                        else
                        {
                            Console.Write(plansza[i, j] + " ");
                        }

                    }
                    Console.WriteLine();
                }

                if (SprawczCzyWygral(plansza, ostatniZnak))
                {
                    Console.WriteLine($"Wygrał {Gracze[ostatniZnak]}");
                    break;
                }

                if (zmianaZnaku)
                {
                    if (ostatniZnak == "X")
                    {
                        ostatniZnak = "O";
                    }
                    else
                    {
                        ostatniZnak = "X";
                    }
                }
            }

            Console.ReadKey();
        }

        private bool SprawczCzyWygral(string[,] plansza, string gracz)
        {
            if (plansza[0, 0] == gracz && plansza[0, 1] == gracz && plansza[0, 2] == gracz)
            {
                return true;
            }
            else if (plansza[1, 0] == gracz && plansza[1, 1] == gracz && plansza[1, 2] == gracz)
            {
                return true;
            }
            else if (plansza[2, 0] == gracz && plansza[2, 1] == gracz && plansza[2, 2] == gracz)
            {
                return true;
            }
            else if (plansza[0, 0] == gracz && plansza[1, 0] == gracz && plansza[2, 0] == gracz)
            {
                return true;
            }
            else if (plansza[0, 1] == gracz && plansza[1, 1] == gracz && plansza[2, 1] == gracz)
            {
                return true;
            }
            else if (plansza[0, 2] == gracz && plansza[1, 2] == gracz && plansza[2, 2] == gracz)
            {
                return true;
            }
            else if (plansza[0, 0] == gracz && plansza[1, 1] == gracz && plansza[2, 2] == gracz)
            {
                return true;
            }
            else if (plansza[0, 2] == gracz && plansza[1, 1] == gracz && plansza[2, 0] == gracz)
            {
                return true;
            }

            return false;
        }
        private bool CzyGraZakonczona(string[,] plansza, string znak)
        {
            if (plansza[0, 0] == znak)
            {
                return true;
            }


        }
    }
}
