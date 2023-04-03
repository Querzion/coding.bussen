using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Bussen
{
    internal class P
    {
        public static void Meny()
        {
            Console.SetWindowSize(Globals.x, 17);

            //  MENU
            Menu.Options = new string[] { " Addera EN Passagegare : \t\t\t", 
                                          " [MENY] Subtrahera Passagerare : \t\t", 
                                          " [MENY] Räkna : \t\t\t\t",
                                          " Passagerar Manifest : \t\t\t",
                                          " Tillbaka till föregående meny : \t\t" };

            Menu.Select = 0;
            Menu.PlaceHolder = "\n    Passagerar Menyn : " +
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
                            Console.SetWindowSize(Globals.x, 21);
                            Add_Passenger();
                            Console.ReadLine();
                            Console.SetWindowSize(Globals.x, 17);
                            break;
                        case 1:
                            P_Remove.Meny();
                            break;
                        case 2:
                            P_Count.Meny();
                            break;
                        case 3:
                            Print_Manifest();
                            Console.ReadLine();
                            Console.SetWindowSize(Globals.x, 17);
                            break;
                        case 4:
                            HuvudMeny.Meny();
                            break;

                    }
                }
            }   //  WHILE END
        }   //  METHOD END



        //*     ADD PASSENGER TO LISTS
        public static void Add_Passenger()
        {

            RandomID_Gen.Generate_Random_Passenger();

            if (Globals.ledigaStolar != 0)
            {
                Globals.rAge.Add(Globals.randAge);
                Globals.rGender.Add(Globals.randGender);
                Globals.rDesignation.Add(Globals.designation);

                Console.Write(" {0}). Ny Passagerare: > {2}, {3} år, {1} \n" +
                              "\n| ---" +
                              "\n|  Tryck på valfri knapp ...", Globals.resenärAntal, Globals.rDesignation[Globals.resenärAntal], Globals.rGender[Globals.resenärAntal], Globals.rAge[Globals.resenärAntal]);
                Globals.resenärAntal++;
                Globals.ledigaStolar--;
            }
            //*
            else if (Globals.resenärAntal == Globals.antalStolar)
            {
                Console.WriteLine("   Det finns inga lediga sittplatser.");
                Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");

            }   //*///

        }   //*///   SAVE PASSENGER ENDS HERE 



        //*          PRINT PASSENGERS STARTS
        public static void Print_Manifest()
        {
            Console.SetWindowSize(56, 44);

            Console.WriteLine("\n|   Här är passagerar manifestet:" +
                              "\n| ---");
            if (Globals.resenärAntal != 0)
            {
                var j = 1;
                
                for (var i = 0; i < Globals.resenärAntal; i++)
                {
                    Console.Write("\n| - {0}).  {1}, {2}, {3} år.", j, Globals.rDesignation[i], Globals.rGender[i], Globals.rAge[i]);
                    j++;
                }

            }
            else
            {
                Console.WriteLine("\n\n\t {0} PERSONER I MANIFESTET ", Globals.rAge.Count);
            }
            Console.WriteLine("\n" +
                              "\n| ---" +
                              "\n|  Tryck på valfri knapp ...");

        }   //*///    PRINT PASSENGERS ENDS HERE
    }
}
