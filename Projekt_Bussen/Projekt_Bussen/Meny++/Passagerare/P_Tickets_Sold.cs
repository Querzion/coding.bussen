using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Bussen
{
    internal class P_Tickets_Sold
    {
        public static void Meny()
        {
            Console.SetWindowSize(Globals.x, 19);

            //  MENU
            Menu.Options = new string[] { " Biljetter : Priser \t",
                                          " Sålda BARN Biljetter & Värde : \t\t",
                                          " Sålda UNGDOMS Biljetter & Värde : \t\t",
                                          " Sålda VUXEN Biljetter & Värde : \t\t",
                                          " Sålda PENSIONÄRS Biljetter & Värde : \t",
                                          " TOTALT Sålda Biljetter & Värde : \t\t",
                                          " Tillbaka till föregående meny : \t\t" };

            Menu.Select = 0;
            Menu.PlaceHolder = "\n    [INSTANSER] Räkna Sålda Biljetter : " +
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
                    Console.WriteLine(Menu.Options[6]);

                }
                else if (Menu.Select == 1)
                {
                    Console.WriteLine(Menu.Options[0]);
                    Console.WriteLine(" ** " + Menu.Options[1] + "<--");
                    Console.WriteLine(Menu.Options[2]);
                    Console.WriteLine(Menu.Options[3]);
                    Console.WriteLine(Menu.Options[4]);
                    Console.WriteLine(Menu.Options[5]);
                    Console.WriteLine(Menu.Options[6]);

                }
                else if (Menu.Select == 2)
                {
                    Console.WriteLine(Menu.Options[0]);
                    Console.WriteLine(Menu.Options[1]);
                    Console.WriteLine(" ** " + Menu.Options[2] + "<--");
                    Console.WriteLine(Menu.Options[3]);
                    Console.WriteLine(Menu.Options[4]);
                    Console.WriteLine(Menu.Options[5]);
                    Console.WriteLine(Menu.Options[6]);

                }
                else if (Menu.Select == 3)
                {
                    Console.WriteLine(Menu.Options[0]);
                    Console.WriteLine(Menu.Options[1]);
                    Console.WriteLine(Menu.Options[2]);
                    Console.WriteLine(" ** " + Menu.Options[3] + "<--");
                    Console.WriteLine(Menu.Options[4]);
                    Console.WriteLine(Menu.Options[5]);
                    Console.WriteLine(Menu.Options[6]);

                }
                else if (Menu.Select == 4)
                {
                    Console.WriteLine(Menu.Options[0]);
                    Console.WriteLine(Menu.Options[1]);
                    Console.WriteLine(Menu.Options[2]);
                    Console.WriteLine(Menu.Options[3]);
                    Console.WriteLine(" ** " + Menu.Options[4] + "<--");
                    Console.WriteLine(Menu.Options[5]);
                    Console.WriteLine(Menu.Options[6]);

                }
                else if (Menu.Select == 5)
                {
                    Console.WriteLine(Menu.Options[0]);
                    Console.WriteLine(Menu.Options[1]);
                    Console.WriteLine(Menu.Options[2]);
                    Console.WriteLine(Menu.Options[3]);
                    Console.WriteLine(Menu.Options[4]);
                    Console.WriteLine(" ** " + Menu.Options[5] + "<--");
                    Console.WriteLine(Menu.Options[6]);

                }
                else if (Menu.Select == 6)
                {
                    Console.WriteLine(Menu.Options[0]);
                    Console.WriteLine(Menu.Options[1]);
                    Console.WriteLine(Menu.Options[2]);
                    Console.WriteLine(Menu.Options[3]);
                    Console.WriteLine(Menu.Options[4]);
                    Console.WriteLine(Menu.Options[5]);
                    Console.WriteLine("\n ** " + Menu.Options[6] + "<--");

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
                            Console.SetWindowSize(Globals.x, 28);
                            Ticket_Prices();
                            Console.SetWindowSize(Globals.x, 19);
                            break;
                        case 1:
                            Console.SetWindowSize(Globals.x, 23);
                            Ticket_Barn();
                            Console.SetWindowSize(Globals.x, 19);
                            break;
                        case 2:
                            Console.SetWindowSize(Globals.x, 23);
                            Ticket_Ungdomar();
                            Console.SetWindowSize(Globals.x, 19);
                            break;
                        case 3:
                            Console.SetWindowSize(Globals.x, 23);
                            Ticket_Vuxna();
                            Console.SetWindowSize(Globals.x, 19);
                            break;
                        case 4:
                            Console.SetWindowSize(Globals.x, 23);
                            Ticket_Pensionärer();
                            Console.SetWindowSize(Globals.x, 19);
                            break;
                        case 5:
                            Console.SetWindowSize(Globals.x, 23);
                            Ticket_Total();
                            Console.SetWindowSize(Globals.x, 19);
                            break;
                        case 6:
                        default:
                            P_Count.Meny();
                            break;

                    }
                }
            }   //  WHILE END
        }   //  METHOD END

        //*     //  Kör på VärmlandsTrafiks priser för EN zon. 
        //  Skulle kunna sätta en timer som kollar om passagerarna varit på bussen en specifik tid och utöka med en zon. 

        /// <summary>
        /// 
        ///     Satt precis och tänkte på hur man skulle kunna göra. Lägga till fler listor där det är random med hur många zoner det ska vara
        ///     och hur mycket pengar folk har, om de inte har tillräckligt så får de gå tillbaka etc. Just nu kommer jag bara köra en låtsas
        ///     plånbok, där folk alltid betalar för biljetten. 
        ///     
        /// </summary>


        public static void Ticket_Prices()
        {
            Console.WriteLine(" Bijettpriserna är : \n" +
                              "\n  Barn         = {0} kr" +
                              "\n  Ungdoms      = {1} kr" +
                              "\n  Vuxen        = {2} kr" +
                              "\n  Pensionär    = {3} kr", Globals.b1, Globals.b2, Globals.b3, Globals.b4);
            Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");

            Console.ReadKey();
            return;
        }
        //*/

        //*
        public static void Ticket_Total()
        {
            int t1, t2;
            t1 = ((Globals.Barn) + (Globals.Ungdom) + (Globals.Vuxen) + (Globals.Pensionär));
            t2 = ((Globals.Barn * Globals.b1) + (Globals.Ungdom * Globals.b2) + (Globals.Vuxen * Globals.b3) + (Globals.Pensionär * Globals.b4));
            Console.WriteLine(" Totalt sålda biljetter var : {0} st\n" +
                              " Denna Resa har tjänat in {1} kr. ", t1, t2);
            Console.ReadKey();
            return;
        }
        //*/

        //*
        public static void Ticket_Barn()
        {
            Console.WriteLine(" Totalt såldes {0} barn-biljetter. \n" +
                              " Totalt värde : {1} kr ", Globals.Barn, (Globals.Barn * Globals.b1));
            Console.ReadKey();
            return;
        }
        //*/

        //*
        public static void Ticket_Ungdomar()
        {
            Console.WriteLine(" Totalt såldes {0} ungdoms-biljetter. \n" +
                              " Totalt värde : {1} kr ", Globals.Ungdom, (Globals.Ungdom * Globals.b2));
            Console.ReadKey();
            return;
        }
        //*/

        //*
        public static void Ticket_Vuxna()
        {
            Console.WriteLine(" Totalt såldes {0} vuxen-biljetter. \n" +
                              " Totalt värde : {1} kr ", Globals.Vuxen, (Globals.Vuxen * Globals.b3));
            Console.ReadKey();
            return;
        }
        //*/

        //*
        public static void Ticket_Pensionärer()
        {

            Console.WriteLine(" Totalt såldes {0} pensionärs-biljetter. \n" +
                              " Totalt värde : {1} kr ", Globals.Pensionär, (Globals.Pensionär * Globals.b4));
            Console.ReadKey();
            return;
        }
        //*/

    }
    
}
