using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Bussen
{
    internal class HuvudMeny
    {
        public static void Meny()
        {
            Console.SetWindowSize(Globals.x, 14);

            //  MENU
            Menu.Options = new string[] { " [MENY] Hastighet : \t\t\t",
                                          " [MENY] Passagerare : \t\t\t",
                                          " [MENY] Poke : \t\t\t\t",
                                          " Avsluta Menyn \t\t\t" };

            /*
            Console.WriteLine(Menu.Options[0]);
            //*/


            //*
            Menu.Select = 0;
            Menu.PlaceHolder = "\n    Välkommen! Du är nu chauffören av denna buss." +
                               "\n    Manuvrera fordonet och dess funktioner här : \n";
            
            /*
            MenuSelection.MenuSelect_SHORT();
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

                }
                else if (Menu.Select == 1)
                {
                    Console.WriteLine(Menu.Options[0]);
                    Console.WriteLine(" ** " + Menu.Options[1] + "<--");
                    Console.WriteLine(Menu.Options[2]);
                    Console.WriteLine(Menu.Options[3]);

                }
                else if (Menu.Select == 2)
                {
                    Console.WriteLine(Menu.Options[0]);
                    Console.WriteLine(Menu.Options[1]);
                    Console.WriteLine(" ** " + Menu.Options[2] + "<--");
                    Console.WriteLine(Menu.Options[3]);


                }
                else if (Menu.Select == 3)
                {
                    Console.WriteLine(Menu.Options[0]);
                    Console.WriteLine(Menu.Options[1]);
                    Console.WriteLine(Menu.Options[2]);
                    Console.WriteLine("\n ** " + Menu.Options[3] + "<--");

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
                            F_Speed.Meny();
                            break;
                        case 1:
                            P.Meny();
                            break;
                        case 2:
                            P_Poke.Meny();
                            break;
                        case 3:
                            Menu.Continue = false;
                            //Globals.Exit();
                            break;

                    }
                }
            }   //  WHILE END
        }   //  METHOD END
    }
}
