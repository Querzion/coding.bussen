using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Bussen
{
    internal class P_Count
    {
        public static void Meny()
        {
            Console.SetWindowSize(Globals.x, 17);

            //  MENU
            Menu.Options = new string[] { " [MENY] Antal Passagerare : \t\t",
                                          " [MENY] Baserat på Ålder : \t\t\t",
                                          " [MENY] Baserat på Kön : \t\t\t",
                                          " [MENY] Biljetter : \t\t\t",
                                          " Tillbaka till föregående meny : \t\t" };

            Menu.Select = 0;
            Menu.PlaceHolder = "\n    [MENY] Räkna Passagerare : " +
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
                            P_Numbers.Meny();
                            break;
                        case 1:
                            P_Ages.Meny();
                            break;
                        case 2:
                            P_Gender.Meny();
                            break;
                        case 3:
                            P_Tickets_Sold.Meny();
                            break;
                        case 4:
                        default:
                            P.Meny();
                            break;

                    }
                }
            }   //  WHILE END
        }   //  METHOD END
    }
}
