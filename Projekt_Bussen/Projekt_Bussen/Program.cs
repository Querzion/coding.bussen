using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Projekt_Bussen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //* SETTINGS
            Globals.Hastighet = 50;
            Globals.antalStolar = 36;
            Globals.ledigaStolar = Globals.antalStolar;
            //*/

            //Följande rad skapar en buss:
            var Buss = new Fordon(Globals.Hastighet, Globals.antalStolar);   //  km/h, sittplatser.  (50, 25)  

            /*     Kontroll för hastigheten.
            Console.WriteLine("Hastighet före : (Globals) > " + miniBuss.Speed);
            miniBuss.Speed = Globals.Hastighet = 80;
            Console.WriteLine("Hastighet efter : (Fordon) > " + miniBuss.Speed);
            Console.ReadKey();
            //*///

            //*     Kommentera och Avkommentera för att testa enskilda aspekter i koden.
            //*///  Jag kommenterar två extra // bakom för att kunna skriva och inte
            //      stöta på problem om något blir 'avkommenterat' där jag skrivit.

            /*
            VariabelKontroll();
            Console.ReadKey(true);
            //*///  Outputen från denna kan flyttas!

            /*     TEST ADD PASSANGER - ADDS 1 | 36 | 37 People
            Console.Clear();
            Add_P_Tester();     
            Console.ReadKey();
            //*///

            /*      TEST REMOVE PASSANGER - BROKEN
            Remove_P_Tester();
            Console.ReadKey();
            //*///


            //*  STARTAR RUN    
            Buss.Run();
            //*///  FORTSÄTTER NEDAN EFTER RUN KÖRTS 

            /*
            Console.Clear();
            Buss.Meny();
            //*/

            //*     Här är slutstycket, när man gått ur menyn andra gången.    
            Console.Clear();
            Buss.HemFärd();
            Console.ReadKey();
            //*/
            Console.ReadKey();
            Buss.Outro();
            //*
            Console.Write("\n\t\t Tryck valfri knapp för att avsluta ...  ");
            Console.ReadKey(true);
            //*/

        }


        //*     VARIABLE CHECK
        public static void VariabelKontroll()
        {
            
            Console.Clear();
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine(" Barn : " + Globals.Barn);
            Console.WriteLine(" Ungdom : " + Globals.Ungdom);
            Console.WriteLine(" Vuxen : " + Globals.Vuxen);
            Console.WriteLine(" Pensionär : " + Globals.Pensionär);
            Console.WriteLine("-------------------------------");
            Console.WriteLine(" Age : " + Globals.randAge);
            Console.WriteLine("-------------------------------");
            Console.WriteLine(" Sittplatser : (Fordon) > " + Fordon.sittplatser);
            Console.WriteLine(" Sittplatser : (Globals) > " + Globals.antalStolar);
            Console.WriteLine(" Lediga Platser : > " + Globals.ledigaStolar);
            Console.WriteLine("-------------------------------");
            Console.WriteLine(" Antal Resenärer : > " + Globals.resenärAntal);

            Console.ReadKey(true);

        }   //*///  VARIABLE CHECK ENDS HERE
        public static void Add_P_Tester()
        {
            /*
            Console.Clear();
            P.Add_Passenger();  //  0
            Console.Clear();
            P.Add_Passenger();  //  1
            Console.Clear();
            P.Add_Passenger();  //  2
            Console.Clear();
            P.Add_Passenger();  //  3
            Console.Clear();
            P.Add_Passenger();  //  4
            Console.Clear();
            P.Add_Passenger();  //  5
            Console.Clear();
            P.Add_Passenger();  //  6
            Console.Clear();
            P.Add_Passenger();  //  7
            Console.Clear();
            P.Add_Passenger();  //  8
            Console.Clear();
            P.Add_Passenger();  //  9
            Console.Clear();
            P.Add_Passenger();  //  10
            Console.Clear();
            P.Add_Passenger();  //  11
            Console.Clear();
            P.Add_Passenger();  //  12
            Console.Clear();
            P.Add_Passenger();  //  13
            Console.Clear();
            P.Add_Passenger();  //  14
            Console.Clear();
            P.Add_Passenger();  //  15
            Console.Clear();
            P.Add_Passenger();  //  16
            Console.Clear();
            P.Add_Passenger();  //  17
            Console.Clear();
            P.Add_Passenger();  //  18
            Console.Clear();
            P.Add_Passenger();  //  19
            Console.Clear();
            P.Add_Passenger();  //  20
            Console.Clear();
            P.Add_Passenger();  //  21
            Console.Clear();
            P.Add_Passenger();  //  22
            Console.Clear();
            P.Add_Passenger();  //  23
            Console.Clear();
            P.Add_Passenger();  //  24
            Console.Clear();
            P.Add_Passenger();  //  25
            Console.Clear();
            P.Add_Passenger();  //  26
            Console.Clear();
            P.Add_Passenger();  //  27
            Console.Clear();
            P.Add_Passenger();  //  28
            Console.Clear();
            P.Add_Passenger();  //  29
            Console.Clear();
            P.Add_Passenger();  //  30
            Console.Clear();
            P.Add_Passenger();  //  31
            Console.Clear();
            P.Add_Passenger();  //  32
            Console.Clear();
            P.Add_Passenger();  //  33
            Console.Clear();
            P.Add_Passenger();  //  34
            Console.Clear();
            P.Add_Passenger();  //  35
            Console.Clear();
            P.Add_Passenger();  //  36
            
            Console.Clear();
            P.Print_Manifest();
            //*///

            //*
            Console.Clear();
            P.Add_Passenger();  //  1 - Som är en för mycket i förhållande till stolsplatserna som är satt.
            Console.ReadLine();

            Console.Clear();
            P.Print_Manifest();
            //*///
        }
        public static void Remove_P_Tester()
        {
            Console.Clear();
            P_Remove.Remove_Passenger();
            P.Print_Manifest();

            Console.Clear();
            P_Remove.Remove_Passenger();
            P.Print_Manifest();

            Console.Clear();
            P_Remove.Remove_Passenger();
            P.Print_Manifest();

        }
    }
}
