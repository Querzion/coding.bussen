using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Bussen
{
    internal class P_Remove
    {
        public static void Meny()
        {
            Console.SetWindowSize(Globals.x, 22);

            //  MENU
            Menu.Options = new string[] { " Ta bort EN resenär ur Bussen \t\t",
                                          " Rensa EN ur heltids data - Barn \t",
                                          " Rensa EN ur heltids data - Ungdom \t",
                                          " Rensa EN ur heltids data - Vuxen \t",
                                          " Rensa EN ur heltids data - Pensionär \t",
                                          " Antal resenärer kvar i Bussen : \t\t",
                                          " Tillbaka till föregående meny : \t\t" };

            Menu.Select = 0;
            Menu.PlaceHolder = "\n    [INSTANSER] Kasta av stökiga resenärer : " +
                               "\n ** Separat data rensning PÅVERKAR statistik :" +
                               "\n    Ta bort EN påverkar annan statistik :" +
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
                            Console.SetWindowSize(Globals.x, 25);
                            Globals.RemoveSwitch = Globals.RemoveOne;
                            Remove_Passenger();
                            Console.ReadLine();
                            Console.SetWindowSize(Globals.x, 20);
                            break;
                        case 1:
                            Console.SetWindowSize(Globals.x, 26);
                            //Borked.Varning();
                            R_Child();
                            Console.ReadLine();
                            Console.SetWindowSize(Globals.x, 20);
                            break;
                        case 2:
                            Console.SetWindowSize(Globals.x, 26);
                            //Borked.Varning();
                            R_Teen();
                            Console.ReadLine();
                            Console.SetWindowSize(Globals.x, 20);
                            break;
                        case 3:
                            Console.SetWindowSize(Globals.x, 26);
                            //Borked.Varning();
                            R_Adult();
                            Console.ReadLine();
                            Console.SetWindowSize(Globals.x, 20);
                            break;
                        case 4:
                            Console.SetWindowSize(Globals.x, 26);
                            //Borked.Varning();
                            R_Senior();
                            Console.ReadLine();
                            Console.SetWindowSize(Globals.x, 20);
                            break;
                        case 5:
                            Console.SetWindowSize(Globals.x, 24);
                            Console.WriteLine(" Det är {0} passagerare på bussen.", Globals.resenärAntal);
                            Console.WriteLine("\n| ---" +
                                              "\n|  Tryck på valfri knapp ...");
                            Console.ReadLine();
                            Console.SetWindowSize(Globals.x, 20);
                            break;
                        case 6:
                        default:
                            P.Meny();
                            break;
                    }
                }
            }   //  WHILE END
        }   //  METHOD END



        //*    REMOVE PASSENGER FROM LISTS https://stackoverflow.com/questions/23245569/how-to-remove-the-last-element-added-into-the-list#23245652
        public static void Remove_Passenger()
        {
            if (Globals.resenärAntal != 0)
            {
                for (var i = Globals.RemoveSwitch; i > -1; i--)
                {
                    Globals.rAge.RemoveAt(Globals.rAge.Count - 1);
                    Globals.rGender.RemoveAt(Globals.rGender.Count - 1);
                    Globals.rDesignation.RemoveAt(Globals.rDesignation.Count - 1);
                    Globals.resenärAntal--;
                    Globals.ledigaStolar++;

                    Console.WriteLine(" {0} Passagerare kvar.", Globals.rAge.Count);
                    Console.WriteLine("\n| ---" +
                                      "\n|  Tryck på valfri knapp ...");

                    /*     
                    Console.WriteLine(" {0} resenärAntal", Globals.resenärAntal);
                    //*///  Den här variabeln är endast på plats för att testa så att rAge.Count är densamma.
                }
            } else {

                Console.WriteLine(" Det finns inga resenärer i manifestet.");
                Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");
            }

        }   //*///    REMOVE PASSENGER ENDS HERE
            


        //*    REMOVE CHILD DATA FROM LISTS 
        public static void R_Child()
        {
            if (Globals.rAgeBarn.Count != 0)
            {
                for (var i = Globals.RemoveSwitch; i > -1; i--)
                {
                    Globals.rAgeBarn.RemoveAt(Globals.rAgeBarn.Count - 1);
                    Globals.rGenBarn.RemoveAt(Globals.rGenBarn.Count - 1);

                    Console.WriteLine(" Separat Lista > {0} Barn Data kvar.", Globals.rAgeBarn.Count);
                    Console.WriteLine("\n| ---" +
                                      "\n|  Tryck på valfri knapp ...");
                }
            }
            else
            {
                Console.WriteLine(" All HELTIDS DATA - BARN - " +
                                  "\n Ålder och köns statistik är nu borttagen.");
                Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");
            }

        }   //*///    REMOVE CHILD DATA ENDS HERE



        //*    REMOVE TEEN DATA FROM LISTS 
        public static void R_Teen()
        {
            if (Globals.rAgeUngdom.Count != 0)
            {
                for (var i = Globals.RemoveSwitch; i > -1; i--)
                {
                    Globals.rAgeUngdom.RemoveAt(Globals.rAgeUngdom.Count - 1);
                    Globals.rGenUngdom.RemoveAt(Globals.rGenUngdom.Count - 1);

                    Console.WriteLine(" Separat Lista > {0} Ungdoms Data kvar.", Globals.rAgeUngdom.Count);
                    Console.WriteLine("\n| ---" +
                                      "\n|  Tryck på valfri knapp ...");
                }
            }
            else
            {
                Console.WriteLine(" All HELTIDS DATA - UNGDOM - " +
                                  "\n Ålder och köns statistik är nu borttagen.");
                Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");
            }

        }   //*///    REMOVE TEEN DATA ENDS HERE



        //*    REMOVE ADULT DATA FROM LISTS 
        public static void R_Adult()
        {
            if (Globals.rAgeVuxen.Count != 0)
            {
                for (var i = Globals.RemoveSwitch; i > -1; i--)
                {
                    if (Globals.rAgeVuxen.Count != 0)
                    {
                        Globals.rAgeVuxen.RemoveAt(Globals.rAgeVuxen.Count - 1);
                        Globals.rGenVuxen.RemoveAt(Globals.rGenVuxen.Count - 1);

                        Console.WriteLine(" Separat Lista > {0} Vuxen Data kvar.", Globals.rAgeVuxen.Count);
                        Console.WriteLine("\n| ---" +
                                          "\n|  Tryck på valfri knapp ...");
                    } else { break; }
                }
            }
            else
            {
                Console.WriteLine(" All HELTIDS DATA - VUXEN - " +
                                  "\n Ålder och köns statistik är nu borttagen.");
                Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");
            }

        }   //*///    REMOVE ADULT DATA ENDS HERE        




        //*    REMOVE SENIOR DATA FROM LISTS 
        public static void R_Senior()
        {
            if (Globals.rAgePensionär.Count != 0)
            {
                for (var i = Globals.RemoveSwitch; i > -1; i--)
                {
                    Globals.rAgePensionär.RemoveAt(Globals.rAgePensionär.Count - 1);
                    Globals.rGenPensionär.RemoveAt(Globals.rGenPensionär.Count - 1);

                    Console.WriteLine(" Separat Lista > {0} Pensionärs Data kvar.", Globals.rAgePensionär.Count);
                    Console.WriteLine("\n| ---" +
                                      "\n|  Tryck på valfri knapp ...");
                }
            }
            else
            {
                Console.WriteLine(" All HELTIDS DATA - PENSIONÄR - " +
                                  "\n Ålder och köns statistik är nu borttagen.");
                Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");
            }

        }   //*///    REMOVE SENIOR DATA ENDS HERE        
    }
}
