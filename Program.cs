using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Zahlenratspiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SpielerZahl; //eingegebene Zahl
           
            int Rateversuche = 1;
            string restart;
            int fehler;

            do
            {
                Random rnd = new Random(); 
                int Zufallszahl = rnd.Next(1, 101); //Zufallszahl wird konvertiert

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nZahlenratspiel\n");
                //Console.WriteLine(Zufallszahl);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Geben Sie eine Zahl zwischen 1 und 100 ein: ");

                do
                {
                    fehler = 0;
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        SpielerZahl = Convert.ToInt32(Console.ReadLine()); //eingegebene Zahl wird konvertiert
                        Console.ForegroundColor = ConsoleColor.Green;
                        for (; !(SpielerZahl == Zufallszahl); Rateversuche++)
                        {
                            if (SpielerZahl < Zufallszahl)
                            {
                                Console.WriteLine("Deine Zahl ist zu niedrig. Versuche es nochmals.\n");
                            }
                            else if (SpielerZahl > Zufallszahl)
                            {
                                Console.WriteLine("Deine Zahl ist zu hoch. Versuche es nochmals.\n");
                            }
                            Console.Write("Geben Sie nochmal eine Zahl ein: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            SpielerZahl = Convert.ToInt32(Console.ReadLine()); //eingegebene Zahl wird konvertiert
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }
                    catch
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Bitte geben Sie eine Zahl ein!");
                        Console.ForegroundColor = ConsoleColor.Green;
                        fehler = 1;
                    }
                } while (fehler == 1);



                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Glückwunsch du hast die richtige Zahl erraten! (" + Zufallszahl + ")\n");

                Console.WriteLine("Du hast " + Rateversuche + " Versuche gebraucht\n");
                Rateversuche = 1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("schreibe \"Ja\" um nochmals zu spielen. ");
                restart = Console.ReadLine();
            } while (restart == "Ja");
            Environment.Exit(0);
            
            





        }
    }
}
