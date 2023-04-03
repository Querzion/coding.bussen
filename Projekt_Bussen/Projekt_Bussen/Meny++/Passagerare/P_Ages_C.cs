using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Bussen
{
    internal class P_Ages_C
    {
        public static void Meny()
        {
            Console.SetWindowSize(Globals.x, Globals.y);

            //  MENU
            Menu.Options = new string[] { " Kombinerad Ålder ( Total ) \t\t",
                                          " Kombinerad Ålder ( Barn ) \t\t",
                                          " Kombinerad Ålder ( Ungdomar ) \t\t",
                                          " Kombinerad Ålder ( Vuxna ) \t\t",
                                          " Kombinerad Ålder ( Pensionärer ) \t",
                                          " Tillbaka till föregående meny : \t\t" };

            Menu.Select = 0;
            Menu.PlaceHolder = "\n    [INSTANSER] Högsta Ålder på Passagerare : " +
                               "\n    Välj Instans : \n";

            /*
            MenuSelection.MenuSelect_LONG();
            //*/

            Menu.Continue = true;

            while (Menu.Continue)
            {
                Console.Clear();
                Console.CursorVisible = false;

                Console.Write("\n|-----------------------------------------------------|\n" +
                              Menu.PlaceHolder +
                              "\n|-----------------------------------------------------|\n\n");


                if (Menu.Select == 0)
                {
                    Console.WriteLine(" ** " + Menu.Options[0] + "<--");
                    Console.WriteLine(Menu.Options[1]);
                    Console.WriteLine(Menu.Options[2]);
                    Console.WriteLine(Menu.Options[3]);
                    Console.WriteLine(Menu.Options[4]);
                    Console.WriteLine(Menu.Options[5]);
                
                }
                else if (Menu.Select == 1)
                {
                    Console.WriteLine(Menu.Options[0]);
                    Console.WriteLine(" ** " + Menu.Options[1] + "<--");
                    Console.WriteLine(Menu.Options[2]);
                    Console.WriteLine(Menu.Options[3]);
                    Console.WriteLine(Menu.Options[4]);
                    Console.WriteLine(Menu.Options[5]);
                
                }
                else if (Menu.Select == 2)
                {
                    Console.WriteLine(Menu.Options[0]);
                    Console.WriteLine(Menu.Options[1]);
                    Console.WriteLine(" ** " + Menu.Options[2] + "<--");
                    Console.WriteLine(Menu.Options[3]);
                    Console.WriteLine(Menu.Options[4]);
                    Console.WriteLine(Menu.Options[5]);

                }
                else if (Menu.Select == 3)
                {
                    Console.WriteLine(Menu.Options[0]);
                    Console.WriteLine(Menu.Options[1]);
                    Console.WriteLine(Menu.Options[2]);
                    Console.WriteLine(" ** " + Menu.Options[3] + "<--");
                    Console.WriteLine(Menu.Options[4]);
                    Console.WriteLine(Menu.Options[5]);

                }
                else if (Menu.Select == 4)
                {
                    Console.WriteLine(Menu.Options[0]);
                    Console.WriteLine(Menu.Options[1]);
                    Console.WriteLine(Menu.Options[2]);
                    Console.WriteLine(Menu.Options[3]);
                    Console.WriteLine(" ** " + Menu.Options[4] + "<--");
                    Console.WriteLine(Menu.Options[5]);

                }
                else if (Menu.Select == 5)
                {
                    Console.WriteLine(Menu.Options[0]);
                    Console.WriteLine(Menu.Options[1]);
                    Console.WriteLine(Menu.Options[2]);
                    Console.WriteLine(Menu.Options[3]);
                    Console.WriteLine(Menu.Options[4]);
                    Console.WriteLine("\n ** " + Menu.Options[5] + "<--");

                }



                Console.WriteLine("\n|-----------------------------------------------------|\n");

                var keyPressed = Console.ReadKey();

                if (keyPressed.Key == ConsoleKey.DownArrow && Menu.Select != Menu.Options.Length - 1)
                {
                    Menu.Select++;
                }
                else if (keyPressed.Key == ConsoleKey.UpArrow && Menu.Select >= 1)
                {
                    Menu.Select--;
                }
                else if (keyPressed.Key == ConsoleKey.Enter)
                {
                    switch (Menu.Select)
                    {
                        case 0:
                            CA_Total();
                            break;
                        case 1:
                            CA_Barn();
                            break;
                        case 2:
                            CA_Ungdomar();
                            break;
                        case 3:
                            CA_Vuxna();
                            break;
                        case 4:
                            CA_Pensionärer();
                            break;
                        case 5:
                        default:
                            P_Ages.Meny();
                            break;

                    }
                }
            }   //  WHILE END
        }   //  METHOD END


        //*
        public static void CA_Total()
        {
            Globals.cTotal = Globals.rAge.Sum();
            Console.WriteLine(" Den kombinerade åldern på resenärerna är: {0} år", Globals.cTotal);
            Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");
            Console.ReadLine();
            return;
        }
        //*/

        //*
        public static void CA_Barn()
        {
            Globals.cTotal = Globals.rAgeBarn.Sum();
            Console.WriteLine(" Den kombinerade åldern på resenärerna är: {0} år", Globals.cTotal);
            Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");
            Console.ReadLine();
            return;
        }
        //*/

        //*
        public static void CA_Ungdomar()
        {
            Globals.cTotal = Globals.rAgeUngdom.Sum();
            Console.WriteLine(" Den kombinerade åldern på resenärerna är: {0} år", Globals.cTotal);
            Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");
            Console.ReadLine();
            return;
        }
        //*/

        //*
        public static void CA_Vuxna()
        {
            Globals.cTotal = Globals.rAgeVuxen.Sum();
            Console.WriteLine(" Den kombinerade åldern på resenärerna är: {0} år", Globals.cTotal);
            Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");
            Console.ReadLine();
            return;
        }
        //*/

        //*
        public static void CA_Pensionärer()
        {
            Globals.cTotal = Globals.rAgePensionär.Sum();
            Console.WriteLine(" Den kombinerade åldern på resenärerna är: {0} år", Globals.cTotal);
            Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");
            Console.ReadLine();
            return;
        }
        //*/

    }
}
