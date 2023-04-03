using Projekt_Bussen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projekt_Bussen
{
    internal class RandomID_Gen
    {


        //*     PASSENGER RANDOM CREATION - AGE|GENDER|DESIGNATION
        public static void Generate_Random_Passenger()
        {
            
            if (Globals.ledigaStolar != 0)
            {
                  
                //Globals.resenärAntal += 1;
                Globals.randAge = Globals.Random.Next(0, 125);

                if (Globals.randAge <= 12)
                {
                    Globals.designation = "Barn";
                    Globals.Barn++;
                    

                    var child_Gender = new string[] { "Pojke", "Flicka" };
                    var randomChild = Globals.Random.Next(child_Gender.Length);

                    Globals.randGender = $"{child_Gender[randomChild]}";

                    Globals.rAgeBarn.Add(Globals.randAge);
                    Globals.rGenBarn.Add(Globals.randGender);
                    

                }
                else if (Globals.randAge >= 13 && Globals.randAge <= 25)
                {
                    Globals.designation = "Ungdom";
                    Globals.Ungdom++;
                    

                    var teen_Gender = new string[] { "Kille", "Tjej", "Icke-Binär" };
                    var randomTeen = Globals.Random.Next(teen_Gender.Length);

                    Globals.randGender = $"{teen_Gender[randomTeen]}";

                    Globals.rAgeUngdom.Add(Globals.randAge);
                    Globals.rGenUngdom.Add(Globals.randGender);
                    

                }
                else if (Globals.randAge >= 26 && Globals.randAge <= 64)
                {
                    Globals.designation = "Vuxen";
                    Globals.Vuxen++;
                    

                    var adult_Gender = new string[] { "Man", "Kvinna", "Icke-Binär" };
                    var randomAdult = Globals.Random.Next(adult_Gender.Length);

                    Globals.randGender = $"{adult_Gender[randomAdult]}";

                    Globals.rAgeVuxen.Add(Globals.randAge);
                    Globals.rGenVuxen.Add(Globals.randGender);
                    

                }
                else if (Globals.randAge >= 65 && Globals.randAge < 125)
                {
                    Globals.designation = "Pensionär";
                    Globals.Pensionär++;
                    

                    var senior_Gender = new string[] { "Gubbe", "Gumma", "Icke-Binär" };
                    var randomSenior = Globals.Random.Next(senior_Gender.Length);

                    Globals.randGender = $"{senior_Gender[randomSenior]}";

                    Globals.rAgePensionär.Add(Globals.randAge);
                    Globals.rGenPensionär.Add(Globals.randGender);
                    

                }
            } else
            {
                Console.SetWindowSize(Globals.x, Globals.y);
                Console.WriteLine(/*"\n|-----------------------------------------------------|" +*/
                                  "\n   Tyvärr kan jag inte ta emot dig. Bussen är full.");
            }

        }   //*///    GENERATE PASSENGER ENDS HERE


        



        /*     RANDOM PASSENGER         
        //      Tidig version utav Add_Passenger. 
        //      ville ha kvar den för att se hur stor skillnaden var på första och den nya.

        public static void GenereraID()
        {
            //  NEW PASSENGER - CREATION
            Console.Clear();
            Passagerare.Generate_Random_Passenger();


            //  NEW PASSENGER - DETAILS

            Console.WriteLine("\n Barn/Ungdom/Vuxen/Senior? >  Personen är en/ett {0}." +
                              "\n Kön? : >  Hen är {1}." +
                              "\n Ålder? : > Hen är {2} år gammal.", Globals.designation, Globals.randGender, Globals.randAge);
            Console.ReadKey();


        }   //*///  RANDOM PASSANGER GENERATOR ENDS HERE
    }
}