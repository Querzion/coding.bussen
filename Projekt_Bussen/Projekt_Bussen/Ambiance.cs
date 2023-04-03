using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Bussen
{
    internal class Ambiance
    {

        //  Spelar upp ljud en gång i taget.
        public static void PlaySound(string filepath)
        {

            SoundPlayer BGS = new SoundPlayer();

            BGS.SoundLocation = filepath;
            BGS.PlaySync();
        }

        //  Spelar upp ljud i en loop.
        public static void PlayMusic(string filepath)
        {

            SoundPlayer BGM = new SoundPlayer();

            BGM.SoundLocation = filepath;
            BGM.PlayLooping();
        }
    }
}
