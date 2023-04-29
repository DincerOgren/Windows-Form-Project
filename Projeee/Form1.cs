using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Projeee
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        public class atikKutusu :Atik
        {
            public int Oran { get; set; }
            public double Sayi { get; set; }
            public int _DoluHacim { get; set; }

            public int Kapasite { get; set; }

            public void Atama(ProgressBar pBar,Atik atik)
            {

                Oran = pBar.Value * 100 / pBar.Maximum;
                
                    _DoluHacim = pBar.Value;
                    Kapasite = pBar.Maximum;
     
                if (atik.sayi==1)
                {
                    if (_DoluHacim + pBar.Step >= Kapasite)
                    {
                        Sayi = 0;
                        return;
                    }
                    Sayi = 1;
                    pBar.Step=150;
                    pBar.PerformStep();
                }

                if (atik.sayi == 2)
                {
                    if (_DoluHacim + pBar.Step >= Kapasite)
                    {
                        Sayi = 0;
                        return;
                    }
                    Sayi = 1;
                    pBar.Step = 120;
                    pBar.PerformStep();
                }
                if (atik.sayi == 3)
                {
                    if (_DoluHacim + pBar.Step >= Kapasite)
                    {
                        Sayi = 0;
                        return;
                    }
                    Sayi = 1;
                    pBar.Step = 600;
                    pBar.PerformStep();
                }
                if (atik.sayi == 4)
                {
                    if (_DoluHacim + pBar.Step >= Kapasite)
                    {
                        Sayi = 0;
                        return;
                    }
                    Sayi = 1;
                    pBar.Step = 350;
                    pBar.PerformStep();
                }
                if (atik.sayi == 5)
                {
                    if (_DoluHacim + pBar.Step >= Kapasite)
                    {
                        Sayi = 0;
                        return;
                    }
                    Sayi = 1;
                    pBar.Step = 250;
                    pBar.PerformStep();
                }
                if (atik.sayi == 6)
                {                 
                    if (_DoluHacim + pBar.Step >= Kapasite)
                    {
                        Sayi = 0;
                        return;
                    }
                    Sayi = 1;
                    pBar.Step = 200;
                    pBar.PerformStep();
                }
                if (atik.sayi == 7)
                {
                    if (_DoluHacim + pBar.Step >= Kapasite)
                    {
                        Sayi = 0;
                        return;
                    }
                    Sayi = 1;
                    pBar.Step = 250;
                    pBar.PerformStep();
                }
                if (atik.sayi == 8)
                {
                    if (_DoluHacim + pBar.Step >= Kapasite)
                    {
                        Sayi = 0;
                        return;
                    }
                    Sayi = 1;
                    pBar.Step = 550;
                    pBar.PerformStep();
                }

            }
            
        }
        public interface IAtik
        {
            int Hacim { get; }

            Image Image { get; }
        }

        public int again = 0;
        public int puanDurumu = 0;
        public Atik atik1 = new Atik();
        public atikKutusu kutu = new atikKutusu();
        private void timer1_Tick(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(sureLabel.Text);
            
            if (deger==0)
            {
                organikButton.Enabled = false;
                kagıtButton.Enabled = false;
                camButton.Enabled = false;
                metalButton.Enabled = false;
                obosaltButton.Enabled = false;
                kbosaltButton.Enabled = false;
                cbosaltButton.Enabled = false;
                mbosaltButton.Enabled = false;
                button9.Enabled = true;
                pictureBox1.Image = null;
                again = 1;
                return;
            }
            deger--;
            sureLabel.Text = deger.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (again==1)
            {
                Temizle();
            }
            timer1.Start();
            sureLabel.Text = 60.ToString();
            organikButton.Enabled = true;
            kagıtButton.Enabled = true;
            camButton.Enabled = true;
            metalButton.Enabled = true;
            obosaltButton.Enabled = true;
            kbosaltButton.Enabled = true;
            cbosaltButton.Enabled = true;
            mbosaltButton.Enabled = true;

            pictureBox1.Image = atik1.Image;
            label2.Text = atik1.Hacim.ToString();
            button9.Enabled = false;
        }
        
        private void organikButton_Click(object sender, EventArgs e)
        {

            switch (atik1.sayi)
            {
                case 1:
                    {
                        kutu.Atama(opBar, atik1);
                        if (kutu.Sayi == 0)
                        {
                            return;
                        }
                        listEkle();
                        puanDurumu += 150;
                        puanLabel.Text = puanDurumu.ToString();

                        var atik = new Atik();
                        atik1 = atik;
                        pictureBox1.Image = atik.Image;
                        label2.Text = atik.Hacim.ToString();

                        break;
                    }
                case 2:
                    {
                        kutu.Atama(opBar, atik1);

                        if (kutu.Sayi == 0)
                        {
                            return;
                        }
                        listEkle();
                        puanDurumu += 120;
                        puanLabel.Text = puanDurumu.ToString();

                        var atik = new Atik();
                        atik1 = atik;
                        pictureBox1.Image = atik.Image;
                        label2.Text = atik.Hacim.ToString();

                        break;
                    }

                default:
                    break;
            }

        }

        private void kagıtButton_Click(object sender, EventArgs e)
        {

            switch (atik1.sayi)
            {
                case 5:
                    {
                        kutu.Atama(kpBar, atik1);

                        if (kutu.Sayi == 0)
                        {
                            return;
                        }
                        listEkle(); 
                        puanDurumu += 250;
                        puanLabel.Text = puanDurumu.ToString();

                        var atik = new Atik();
                        atik1 = atik;
                        pictureBox1.Image = atik.Image;
                        label2.Text = atik.Hacim.ToString();

                        break;
                    }
                case 6:
                    {
                        kutu.Atama(kpBar, atik1);

                        if (kutu.Sayi == 0)
                        {
                            return;
                        }
                        listEkle();
                        puanDurumu += 200;
                        puanLabel.Text = puanDurumu.ToString();

                        var atik = new Atik();
                        atik1 = atik;
                        pictureBox1.Image = atik.Image;
                        label2.Text = atik.Hacim.ToString();

                        break;
                    }
            }

        }

        private void camButton_Click(object sender, EventArgs e)
        {

            switch (atik1.sayi)
            {
                case 3:
                    {
                        kutu.Atama(cpBar, atik1);

                        if (kutu.Sayi == 0)
                        {
                            return;
                        }
                        listEkle();
                        puanDurumu += 600;
                        puanLabel.Text = puanDurumu.ToString();

                        var atik = new Atik();
                        atik1 = atik;
                        pictureBox1.Image = atik.Image;
                        label2.Text = atik.Hacim.ToString();
                       
                        break;
                    }
                case 7:
                    {
                        kutu.Atama(cpBar, atik1);

                        if (kutu.Sayi == 0)
                        {
                            return;
                        }
                        listEkle();
                        puanDurumu += 250;
                        puanLabel.Text = puanDurumu.ToString();

                        var atik = new Atik();
                        atik1 = atik;
                        pictureBox1.Image = atik.Image;
                        label2.Text = atik.Hacim.ToString();

                        break;
                    }
            }
        }

        private void metalButton_Click(object sender, EventArgs e)
        {

            switch (atik1.sayi)
            {
                case 4:
                    {
                        kutu.Atama(mpBar, atik1);

                        if (kutu.Sayi == 0)
                        {
                            return;
                        }
                        listEkle();
                        puanDurumu += 350;
                        puanLabel.Text = puanDurumu.ToString();
                        
                        var atik = new Atik();
                        atik1 = atik;
                        pictureBox1.Image = atik.Image;
                        label2.Text = atik.Hacim.ToString();

                        break;
                    }
                case 8:
                    {
                        kutu.Atama(mpBar, atik1);

                        if (kutu.Sayi == 0)
                        {
                            return;
                        }
                        listEkle();
                        puanDurumu += 550;
                        puanLabel.Text = puanDurumu.ToString();

                        var atik = new Atik();
                        atik1 = atik;
                        pictureBox1.Image = atik.Image;
                        label2.Text = atik.Hacim.ToString();

                        break;
                    }
            }

        }
        private void listEkle()
        {
            if (atik1.sayi==1)
            {
                listBox1.Items.Add("Domates(150)");

            }

            if (atik1.sayi == 2)
            {
                listBox1.Items.Add("Salatalık(120)");

            }
            if (atik1.sayi == 3)
            {
                listBox3.Items.Add("Cam Şişe(600)");

            }
            if (atik1.sayi == 4)
            {
                listBox4.Items.Add("Kola Kutusu(350)");

            }
            if (atik1.sayi == 5)
            {
                listBox2.Items.Add("Gazete(250)");

            }
            if (atik1.sayi == 6)
            {
                listBox2.Items.Add("Dergi(200)");

            }
            if (atik1.sayi == 7)
            {
                listBox3.Items.Add("Bardak(250)");

            }
            if (atik1.sayi == 8)
            {
                listBox4.Items.Add("Salça Kutusu(550)");

            }

        }

        private void obosaltButton_Click(object sender, EventArgs e)
        {
            bosalt(opBar, listBox1);
            BosaltmaPuani(opBar);
        }

        private void kbosaltButton_Click(object sender, EventArgs e)
        {
            bosalt(kpBar,listBox2);
            BosaltmaPuani(kpBar);
        }

        private void cbosaltButton_Click(object sender, EventArgs e)
        {
            bosalt(cpBar,listBox3);
            BosaltmaPuani(cpBar);
        }

        private void mbosaltButton_Click(object sender, EventArgs e)
        {
            bosalt(mpBar,listBox4);
            BosaltmaPuani(mpBar);
        }

        public void bosalt(ProgressBar bar,ListBox listBox)
        {
            if (bar.Value * 100 / bar.Maximum >= 75)
            {
                bar.Value = 0;
                listBox.Items.Clear();
                sureLabel.Text = (Convert.ToInt32(sureLabel.Text) + 3).ToString();
            }
        }
        public void BosaltmaPuani(ProgressBar progressBar)
        {
            if (progressBar.Maximum == 1200)
            {
                puanDurumu += 1000;
                puanLabel.Text = puanDurumu.ToString();
            }
            if (progressBar.Maximum == 2200)
            {
                puanDurumu += 600;
                puanDurumu.ToString();
            }
            if (progressBar.Maximum == 2300)
            {
                puanDurumu += 800;
                puanDurumu.ToString();
            }
        }
        
        private void Temizle()
        {
            opBar.Value = 0;
            kpBar.Value = 0;
            cpBar.Value = 0;
            mpBar.Value = 0;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            var atik = new Atik();
            atik1 = atik;
            puanDurumu = 0;
            again = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
