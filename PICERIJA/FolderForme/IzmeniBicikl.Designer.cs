
namespace PICERIJA.FolderForme
{
    partial class IzmeniBicikl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbRam = new System.Windows.Forms.TextBox();
            this.txbNaziv = new System.Windows.Forms.TextBox();
            this.txbProizvodjac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzmeniBicikl = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbRam);
            this.groupBox1.Controls.Add(this.txbNaziv);
            this.groupBox1.Controls.Add(this.txbProizvodjac);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnIzmeniBicikl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 462);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci o biciklu";
            // 
            // txbRam
            // 
            this.txbRam.Location = new System.Drawing.Point(177, 214);
            this.txbRam.Name = "txbRam";
            this.txbRam.Size = new System.Drawing.Size(213, 36);
            this.txbRam.TabIndex = 6;
            // 
            // txbNaziv
            // 
            this.txbNaziv.Location = new System.Drawing.Point(177, 152);
            this.txbNaziv.Name = "txbNaziv";
            this.txbNaziv.Size = new System.Drawing.Size(213, 36);
            this.txbNaziv.TabIndex = 5;
            // 
            // txbProizvodjac
            // 
            this.txbProizvodjac.Location = new System.Drawing.Point(177, 81);
            this.txbProizvodjac.Name = "txbProizvodjac";
            this.txbProizvodjac.Size = new System.Drawing.Size(213, 36);
            this.txbProizvodjac.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Velicina rama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv tipa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proizvodjac:";
            // 
            // btnIzmeniBicikl
            // 
            this.btnIzmeniBicikl.BackColor = System.Drawing.Color.LightSalmon;
            this.btnIzmeniBicikl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeniBicikl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniBicikl.Location = new System.Drawing.Point(315, 371);
            this.btnIzmeniBicikl.Name = "btnIzmeniBicikl";
            this.btnIzmeniBicikl.Size = new System.Drawing.Size(131, 49);
            this.btnIzmeniBicikl.TabIndex = 0;
            this.btnIzmeniBicikl.Text = "IZMENI";
            this.btnIzmeniBicikl.UseVisualStyleBackColor = false;
            this.btnIzmeniBicikl.Click += new System.EventHandler(this.btnIzmeniBicikl_Click);
            // 
            // IzmeniBicikl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 497);
            this.Controls.Add(this.groupBox1);
            this.Name = "IzmeniBicikl";
            this.Text = "IzmeniBicikl";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbRam;
        private System.Windows.Forms.TextBox txbNaziv;
        private System.Windows.Forms.TextBox txbProizvodjac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzmeniBicikl;
    }
}