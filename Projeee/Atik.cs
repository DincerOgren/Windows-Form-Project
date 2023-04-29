using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static Projeee.Form1;
using System.Drawing;

namespace Projeee
{
    public class Atik : IAtik
    {
        public static Random rasgele = new Random();
        public Atik()
        {
            sayi = rasgele.Next(1, 9);


            if (sayi == 1)
            {
                atikHacmi = 150;
                resimKonumu = "organik1.jpg";
            }

            if (sayi == 2)
            {
                atikHacmi = 120;
                resimKonumu = "organik2.jpg";
            }

            if (sayi == 3)
            {
                atikHacmi = 600;
                resimKonumu = "cam.jpg";
            }

            if (sayi == 4)
            {
                atikHacmi = 350;
                resimKonumu = "metal.jpg";
            }

            if (sayi == 5)
            {
                atikHacmi = 250;
                resimKonumu = "kagit.jpg";
            }

            if (sayi == 6)
            {
                atikHacmi = 200;
                resimKonumu = "kagit2.jpg";
            }

            if (sayi == 7)
            {
                atikHacmi = 250;
                resimKonumu = "cam2.jpg";
            }

            if (sayi == 8)
            {
                atikHacmi = 550;
                resimKonumu = "metal2.jpg";
            }
        }

        public int sayi;
        public int atikHacmi;
        public string resimKonumu;
        
        
        public int Hacim => atikHacmi;
        public Image Image => Image.FromFile(resimKonumu);


    }
}
