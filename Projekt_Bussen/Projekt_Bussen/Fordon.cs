using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Projekt_Bussen
{
    /*
        *      EJ SKAPADE FUNKTIONER INOM KLASS PASSAGERARE
        *      
        *      Fordon Hastighet
        *      Fordon Hastighet Öka
        *      Fordon Hastighet Sänk
        *      Fordon Hastighet Start
        *      Fordon Hastighet Stop
        *      
        *      Timer https://stackoverflow.com/questions/64531146/running-a-function-at-random-intervals-c-sharp
        *      för när passagerare helt random vill kliva utav.
        * 
        */

    /*  Börja längst ner i dokumentet och klassen "Program".
        Den klassen är liten och har i uppgiften att köra igång programmet genom att skapa en buss och sedan anropa metoden Run().
        I beskrivningen av projektet påpekas vikten av att koda stegvis. I detta fall kan det handla om att ni bara ska skriva
        ut en text i Run()-metoden.
         */


    class Fordon
    {
        // I en buss är det 36-60 platser. Uppgiften säger dock 25, så förhåller mig till det.

        private int speed;                        //  Satt till max 110 km/h
        public static int sittplatser;            //  Satt till 25 platser

        internal void Intro()
        {
            Console.SetWindowSize(90, 33);
            Console.Clear();
            Ambiance.PlaySound("intro_bussen_startar-0.wav");
            
            //  ASCII - | https://www.coolgenerator.com/ascii-text-generator
            Console.WriteLine("\n\n" +
                              "\n                .S_SSSs     .S       S.     sSSs    sSSs    sSSs   .S_sSSs               \r" +
                              "\n               .SS~SSSSS   .SS       SS.   d%%SP   d%%SP   d%%SP  .SS~YS%%b              \r" +
                              "\n               S%S   SSSS  S%S       S%S  d%S'    d%S'    d%S'    S%S   `S%b             \r" +
                              "\n               S%S    S%S  S%S       S%S  S%|     S%|     S%S     S%S    S%S             \r" +
                              "\n               S%S SSSS%P  S&S       S&S  S&S     S&S     S&S     S%S    S&S             \r" +
                              "\n               S&S  SSSY   S&S       S&S  Y&Ss    Y&Ss    S&S_Ss  S&S    S&S             \r" +
                              "\n               S&S    S&S  S&S       S&S  `S&&S   `S&&S   S&S~SP  S&S    S&S             \r" +
                              "\n               S&S    S&S  S&S       S&S    `S*S    `S*S  S&S     S&S    S&S             \r" +
                              "\n               S*S    S&S  S*b       d*S     l*S     l*S  S*b     S*S    S*S             \r" +
                              "\n               S*S    S*S  S*S.     .S*S    .S*P    .S*P  S*S.    S*S    S*S             \r" +
                              "\n               S*S SSSSP    SSSbs_sdSSS   sSS*S   sSS*S    SSSbs  S*S    S*S             \r" +
                              "\n               S*S  SSY      YSSP~YSSY    YSS'    YSS'      YSSP  S*S    SSS             \r" +
                              "\n               SP                                                 SP                     \r" +
                              "\n               Y                                                  Y                      \r" +
                              "\n                                                                                         \r" +
                              "\n     sSSs  sdSS_SSSSSSbs   .S_SSSs     .S_sSSs    sdSS_SSSSSSbs   .S_SSSs     .S_sSSs    \r" +
                              "\n    d%%SP  YSSS~S%SSSSSP  .SS~SSSSS   .SS~YS%%b   YSSS~S%SSSSSP  .SS~SSSSS   .SS~YS%%b   \r" +
                              "\n   d%S'         S%S       S%S   SSSS  S%S   `S%b       S%S       S%S   SSSS  S%S   `S%b  \r" +
                              "\n   S%|          S%S       S%S    S%S  S%S    S%S       S%S       S%S    S%S  S%S    S%S  \r" +
                              "\n   S&S          S&S       S%S SSSS%S  S%S    d*S       S&S       S%S SSSS%S  S%S    d*S  \r" +
                              "\n   Y&Ss         S&S       S&S  SSS%S  S&S   .S*S       S&S       S&S  SSS%S  S&S   .S*S  \r" +
                              "\n   `S&&S        S&S       S&S    S&S  S&S_sdSSS        S&S       S&S    S&S  S&S_sdSSS   \r" +
                              "\n     `S*S       S&S       S&S    S&S  S&S~YSY%b        S&S       S&S    S&S  S&S~YSY%b   \r" +
                              "\n      l*S       S*S       S*S    S&S  S*S   `S%b       S*S       S*S    S&S  S*S   `S%b  \r" +
                              "\n     .S*P       S*S       S*S    S*S  S*S    S%S       S*S       S*S    S*S  S*S    S%S  \r" +
                              "\n   sSS*S        S*S       S*S    S*S  S*S    S&S       S*S       S*S    S*S  S*S    S&S  \r" +
                              "\n   YSS'         S*S       SSS    S*S  S*S    SSS       S*S       SSS    S*S  S*S    SSS  \r" +
                              "\n                SP               SP   SP               SP               SP   SP          \r" +
                              "\n                Y                Y    Y                Y                Y    Y           ");

            
            Ambiance.PlaySound("intro_bussen_startar-2.wav");
            
        }
        
        public void Run()
        {
            Console.SetWindowSize(50, 15);
            Console.Clear();
            Console.WriteLine("\n\t Välkommen till Bussen!" +
                              "\n" +
                              "\n Projekt i C# Programmering 1 på Distans." +
                              "\n Det ska hantera fundamentala funktioner." +
                              "\n" +
                              "\n Det är inte säkert att allt fungerar," +
                              "\n så som andra haft förhoppnigar om programmet," +
                              "\n men tanken är att med tid möjligen," +
                              "\n bygga på det och eller även korta ned koden.");
            Console.WriteLine("\n" +
                              "\n| ---" +
                              "\n|  Tryck valfri på knapp ...");
            
            //Här ska menyn ligga för att göra saker
            //Jag rekommenderar switch och case här
            //I filmen nummer 1 för slutprojektet så skapar jag en meny på detta sätt.
            //Dessutom visar jag hur man anropar metoderna nedan via menyn
            //Börja nu med att köra koden för att se att det fungerar innan ni sätter igång med menyn.
            //Bygg sedan steg-för-steg och testkör koden.

            Console.ReadKey(true);

            Intro();
            Meny();

            
        }
        
        public void Meny()
        {
            HuvudMeny.Meny();
        }

        public void HemFärd()
        {
            Console.SetWindowSize(83, 11);
            //  Denna funktion tömmer ännu inte vektorerna/listorna, som kommer skapas...
            //  Utan ändrar bara mellanskillnaden på de lediga platserna, för att gå vidare och avsluta programmet.

            Console.Clear();

            int difference = sittplatser - Globals.ledigaStolar;
            
            if (difference != 0)
            {
                Globals.Hastighet = 20;
                
                Console.WriteLine("\n Rutten har gått mot sitt slut och bussen saktar ned ({0} km/h)" +
                                  "\n Chauffören ropar 'Ni måste gå av!' ", Globals.Hastighet);
                Ambiance.PlaySound("saktar_ner_10--.wav");
                
                Globals.Hastighet = 5;
                Console.WriteLine("\n Bussen saktar ned ytterligare ({0} km/h) vid närmsta busshållplats.", Globals.Hastighet);
                Ambiance.PlaySound("sakta_ner_10-0.wav");
                
                Globals.Hastighet = 0;
                Console.WriteLine("\n och stoppar helt ({0} km/h).", Globals.Hastighet);
                Ambiance.PlaySound("på_av.wav");
                Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");
                Console.ReadKey(true);

                if (difference == 1)        //  EN RESENÄR
                {
                    Console.Clear();
                    Console.WriteLine("\n Bussen har {0} sittplatser och {1} upptagen plats" +
                                      "\n Lyhörd är resenären som precis vaknat upp." +
                                      "\n Man kan höra en suck, samt en ursäkt och personen kliver av.", sittplatser, difference);
                    Ambiance.PlaySound("på_av.wav");
                    Ambiance.PlaySound("hemfärd_lämnat_av_folket.wav");
                    Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");
                    Console.ReadKey(true);

                    Console.Clear();
                    Globals.ledigaStolar += difference;
                    Console.WriteLine("\n Bussen har {0} sittplatser och {1} lediga platser", sittplatser, Globals.ledigaStolar);
                    
                    Globals.Hastighet = 90;
                    Console.WriteLine("\n Vänder hemmåt och kör till busscentralen." +
                                      "\n Hastigheten är: {0} km/h", Globals.Hastighet, Sittplatser, Globals.antalStolar);
                    Ambiance.PlaySound("hemfärd_avslut.wav");
                    Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");
                    Console.ReadKey (true);

                    Console.Clear();
                    Console.WriteLine("\n Framme och dags att gå för dagen!");
                    Ambiance.PlaySound("signalhorn.wav");
                    Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");
                    Console.ReadKey(true);

                } else if (difference >= 2)     //  FLERA RESENÄRER
                {
                    Console.Clear();
                    Console.WriteLine("\n Bussen har {0} sittplatser och {1} upptagna platser" +
                                      "\n Kaoset blir oerhört stort när resenärerna ser sig om." +
                                      "\n Man kan höra suckar och stön från de som är kvar." +
                                      "\n Någon säger 'Adjö då' och personerna kliver av.", sittplatser, difference);
                    Ambiance.PlaySound("på_av.wav");
                    Ambiance.PlaySound("hemfärd_lämnat_av_folket.wav");
                    Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");
                    Console.ReadKey(true);

                    Console.Clear();
                    Globals.ledigaStolar += difference;
                    Console.WriteLine("\n Bussen har {0} sittplatser och {1} lediga platser", sittplatser, Globals.ledigaStolar);

                    Globals.Hastighet = 90;
                    Console.WriteLine("\n Vänder hemmåt och kör till busscentralen." +
                                      "\n Hastigheten är: {0} km/h", Globals.Hastighet, Sittplatser, Globals.antalStolar);
                    Ambiance.PlaySound("hemfärd_avslut.wav");
                    Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");
                    Console.ReadKey(true);
                    

                    Console.Clear();
                    Console.WriteLine("\n Framme och dags att gå för dagen!");
                    Ambiance.PlaySound("signalhorn.wav");
                    Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");
                    Console.ReadKey(true);
                    
                }
            }
            else if (difference == 0)       //  INGA RESENÄRER
            {
                Console.Clear();
                Globals.Hastighet = 90;
                Console.WriteLine("\n Det är {1} sittplatser på bussen" +
                                  "\n och det är {2} lediga platser \n" +
                                  "\n Vänder hemmåt och kör till busscentralen." +
                                  "\n Hastigheten är: {0} km/h", Globals.Hastighet, Sittplatser, Globals.antalStolar);
                Ambiance.PlaySound("hemfärd_avslut.wav");
                Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");
                Console.ReadKey(true);
                

                Console.Clear();
                Console.WriteLine("\n Framme och dags att gå för dagen!");
                Ambiance.PlaySound("signalhorn2.wav");
                Ambiance.PlaySound("signalhorn2.wav");
                Console.WriteLine("\n| ---" +
                                  "\n|  Tryck på valfri knapp ...");
                Console.ReadKey(true);
                

            }           
            

        }

        public void Outro()
        {
            Console.SetWindowSize(90,20);

            Console.Clear();
            Console.WriteLine("\n\n Tack för att du testat ... ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n\n" +
                              "\n                .S_SSSs     .S       S.     sSSs    sSSs    sSSs   .S_sSSs               \r" +
                              "\n               .SS~SSSSS   .SS       SS.   d%%SP   d%%SP   d%%SP  .SS~YS%%b              \r" +
                              "\n               S%S   SSSS  S%S       S%S  d%S'    d%S'    d%S'    S%S   `S%b             \r" +
                              "\n               S%S    S%S  S%S       S%S  S%|     S%|     S%S     S%S    S%S             \r" +
                              "\n               S%S SSSS%P  S&S       S&S  S&S     S&S     S&S     S%S    S&S             \r" +
                              "\n               S&S  SSSY   S&S       S&S  Y&Ss    Y&Ss    S&S_Ss  S&S    S&S             \r" +
                              "\n               S&S    S&S  S&S       S&S  `S&&S   `S&&S   S&S~SP  S&S    S&S             \r" +
                              "\n               S&S    S&S  S&S       S&S    `S*S    `S*S  S&S     S&S    S&S             \r" +
                              "\n               S*S    S&S  S*b       d*S     l*S     l*S  S*b     S*S    S*S             \r" +
                              "\n               S*S    S*S  S*S.     .S*S    .S*P    .S*P  S*S.    S*S    S*S             \r" +
                              "\n               S*S SSSSP    SSSbs_sdSSS   sSS*S   sSS*S    SSSbs  S*S    S*S             \r" +
                              "\n               S*S  SSY      YSSP~YSSY    YSS'    YSS'      YSSP  S*S    SSS             \r" +
                              "\n               SP                                                 SP                     \r" +
                              "\n               Y                                                  Y                      \r" +
                              "\n                                                                                         \r");

        }

        public Fordon(int speed, int sittplatser)
        {
            Speed = speed;      
            Sittplatser = sittplatser;
            
        }
     
        //*
        internal int Speed
        {
            get { return speed; }       //  Readable 
            set                         //  Writeable
            {
                //*
                if (value > 110)
                {
                    speed = 110;
                }
                else
                {
                    speed = value;
                }
                //*/
                //  speed = value;

            }
        } //*///
        

        internal int Sittplatser
        {
            get { return sittplatser; }
            set
            {
                if (value <= 0)
                {
                    
                
                } else
                {
                    sittplatser = value;
                    
                }
                
                // sittplatser = value;
            }
        }
    }
}
