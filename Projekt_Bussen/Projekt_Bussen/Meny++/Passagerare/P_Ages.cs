using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Bussen
{
    internal class P_Ages
    {
        public static void Meny()
        {
            Console.SetWindowSize(Globals.x, Globals.y);

            //  MENU


            Menu.Options = new string[] { " [MENY] Medelålder \t\t\t\t",
                                          " [MENY] Lägsta Ålder \t\t\t",
                                          " [MENY] Högsta Ålder \t\t\t",
                                          " Sammanlagd Ålder  \t\t\t\t",
                                          " Tillbaka till föregående meny : \t\t" };

            Menu.Select = 0;
            Menu.PlaceHolder = "\n    [MENY] Räkna Baserat på Ålder på Passagerare : " +
                               "\n    Välj Instans : \n";

            /*
            MenuSelection.MenuSelect_MIDDLE();
            //*/

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

                }
                else if (Menu.Select == 1)
                {
                    Console.WriteLine(Menu.Options[0]);
                    Console.WriteLine(" ** " + Menu.Options[1] + "<--");
                    Console.WriteLine(Menu.Options[2]);
                    Console.WriteLine(Menu.Options[3]);
                    Console.WriteLine(Menu.Options[4]);

                }
                else if (Menu.Select == 2)
                {
                    Console.WriteLine(Menu.Options[0]);
                    Console.WriteLine(Menu.Options[1]);
                    Console.WriteLine(" ** " + Menu.Options[2] + "<--");
                    Console.WriteLine(Menu.Options[3]);
                    Console.WriteLine(Menu.Options[4]);

                }
                else if (Menu.Select == 3)
                {
                    Console.WriteLine(Menu.Options[0]);
                    Console.WriteLine(Menu.Options[1]);
                    Console.WriteLine(Menu.Options[2]);
                    Console.WriteLine(" ** " + Menu.Options[3] + "<--");
                    Console.WriteLine(Menu.Options[4]);

                }
                else if (Menu.Select == 4)
                {
                    Console.WriteLine(Menu.Options[0]);
                    Console.WriteLine(Menu.Options[1]);
                    Console.WriteLine(Menu.Options[2]);
                    Console.WriteLine(Menu.Options[3]);
                    Console.WriteLine("\n ** " + Menu.Options[4] + "<--");

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
                            P_Ages_M.Meny();
                            break;
                        case 1:
                            Globals.rAgeBarn.Sort();
                            Globals.rAgeUngdom.Sort();
                            Globals.rAgeVuxen.Sort();
                            Globals.rAgePensionär.Sort();
                            P_Ages_L.Meny();
                            break;
                        case 2:
                            Globals.rAgeBarn.Reverse();
                            Globals.rAgeUngdom.Reverse();
                            Globals.rAgeVuxen.Reverse();
                            Globals.rAgePensionär.Reverse();
                            P_Ages_H.Meny();
                            break;
                        case 3:
                            P_Ages_C.Meny();
                            break;
                        case 4:
                        default:
                            P_Count.Meny();
                            break;

                    }
                }
            }   //  WHILE END
        }   //  METHOD END
    }
}
