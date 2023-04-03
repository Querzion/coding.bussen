using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Bussen
{
    internal class P_Numbers
    {
        public static void Meny()
        {
            Console.SetWindowSize(Globals.x, 19);

            //  MENU
            Menu.Options = new string[] { " Antal - Total & Lediga Platser : \t\t",
                                          " Antal Barn : \t\t\t\t",
                                          " Antal Ungdomar : \t\t\t\t",
                                          " Antal Vuxna : \t\t\t\t",
                                          " Antal Pensionärer : \t\t\t",
                                          " Tillbaka till föregående meny : \t\t" };

            Menu.Select = 0;
            Menu.PlaceHolder = "\n    [INSTANSER] Räkna Passagerare : " +
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
                            Console.SetWindowSize(Globals.x, 24);
                            Count_Total();
                            Console.SetWindowSize(Globals.x, 19);
                            break;
                        case 1:
                            Console.SetWindowSize(Globals.x, 24);
                            Count_Barn();
                            Console.SetWindowSize(Globals.x, 19);
                            break;
                        case 2:
                            Console.SetWindowSize(Globals.x, 24);
                            Count_Ungdomar();
                            Console.SetWindowSize(Globals.x, 19);
                            break;
                        case 3:
                            Console.SetWindowSize(Globals.x, 24);
                            Count_Vuxna();
                            Console.SetWindowSize(Globals.x, 19);
                            break;
                        case 4:
                            Console.SetWindowSize(Globals.x, 24);
                            Count_Pensionärer();
                            Console.SetWindowSize(Globals.x, 19);
                            break;
                        case 5:
                        default:
                            P_Count.Meny();
                            break;

                    }
                }
            }   //  WHILE END
        }   //  METHOD END

        //*
        public static void Count_Total()
        {
            Console.WriteLine("\n Det är {0} resenärer på bussen." +
                              "\n Det är {1} lediga platser kvar.", Globals.resenärAntal, Globals.ledigaStolar);
            Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");
            Console.ReadLine();
            return;
        }
        //*/

        //*
        public static void Count_Barn()
        {
            Console.WriteLine("\n Det var totalt {0} barn under resans gång.", Globals.Barn);
            Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");
            Console.ReadLine();
            return;
        }
        //*/

        //*
        public static void Count_Ungdomar()
        {
            Console.WriteLine("\n Det var totalt {0} ungdom/-ar under resans gång.", Globals.Ungdom);
            Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");

            Console.ReadLine();
            return;
        }
        //*/


        //*
        public static void Count_Vuxna()
        {
            Console.WriteLine("\n Det var totalt {0} vuxen/-na under resans gång.", Globals.Vuxen);
            Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");

            Console.ReadLine();
            return;
        }
        //*/


        //*
        public static void Count_Pensionärer()
        {
            Console.WriteLine("\n Det var totalt {0} pensionär/-er under resans gång.", Globals.Pensionär);
            Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");

            Console.ReadLine();
            return;
        }
        //*/
    }
}
