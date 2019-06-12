﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolkoikrzyzyk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*===============KÓŁKO I KRZYŻYK===============*");
            Console.WriteLine("       Witaj w grze Kółko i Krzyżyk!");

            Console.Write("Podaj imię pierwszego gracza: ");
            string gracz1 = Console.ReadLine();

            Console.Write("Podaj imię drugiego gracza: ");
            string gracz2 = Console.ReadLine();

            var x = "X";
            var o = "O";

            Console.WriteLine($"{gracz1} otrzymuje znak {x}, {gracz2} otrzymuje znak {o}");

            var plansza = new string[3, 3];

            var ostatniZnak = x;
            while (true)
            {
                var znak = Console.ReadKey();

                if (znak.KeyChar == '7')
                {
                    if (string.IsNullOrWhiteSpace(plansza[0, 0]))
                    {
                        plansza[0, 0] = ostatniZnak;
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
                    }
                    else
                    {
                        Console.WriteLine("To pole jest już zajęte");
                    }
                }
                else if(znak.KeyChar == '9')
                {
                    if (string.IsNullOrWhiteSpace(plansza[0, 2]))
                    {
                        plansza[0, 2] = ostatniZnak;
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
                        Console.Write(plansza[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                if (ostatniZnak == x)
                {
                    ostatniZnak = o;
                }
                else
                {
                    ostatniZnak = x;
                }
            }

            Console.ReadKey();
        }
    }
}