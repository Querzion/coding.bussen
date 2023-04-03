using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Bussen
{
    internal class P_Gender    {
        public static void Meny()
        {
            Console.SetWindowSize(Globals.x, Globals.y);

            //  MENU
            Menu.Options = new string[] { " Procent Fördelning : \t\t\t",
                                          " Pojkar/Män/Gubbar : \t\t\t",
                                          " Flickor/Kvinnor/Gummor : \t\t\t",
                                          " Icke-Binära : \t\t\t\t",                                          
                                          " Tillbaka till föregående meny : \t\t" };

            Menu.Select = 0;
            Menu.PlaceHolder = "\n    [INSTANSER] Räkna Baserat på Kön : " +
                               "\n    Sätt parametrarna här : \n";

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
                            PercentMF();
                            break;
                        case 1:
                            Male();
                            break;
                        case 2:
                            Female();
                            break;
                        case 3:
                            Delusion();
                            break;
                        case 4:
                        default:
                            P_Count.Meny();
                            break;

                    }
                }
            }   //  WHILE END
        }   //  METHOD END

        //*
        public static void Male()
        {
            Console.WriteLine("\n Det är {0} Pojkar/Män/Gubbar på bussen." +
                              "\n Det var totalt {1} Pojkar/Män/Gubbar under resans gång.");

            Borked.Uppmaning();
            Console.WriteLine("\t ... ");
            Console.ReadKey();
            return;
        }
        //*/

        //*
        public static void Female()
        {
            Console.WriteLine("\n Det är {0} Flickor/Kvinnor/Gummor på bussen." +
                              "\n Det var totalt {1} Flickor/Kvinnor/Gummor under resans gång.");

            Borked.Uppmaning();
            Console.WriteLine("\t ... ");
            Console.ReadKey();
            return;
        }
        //*/

        //*
        public static void Delusion()
        {
            Console.WriteLine("\n Det är {0} Icke-Binära på bussen." +
                              "\n Det var totalt {1} Icke-Binära under resans gång.");

            Borked.Uppmaning();
            Console.WriteLine("\t ... ");
            Console.ReadKey();
            return;
        }
        //*/


        //*
        public static void PercentMF()
        {
            Console.WriteLine("\n Procent : " +
                              "\n|-------------------------------|" +
                              "\n|   {0}% Pojkar        (0-18)   |" +
                              "\n|   {1}% Män           (18-65)  |" +
                              "\n|   {2}% Gubbar        (65+)    |" +
                              "\n|-------------------------------|" +
                              "\n|   {3}% Flickor       (0-18)   |" + 
                              "\n|   {4}% Kvinnor       (18-65)  |" +
                              "\n|   {5}% Gummor        (65+)    |" +
                              "\n|-------------------------------|" +
                              "\n|   {6}% Icke-Binära,  (15+)    |" +
                              "\n|   {7}% Vuxna Män     (18+)    |" +
                              "\n|   {8}% Vuxna Kvinnor (18+)    |" +
                              "\n|-------------------------------|");

            Borked.Uppmaning();
            Console.WriteLine("\t ... ");
            Console.ReadKey();
            return;
        }
        //*/


        /*
        public static void Count_Pensionärer()
        {
            Console.WriteLine("\n Det är {0} pensionär/-er på bussen." +
                              "\n Det var totalt {1} pensionär/-er under resans gång.");

            Borked.Uppmaning();
            Console.WriteLine("\t ... ");
            Console.ReadKey();
            return;
        }
        //*/
    }
}
