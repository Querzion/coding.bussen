using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Bussen
{
    internal class P_Ages_L
    {
        public static void Meny()
        {
            Console.SetWindowSize(Globals.x, Globals.y);

            //  MENU
            Menu.Options = new string[] { " Lägsta Ålder ( Total ) \t\t\t",
                                          " Lägsta Ålder ( Barn ) \t\t\t",
                                          " Lägsta Ålder ( Ungdomar ) \t\t\t",
                                          " Lägsta Ålder ( Vuxna ) \t\t\t",
                                          " Lägsta Ålder ( Pensionärer ) \t\t",
                                          " Tillbaka till föregående meny : \t\t" };

            Menu.Select = 0;
            Menu.PlaceHolder = "\n    [INSTANSER] Lägsta Ålder på Passagerare : " +
                               "\n    Välj Instans : \n";
            /*
            MenuSelection.MenuSelect_LONG();        //  Remnant from the first Menu instance.
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
                            Total();
                            break;
                        case 1:
                            Barn();
                            break;
                        case 2:
                            Ungdomar();
                            break;
                        case 3:
                            Vuxna();
                            break;
                        case 4:
                            Pensionärer();
                            break;
                        case 5:
                        default:
                            /*     Tänkte lite fel här då det blir sort två gånger på rad = Reverse.
                            Globals.rAgeBarn.Sort();
                            Globals.rAgeUngdom.Sort();
                            Globals.rAgeVuxen.Sort();
                            Globals.rAgePensionär.Sort();
                            //*///
                            P_Ages.Meny();
                            break;

                    }
                }
            }   //  WHILE END
        }   //  METHOD END

        //*
        public static void Total()
        {
            
            if (Globals.rAgeBarn.Count > 0)
            {
                Console.WriteLine("Den yngsta resenären vi haft var {0} år.", Globals.rAgeBarn[0]);

            }
            else if (Globals.rAgeUngdom.Count > 0)
            {
                Console.WriteLine("Den yngsta resenären vi haft var {0} år.", Globals.rAgeUngdom[0]);
            }
            else if (Globals.rAgeVuxen.Count > 0)
            {
                Console.WriteLine("Den yngsta resenären vi haft var {0} år.", Globals.rAgeVuxen[0]);
            }
            else if (Globals.rAgePensionär.Count > 0)
            {
                Console.WriteLine("Den yngsta resenären vi haft var {0} år.", Globals.rAgePensionär[0]);
            }
            else
            {
                Console.WriteLine(" Det finns ännu inga sparade åldrar.");
            }
            Console.ReadKey();
            return;
        }
        //*/

        //*
        public static void Barn()
        {
            if (Globals.rAgeBarn.Count > 0)
            {
                Console.WriteLine("Den yngsta barn resenären vi haft var {0} år.", Globals.rAgeBarn[0]);

            } 
            else
            {
                Console.WriteLine(" Det är {0} sparade åldrar för barn här. ", Globals.rAgeBarn.Count);
            }
            Console.ReadKey();
            return;

        }
        //*/

        //*
        public static void Ungdomar()
        {
            if (Globals.rAgeUngdom.Count > 0)
            {
                Console.WriteLine("Den yngsta ungdoms resenären vi haft var {0} år.", Globals.rAgeUngdom[0]);

            }
            else
            {
                Console.WriteLine(" Det är {0} sparade åldrar för ungdomar här. ", Globals.rAgeUngdom.Count);
            }
            Console.ReadKey();
            return;
        }
        //*/

        //*
        public static void Vuxna()
        {
            if (Globals.rAgeVuxen.Count > 0)
            {
                Console.WriteLine("Den yngsta vuxna resenären vi haft var {0} år.", Globals.rAgeVuxen[0]);

            }
            else
            {
                Console.WriteLine(" Det är {0} sparade åldrar för vuxna här. ", Globals.rAgeVuxen.Count);
            }
            Console.ReadKey();
            return;
        }
        //*/

        //*
        public static void Pensionärer()
        {
            if (Globals.rAgePensionär.Count > 0)
            {
                Console.WriteLine("Den yngsta pensionären resenären vi haft var {0} år.", Globals.rAgePensionär[0]);

            }
            else
            {
                Console.WriteLine(" Det är {0} sparade åldrar för pensionärer här. ", Globals.rAgePensionär.Count);
            }
            Console.ReadKey();
            return;
        }
        //*/

    }
}