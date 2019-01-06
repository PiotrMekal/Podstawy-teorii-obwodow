using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podstawy_teorii_obwodow
{
    public partial class Poziom1 : Form
    {
        Poziom level = new Poziom();
        int numer = 0;
        Boolean odp = true;
        public static int lvl = 1;
        public Poziom1()
        {
            InitializeComponent();
            r1.MouseDown += r1_MouseDown;
            r2.MouseDown += r2_MouseDown;
            r3.MouseDown += r3_MouseDown;
            r4.MouseDown += r4_MouseDown;
            r5.MouseDown += r5_MouseDown;
            dropR.AllowDrop = true;
            dropR.DragEnter += dropR_DragEnter;
            dropR.DragDrop += dropR_DragDrop;         
        }
    
        public static class Wynik
        {
            public static float wynik=5000;            
        }

        private void Poziom1_Load(object sender, EventArgs e)
        {
            dropR.AllowDrop = true;
            lblwynik.Text = Wynik.wynik.ToString();
            label13.Text = lvl.ToString();
            switch (lvl)
            {
                case 2:
                    label2.Text = "Podpowiedz:\n Laczenie rownolegle rezystorow \nR=(R1*Rw)/(R1+Rw) \nRw- rezystancja wybrana przez gracza";
                    //rezyst na rysunku
                    label1.Text = "Zad 2. Laczenie rownolegle rezystorow \nWstaw odpowiedni rezystor tak aby Rezystancja ukladu wynosila 2 Ohm.";
                    label4.Text = "4 Ohm";                
                    //5 rezyst na dole
                    label7.Text = " 2 Ohm";
                    label8.Text = "4 Ohm";
                    label9.Text = "1 Ohm";
                    label10.Text = "10 Ohm";
                    label11.Text = "7 Ohm";

                    poziom.Image = Image.FromFile(@"C:\Users\7\Desktop\PROJEKT_JPWP_2018\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\poziom2.png");
                    dropR.Location = new Point(486, 308);
                    label4.Location = new Point(205, 353);
                    label12.Location = new Point(598, 353);
                    label5.Visible = false;
                    label6.Visible = false;                   
                    break;
                case 3:
                    label1.Text = "Zad 3. Laczenie rownolegle i szeregowe rezystorow \nWstaw odpowiedni rezystor tak aby Rezystancja układu wynosiła 10 Ohm.";
                    label2.Text = "Podpowiedz:\n W oparciu o poprzednie wzory\nsprowadz schemat do najprostszej postaci";

                    label4.Text = "3 Ohm";
                    label5.Text = "6 Ohm";
                    
                    label7.Text = "7 Ohm";
                    label8.Text = "8 Ohm";
                    label9.Text = "10 Ohm";
                    label10.Text = "9 Ohm";
                    label11.Text = "6 Ohm";

                    poziom.Image = Image.FromFile(@"C:\Users\7\Desktop\PROJEKT_JPWP_2018\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\poziom3.png");
                    
                    dropR.Location = new Point(399, 406);
                    label4.Location = new Point(197, 274);
                    label12.Location = new Point(523, 445);
                    label5.Location = new Point(613, 274);
                    label6.Visible = false;
                    break;
                case 4: //kondensator 1
                    label1.Text = "Zad 4. Laczenie szeregowe kondensatorow \nWstaw odpowiedni kondensator tak aby pojemnosc ukladu wynosila 2F.";
                    label2.Text = "Podpowiedz:\n C= 1/C1 +1/Cw\n lub (C1*Cw)/(C1+Cw)\nCw-kondensator wybrany przez gracza";

                    label4.Text = "12 F";
                    label5.Text = "4 F";
                    
                    label7.Text = "6 F";
                    label8.Text = "1 F";
                    label9.Text = "3 F";
                    label10.Text = "7 F";
                    label11.Text = "4 F";
                    poziom.Image = Image.FromFile(@"C:\Users\7\Desktop\PROJEKT_JPWP_2018\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\poziom4.png");
                    r1.Image = Image.FromFile(@"C:\Users\7\Desktop\PROJEKT_JPWP_2018\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\kondensator1.png");
                    r2.Image = Image.FromFile(@"C:\Users\7\Desktop\PROJEKT_JPWP_2018\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\kondensator1.png");
                    r3.Image = Image.FromFile(@"C:\Users\7\Desktop\PROJEKT_JPWP_2018\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\kondensator1.png");
                    r4.Image = Image.FromFile(@"C:\Users\7\Desktop\PROJEKT_JPWP_2018\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\kondensator1.png");
                    r5.Image = Image.FromFile(@"C:\Users\7\Desktop\PROJEKT_JPWP_2018\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\kondensator1.png");
                    dropR.Location = new Point(398, 383);
                    label4.Location = new Point(504, 220);
                    label12.Location = new Point(538, 412);
                    label5.Location = new Point(504, 297);
                    label6.Visible = false;
                    break;
                case 5: //kondensator 2
                    label1.Text = "Zad 5. Laczenie rownlegle kondensatorow \nWstaw odpowiedni kondensator tak aby pojemnosc ukladu wynosila 25F.";
                    label2.Text = "Podpowiedz:\nkondensatory laczy sie rownolegle\n tak jak rezysotry szeregowo";

                    label4.Text = "12 F";
                    label5.Text = "4 F";
                    
                    label7.Text = "5 F";
                    label8.Text = "13 F";
                    label9.Text = "11 F";
                    label10.Text = "9 F";
                    label11.Text = "6 F";
                    poziom.Image = Image.FromFile(@"C:\Users\7\Desktop\PROJEKT_JPWP_2018\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\poziom5.png");
                    r1.Image = Image.FromFile(@"C:\Users\7\Desktop\PROJEKT_JPWP_2018\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\kondensator1.png");
                    r2.Image = Image.FromFile(@"C:\Users\7\Desktop\PROJEKT_JPWP_2018\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\kondensator1.png");
                    r3.Image = Image.FromFile(@"C:\Users\7\Desktop\PROJEKT_JPWP_2018\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\kondensator1.png");
                    r4.Image = Image.FromFile(@"C:\Users\7\Desktop\PROJEKT_JPWP_2018\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\kondensator1.png");
                    r5.Image = Image.FromFile(@"C:\Users\7\Desktop\PROJEKT_JPWP_2018\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\kondensator1.png");
                    dropR.Location = new Point(393, 284);
                    label4.Location = new Point(144, 322);
                    label12.Location = new Point(487, 373);
                    label5.Location = new Point(655, 322);
                    label6.Visible = false;
                    break;
                case 6: //kondensator 3
                    label1.Text = "Zad 6. Laczenie rownlegle i szeregowe kondensatorow \nWstaw odpowiedni kondensator tak aby pojemnosc ukladu wynosila 2,5F.";
                    label2.Text = "Podpowiedz\nSprowadz uklad do najprostszej postaci";

                    label4.Text = "11 F";
                    label5.Text = "4 F";
                    
                    label7.Text = "2 F";
                    label8.Text = "7 F";
                    label9.Text = "3 F";
                    label10.Text = "5 F";
                    label11.Text = "1 F";
                    poziom.Image = Image.FromFile(@"C:\Users\7\Desktop\PROJEKT_JPWP_2018\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\poziom6.png");
                    r1.Image = Image.FromFile(@"C:\Users\7\Desktop\PROJEKT_JPWP_2018\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\kondensator1.png");
                    r2.Image = Image.FromFile(@"C:\Users\7\Desktop\PROJEKT_JPWP_2018\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\kondensator1.png");
                    r3.Image = Image.FromFile(@"C:\Users\7\Desktop\PROJEKT_JPWP_2018\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\kondensator1.png");
                    r4.Image = Image.FromFile(@"C:\Users\7\Desktop\PROJEKT_JPWP_2018\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\kondensator1.png");
                    r5.Image = Image.FromFile(@"C:\Users\7\Desktop\PROJEKT_JPWP_2018\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\Podstawy-teorii-obwodow\kondensator1.png");
                    dropR.Location = new Point(398, 373);
                    label4.Location = new Point(185, 275);
                    label12.Location = new Point(509, 414);
                    label5.Location = new Point(613, 275);
                    label6.Visible = false;
                    break;               

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            Wynik.wynik = Wynik.wynik - 450;
            lblwynik.Text = Wynik.wynik.ToString();
            MessageBox.Show("Za skorzystanie z podpowiedzi tracisz 450pkt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ++lvl;
            
            Poziom1 level = new Poziom1();
            level.Show();
            Visible = false;                        
        }
        
        private void r1_MouseDown(object sender, MouseEventArgs e)
        {
            numer = 0;
            var img = r1.Image;
            if (img == null) return;
            if (odp)
            {
                if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
                {
                    r1.Image = null;
                    odp = false;
                }
            }
            
        }

        private void r2_MouseDown(object sender, MouseEventArgs e)
        {
            numer = 1;
            var img = r2.Image;
            if (img == null) return;
            if (odp)
            {
                if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
                {
                    r2.Image = null;
                    odp = false;
                }
            }
        }

        private void r3_MouseDown(object sender, MouseEventArgs e)
        {
            numer = 2;
            var img = r3.Image;
            if (img == null) return;
            if (odp)
            {
                if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
                {
                    r3.Image = null;
                    odp = false;
                }
            }
        }

        private void r4_MouseDown(object sender, MouseEventArgs e)
        {
            numer = 3;
            var img = r4.Image;
            if (img == null) return;
            if (odp)
            {
                if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
                {
                    r4.Image = null;
                    odp = false;
                }
            }
        }

        private void r5_MouseDown(object sender, MouseEventArgs e)
        {
            numer = 4;
            var img = r5.Image;
            if (img == null) return;
            if (odp)
            {
                if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
                {
                    r5.Image = null;
                    odp = false;
                }
            }
        }

        private void dropR_DragEnter(object sender, DragEventArgs e)
        {            
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
        }

        private void dropR_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            dropR.Image = bmp;                        
        }
        
        private void sprawdz_Click(object sender, EventArgs e)
        {
            odp = true;
            switch (lvl)
            {
                case 1:
                    if (numer == 2)
                    {
                        button1.Visible = true;
                        r1.Image = null;
                        r2.Image = null;
                        r4.Image = null;
                        r5.Image = null;
                        label7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Visible = true;
                        MessageBox.Show("Dobrze! przechodzisz do nastepnego poziomu!");

                    }
                    else
                    {
                        button1.Visible = false;                       
                        dropR.Image = null;                      

                        Wynik.wynik = Wynik.wynik - 150;
                        lblwynik.Text = Wynik.wynik.ToString();
                        MessageBox.Show("Zle! tracisz 150pkt. Sprobuj jeszcze raz!");
                    }
                    break;
                case 2:
                    if (numer == 1)
                    {
                        button1.Visible = true;
                        r1.Image = null;
                        r3.Image = null;
                        r4.Image = null;
                        r5.Image = null;

                        label7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Text = label8.Text;
                        label12.Visible = true;
                        MessageBox.Show("Dobrze! przechodzisz do nastepnego poziomu!");
                    }
                    else
                    {
                        button1.Visible = false;
                        dropR.Image = null; 

                        Wynik.wynik = Wynik.wynik - 150;
                        lblwynik.Text = Wynik.wynik.ToString();
                        MessageBox.Show("Zle! tracisz 150pkt. Sprobuj jeszcze raz!");
                    }
                    break;
                case 3:
                    if (numer == 1)
                    {
                        button1.Visible = true;
                        r1.Image = null;
                        r3.Image = null;
                        r4.Image = null;
                        r5.Image = null;

                        label7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Text = label8.Text;
                        label12.Visible = true;
                        MessageBox.Show("Dobrze! przechodzisz do nastepnego poziomu! Zajmiemy sie teraz laczeniem kondensatorow." +
                            " Kondensator to element elektroniczny zbudowany z dwoch przewodnikow rozdzielonych dielektrykiem");
                    }
                    else
                    {
                        button1.Visible = false;
                        dropR.Image = null;

                        Wynik.wynik = Wynik.wynik - 150;
                        lblwynik.Text = Wynik.wynik.ToString();
                        MessageBox.Show("Zle! tracisz 150pkt. Sprobuj jeszcze raz!");
                    }
                    break;
                case 4:
                    if (numer == 0)
                    {
                        button1.Visible = true;
                        r3.Image = null;
                        r2.Image = null;
                        r4.Image = null;
                        r5.Image = null;

                        label7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Text = label7.Text;
                        label12.Visible = true;
                        MessageBox.Show("Dobrze! przechodzisz do nastepnego poziomu!");
                    }
                    else
                    {
                        button1.Visible = false;
                        dropR.Image = null;

                        Wynik.wynik = Wynik.wynik - 150;
                        lblwynik.Text = Wynik.wynik.ToString();
                        MessageBox.Show("Zle! tracisz 150pkt. Sprobuj jeszcze raz!");
                    }
                    break;
                case 5:
                    if (numer == 3)
                    {
                        button1.Visible = true;
                        r1.Image = null;
                        r2.Image = null;
                        r3.Image = null;
                        r5.Image = null;

                        label7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Text = label10.Text;
                        label12.Visible = true;
                        MessageBox.Show("Dobrze! przechodzisz do nastepnego poziomu!");
                    }
                    else
                    {
                        button1.Visible = false;
                        dropR.Image = null;

                        Wynik.wynik = Wynik.wynik - 150;
                        lblwynik.Text = Wynik.wynik.ToString();
                        MessageBox.Show("Zle! tracisz 150pkt. Sprobuj jeszcze raz!");
                    }
                    break;
                case 6:
                    if (numer == 2)
                    {
                        button1.Visible = false;
                        r1.Image = null;
                        r2.Image = null;
                        r4.Image = null;
                        r5.Image = null;

                        label7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Text = label9.Text;
                        label12.Visible = true;
                        MessageBox.Show("Dobrze!");
                        Podsumowanie poziom = new Podsumowanie(Wynik.wynik);
                        poziom.Show();
                        Visible = false;
                        Visible = false;
                    }
                    else
                    {
                        button1.Visible = false;
                        dropR.Image = null;

                        Wynik.wynik = Wynik.wynik - 150;
                        lblwynik.Text = Wynik.wynik.ToString();
                        MessageBox.Show("Zle! tracisz 150pkt. Sprobuj jeszcze raz!");
                    }
                    break;               
            }           
        }

        private void r1_Click(object sender, EventArgs e)
        {
            
        }

        private void r3_Click(object sender, EventArgs e)
        {

        }

        private void lblwynik_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {
          
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void r1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void r2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void r3_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void r4_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void r5_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
