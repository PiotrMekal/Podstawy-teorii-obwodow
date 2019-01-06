namespace Podstawy_teorii_obwodow
{
    partial class Podsumowanie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblwynik = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(152, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gratulacje! Udalo ci się ukonczyc gre\r\nTwoj wynik: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(152, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Twoja ocena koncowa to: ";
            // 
            // lblwynik
            // 
            this.lblwynik.AutoSize = true;
            this.lblwynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblwynik.ForeColor = System.Drawing.Color.Green;
            this.lblwynik.Location = new System.Drawing.Point(619, 201);
            this.lblwynik.Name = "lblwynik";
            this.lblwynik.Size = new System.Drawing.Size(86, 31);
            this.lblwynik.TabIndex = 2;
            this.lblwynik.Text = "label3";
            this.lblwynik.Click += new System.EventHandler(this.lblwynik_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(486, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // Podsumowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblwynik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Podsumowanie";
            this.Text = "Podsumowanie";
            this.Load += new System.EventHandler(this.Podsumowanie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblwynik;
        private System.Windows.Forms.Label label4;
    }
}