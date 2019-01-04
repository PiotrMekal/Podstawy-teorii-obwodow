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
            INIT();
            
        }



        private Point firstPoint = new Point();

        public void INIT()
        {
            movObj.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { firstPoint = Control.MousePosition; }
            };

            movObj.MouseMove += (ss, ee) => {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    movObj.Location = new Point(movObj.Location.X - res.X, movObj.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };

        }

        public static class Wynik
        {
            public static float wynik=5000;
            

        }

        private void Poziom1_Load(object sender, EventArgs e)
        {
            dropR.AllowDrop = true;
            lblwynik.Text = Wynik.wynik.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Poziom1 poziom = new Poziom1();
            poziom.Show();
            Visible = false;
            
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

        private void r1_MouseDown(object sender, MouseEventArgs e)
        {           
            var img = r1.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                r1.Image = null;
            }
        }

        private void r2_MouseDown(object sender, MouseEventArgs e)
        {            
            var img = r2.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                r2.Image = null;
            }
        }

        private void r3_MouseDown(object sender, MouseEventArgs e)
        {           
            var img = r3.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                r3.Image = null;
            }
        }

        private void r4_MouseDown(object sender, MouseEventArgs e)
        {            
            var img = r4.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                r4.Image = null;
            }
        }

        private void r5_MouseDown(object sender, MouseEventArgs e)
        {           
            var img = r5.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                r5.Image = null;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sprawdz_Click(object sender, EventArgs e)
        {
            if (r3.Location.X != 320 && r3.Location.Y != 615)
            {
                button1.Visible = true;
            }

        }

        private void r1_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void r3_Click(object sender, EventArgs e)
        {

        }
    }
}
