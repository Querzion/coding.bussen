using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Bussen
{
    internal class Globals
    {
        //  Variabler
        public static Random Random = new Random();


        /*
        public static string[,,] passagerInfo;
        //*///

        //  FORDON VALUES
        internal static int resenärAntal;
        internal static int ledigaStolar;
        internal static int antalStolar;

        public static int Hastighet;


        //  ADD PASSENGER VALUES

        //  Tydligen så kunde jag skapat klasser för varje grupp istället,
        //  och satt get|set parametrar på en lista, därmed kortat ned detta ytterligare.
        //  Inget jag gör nu då jag inte har tid, men skeletet för det finns längre ned.
        //  Om det är så det är tänkt att fungera.

        public static int randAge;                                              //  Random age value
        public static List<int> rAge = new List<int>();                         //  Random Age List

        public static string randGender;                                        //  Random gender value
        public static List<string> rGender = new List<string>();                //  Random Gender List

        public static string designation;                                       //  Random designation value
        public static List<string> rDesignation = new List<string>();           //  Random Designation list

        public static int Barn;                                                 //  Child amount
        public static List<int> rAgeBarn = new List<int>();                     //  Child Random Age List
        public static List<string> rGenBarn = new List<string>();               //  Child Random Gender List

        public static int Ungdom;                                               //  Teen amount    
        public static List<int> rAgeUngdom = new List<int>();                   //  Teen Random Age List
        public static List<string> rGenUngdom = new List<string>();             //  Teen Random Gender List

        public static int Vuxen;                                                //  Adult amount
        public static List<int> rAgeVuxen = new List<int>();                    //  Adult Random Age List
        public static List<string> rGenVuxen = new List<string>();              //  Adult Random Gender List

        public static int Pensionär;                                            //  Senior amount
        public static List<int> rAgePensionär = new List<int>();                //  Senior Random Age List
        public static List<string> rGenPensionär = new List<string>();          //  Senior Random Gender List


            
        //  BILJETTPRISER
        public static int b1 = 27,      /*  Barn        */
                          b2 = 40,      /*  Ungodom     */
                          b3 = 45,      /*  Vuxen       */
                          b4 = 40;      /*  Pensionär   */

        //  WINDOW SIZE SETTINGS
        public const int x = 56, y = 24;   


        public static int cTotal;           //  Count Variable

        //  LOOP VALUES
        public static bool Continue;

        //  REMOVE PASSANGER VALUES
        public static int RemoveOne;        //  = resenärAntal - resenärAntal + 1
        public static int RemoveSwitch;     //  = Remove/-All/-One/-Choice

        internal static void SetValue()
        {
            //*  ANTAL - DESSA RÄKNAS IN VID GENERERING OCH FÖRSVINNER VID OMSTART
            Barn = 0;          
            Ungdom = 0;
            Vuxen = 0;
            Pensionär = 0;
            //*///

            
            resenärAntal = 0;
            ledigaStolar = 0;

            Hastighet = 0;                                              

            Continue = true;
                        
            RemoveOne = resenärAntal - resenärAntal + 1;

            /*
            passagerInfo = new string[,,] { };
            antal_passagerare = 0;
            max_passagerare = Fordon.sittplatser;
            //*///

            antalStolar = Fordon.sittplatser;
            ledigaStolar = antalStolar - resenärAntal;
        }

 
        //  MENU: EXIT METHOD
        public static void Exit()
        {
            Console.Clear();

            Console.WriteLine("\n|-----------------------------------------------------|\n" +
                              "\n\t Avslutar Bussresan.\n" +
                              "\n|-----------------------------------------------------|" +
                              "\n  Tryck valfri knapp för att stänga ned ...");
            Console.ReadKey();
            Environment.Exit(1);
        }

    }

    /*      DENNA DEL ANVÄNDS INTE. JAG HAR INTE LÄRT MIG ANVÄNDA LISTOR ORDENTLIGT;       
     *      //  SÅ JAG HAR SKAPAT DEM FEL OVAN (TROR JAG) DATUM:> 2023|02APRIL SÅ HAR INTE TID ATT GÖRA OM HÄR.
    internal class Global_Lists
    {
        //  https://stackoverflow.com/questions/18863187/how-can-i-loop-through-a-listt-and-grab-each-item

        public static List<Barn> Age = new List<Barn>()
        {
            
        };
    }

    class Barn
    {
        public int Age { get; set; }
        public string Gender { get; set; }
    }
    class Ungdom
    {
        public int Age { get; set; }
        public string Designation { get; set; }
    }
    class Vuxen
    {
        public int Age { get; set; }
        public string Designation { get; set; }
    }
    class Pensionär
    {
        public int Age { get; set; }
        public string Designation { get; set; }
    }
    //*///


    internal class Menu
    {
        public static string[] Options;
        public static int Select;
        public static string PlaceHolder;
        public static bool Continue;

    }

    //*
    internal class Borked
    {
        //  Informativ text där saker inte fungerar.
        public static void Uppmaning()
        {
            Console.WriteLine("\n Funktionen är ännu inte skapad!" +
                              "\n Ber om ursäkt för den missledande faktorn.");
        }

        public static void Varning() {

            Console.Clear();
            Console.WriteLine("\n\n\n   VARNING! VARNING! VARNING! VARNING! \n\n" + 
                              "\n      DENNA FUNKTION ÄR LITE DISCO!" +
                              "\n      DVS. YOU BREAK IT YOU BUY IT! " +
                              "\n     DENNA FUNKTION BRYTER PROGRAMMET " +
                              "\n                PÅ RANOOM! " +
                              "\n\n\n   VARNING! VARNING! VARNING! VARNING!\n" +
                              "\n|-----------------------------------------------------|\n\n");

        }
    }
    //*/
}
