using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Bussen
{
    internal class P_Ages_M
    {
        public static void Meny()
        {   
            Console.SetWindowSize(Globals.x, Globals.y);

            //  MENU
            Menu.Options = new string[] { " Medelålder ( Total ) \t\t\t",
                                          " Medelålder ( Barn ) \t\t\t",
                                          " Medelålder ( Ungdomar ) \t\t\t",
                                          " Medelålder ( Vuxna ) \t\t\t",
                                          " Medelålder ( Pensionärer ) \t\t",
                                          " Tillbaka till föregående meny : \t\t" };

            Menu.Select = 0;
            Menu.PlaceHolder = "\n    [INSTANSER] Medelålder på Passagerare : " +
                               "\n    Välj Instans : \n";
            /*
            MeuSelection.MenuSelect_LONG();
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
                            MÅ_Total();
                            break;
                        case 1:
                            MÅ_Barn();
                            break;
                        case 2:
                            MÅ_Ungdomar();
                            break;
                        case 3:
                            MÅ_Vuxna();
                            break;
                        case 4:
                            MÅ_Pensionärer();
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
        public static void MÅ_Total()
        {
            Borked.Uppmaning();
            Console.WriteLine("\t ... ");
            Console.ReadKey();
            return;
        }
        //*/

        //*
        public static void MÅ_Barn()
        {
            Borked.Uppmaning();
            Console.WriteLine("\t ... ");
            Console.ReadKey();
            return;
        }
        //*/

        //*
        public static void MÅ_Ungdomar()
        {
            Borked.Uppmaning();
            Console.WriteLine("\t ... ");
            Console.ReadKey();
            return;
        }
        //*/

        //*
        public static void MÅ_Vuxna()
        {
            Borked.Uppmaning();
            Console.WriteLine("\t ... ");
            Console.ReadKey();
            return;
        }
        //*/

        //*
        public static void MÅ_Pensionärer()
        {
            Borked.Uppmaning();
            Console.WriteLine("\t ... ");
            Console.ReadKey();
            return;
        }
        //*/

    }
}
