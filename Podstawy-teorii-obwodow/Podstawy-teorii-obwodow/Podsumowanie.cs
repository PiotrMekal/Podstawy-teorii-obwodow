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
    public partial class Podsumowanie : Form
    {
        float wynik;
        public Podsumowanie(float wynik)
        {
            this.wynik = wynik;
            InitializeComponent();
        }

        

        private void Podsumowanie_Load(object sender, EventArgs e)
        {
            lblwynik.Text = wynik.ToString();
            

            if (wynik >=4500)
            {
                label4.Text = "5";
            }
            else if(wynik>=4000)
            {
                label4.Text = "4";
            }
            else if (wynik >= 2500)
            {
                label4.Text = "3";
            }
            else
            {
                label4.Text = "2";
            }
        }

        private void lblwynik_Click(object sender, EventArgs e)
        {

        }
    }
}
