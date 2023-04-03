using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Bussen
{
    internal class P_Poke
    {
        public static void Meny()
        {
            Console.SetWindowSize(Globals.x, Globals.y);

            //  MENU
            Menu.Options = new string[] { " Peta på Chauffören : \t\t\t",
                                          " Peta på Personen Framför : \t\t",
                                          " Peta på Personen Bakom : \t\t\t",
                                          " Peta på Personen till Vänster : \t\t",
                                          " Peta på Personen till Höger : \t\t",
                                          " Tillbaka till föregående meny : \t\t" };

            Menu.Select = 0;
            Menu.PlaceHolder = "\n    [INSTANSER] Peta på : " +
                               "\n    Välj Instans : \n";

            /*
            MenuSelection.MenuSelect_LONG();        // Jag hade planer på att använda samma meny och pressa in information därigenom, men det funkade inte.
            //*/                                    // Just nu har jag problem med att 

            Menu.Continue = true;
            
            while (true)
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
                            Peta_Chaufför();
                            break;
                        case 1:
                            Peta_Framför();
                            break;
                        case 2:
                            Peta_Bakåt();
                            break;
                        case 3:
                            Peta_Vänster();
                            break;
                        case 4:
                            Peta_Höger();
                            break;
                        case 5:
                            HuvudMeny.Meny();
                            break;

                    }
                }
            }   // WHILE END
        }   //  METHOD END

        //*
        public static void Peta_Chaufför()      // 
        {
            Console.WriteLine("\t Hej! *Tittar på vägen* " +
                              "\n\t Vad vill du veta?");
            //  Meny med frågor och svar.
            Borked.Uppmaning();
            Console.WriteLine("\t ... ");
            Console.ReadKey();
            return;
        }
        //*/

        //*
        public static void Peta_Framför()       //  Random barn/ungdom/vuxen/pensionär
        {
            Borked.Uppmaning();
            Console.WriteLine("\t ... ");
            Console.ReadKey();
            return;
        }
        //*/

        //*
        public static void Peta_Bakåt()         //  Random barn/ungdom/vuxen/pensionär
        {
            Borked.Uppmaning();
            Console.WriteLine("\t ... ");
            Console.ReadKey();
            return;
        }
        //*/

        //*
        public static void Peta_Vänster()         //  Random barn/ungdom/vuxen/pensionär
        {
            Borked.Uppmaning();
            Console.WriteLine("\t ... ");
            Console.ReadKey();
            return;
        }
        //*/

        //*
        public static void Peta_Höger()         //  Random barn/ungdom/vuxen/pensionär
        {
            Borked.Uppmaning();
            Console.WriteLine("\t ... ");
            Console.ReadKey();
            return;
        }
        //*/


    }
}
