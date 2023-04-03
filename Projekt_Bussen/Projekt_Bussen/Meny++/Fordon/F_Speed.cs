using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Bussen
{
    internal class F_Speed
    {
        public static void Meny()
        {
            Console.SetWindowSize(Globals.x, 17);

            //  MENU
            Menu.Options = new string[] { " Se Hastighet : \t\t\t\t",
                                          " Öka Hastighet ( + 5 km/h ) : \t\t",
                                          " Sänk Hastighet ( - 5 km/h ) : \t\t",
                                          " Tillbaka till föregående meny : \t\t" };

            Menu.Select = 0;
            Menu.PlaceHolder = "\n    [INSTANSER] Hastighets Inställningar : " +
                               "\n    Välj Parametrar : \n";

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
                            Console.SetWindowSize(Globals.x, 17);
                            VisaHastighet();
                            break;
                        case 1:
                            //*
                            ÖkaHastighet();    
                            //*/
                            break;
                        case 2:
                            //*  
                            SänkHastighet();    
                            //*/
                            break;
                        case 3:
                            HuvudMeny.Meny();
                            break;

                    }
                }
            }   //  WHILE END
        }   //  METHOD END

        //*
        public static void VisaHastighet()
        {
            Console.WriteLine(" Nuvarande hastighet är ... {0} km/h ", Globals.Hastighet);
            Console.ReadKey();
            return;
        }
        //*/

        //  https://stackoverflow.com/questions/56197825/is-there-any-way-in-c-sharp-that-i-can-limit-the-range-of-an-int-variable
        /*     ACCELERATE
        private static int accelerate;
        public static int Accelerate
        {
            get => accelerate;
            set
            {
                if (value < 0 == value > 130)
                {
                    throw new ArgumentException(" Då är top hastigheten uppnåd!");
                    
                } else
                {
                    accelerate = value +5;
                    Console.WriteLine(" Hastigheten är {0} km/h", Globals.Hastighet);
                }
            }
        }

        public static void ÖkaHastigheten()
        {
            Globals.Hastighet = accelerate;
            Console.WriteLine(" Hastigheten är {0} km/h", Globals.Hastighet);
        }
        //*///  ACCELERATE ENDS HERE

        //_____________________________________________

        /*     DECELERATE
        private static int decelerate;
        public static int Decelerate
        {
            get => decelerate;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(" Här var det fullstopp.");
                }
                else
                {
                    decelerate = value +5;
                    Console.WriteLine(" Hastigheten är {0} km/h", Globals.Hastighet);
                }
            }
        }

        public static void SänkHastigheten()
        {
            Globals.Hastighet = decelerate;
            Console.WriteLine(" Hastigheten är {0} km/h", Globals.Hastighet);
        }
        //*///   DECELERATE ENDS HERE

        //_____________________________________________

        //*     ACCELERATE
        public static void ÖkaHastighet()
        {
            if (Globals.Hastighet > 5 && Globals.Hastighet < 110)
            {
                Globals.Hastighet += 5;
                Console.WriteLine(" Då kör vi i {0} km/h", Globals.Hastighet);
                Console.ReadKey();

            } else if (Globals.Hastighet >= 110)
            {
                Globals.Hastighet = 110;
                Console.WriteLine(" Bussen går inte fortare än {0} km/h", Globals.Hastighet);
                Console.ReadKey();
                
            } else if (Globals.Hastighet < 5)
            {
                Console.WriteLine(" Dörrarna stängs.");
                Ambiance.PlaySound("på_av.wav");
                Globals.Hastighet += 5;
                Console.WriteLine(" Accelerationen hörs i hela bussen.");
                Ambiance.PlaySound("accelerera_10++.wav");
                Console.ReadKey();
            }

            return;
        }
        //*///  ACCELERATE ENDS HERE

        //_____________________________________________

        //*     DECELERATE
        public static void SänkHastighet()
        {
            if (Globals.Hastighet > 10 && Globals.Hastighet < 110)
            {
                Globals.Hastighet -= 5;
                Console.WriteLine(" Då kör vi i {0} km/h", Globals.Hastighet);
                Console.ReadKey();
                

            } else if (Globals.Hastighet <= 10)
            {
                Globals.Hastighet -= 5;
                Console.WriteLine(" Saktar ned inför hållplatsen {0} km/h", Globals.Hastighet);
                Ambiance.PlaySound("sakta_ner_10-0.wav");
                Globals.Hastighet = 0;
                Console.WriteLine(" Fordonet står stilla och dörrarna öppnas.");
                Ambiance.PlaySound("på_av.wav");
                Console.ReadKey();

            } else if (Globals.Hastighet == 110)
            {
                Globals.Hastighet -= 5;
                Console.WriteLine(" Då kör vi i {0} km/h", Globals.Hastighet);
                Console.ReadKey();
            }

            return;
        }
        //*///  DECELERATE ENDS HERE



    }
}