using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Podstawy_teorii_obwodow
{
    class Poziom : TextBox //Label
    {
        public Poziom() : base()
        {
            this.AutoSize = false;
            this.Size = new Size(350, 40);
            this.Location = new Point(10, 50);
            this.Visible = true;
            this.ReadOnly = true;
            this.Font = new Font("Castellar", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = Color.WhiteSmoke;
            this.Text = "Props, nastepny poziom";
        }
    }
}