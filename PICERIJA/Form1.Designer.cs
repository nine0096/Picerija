
namespace PICERIJA
{
    partial class Form1
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
            this.cmdUcitajRaspored = new System.Windows.Forms.Button();
            this.cmdDodajBicikl = new System.Windows.Forms.Button();
            this.cmdDodajAutomobil = new System.Windows.Forms.Button();
            this.cmdPoruciPicu = new System.Windows.Forms.Button();
            this.cmdDodajKupca = new System.Windows.Forms.Button();
            this.cmdDodajZaposlenog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdDodajSkuter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdManyToOne = new System.Windows.Forms.Button();
            this.cmdmany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdUcitajRaspored
            // 
            this.cmdUcitajRaspored.Location = new System.Drawing.Point(53, 47);
            this.cmdUcitajRaspored.Name = "cmdUcitajRaspored";
            this.cmdUcitajRaspored.Size = new System.Drawing.Size(132, 29);
            this.cmdUcitajRaspored.TabIndex = 0;
            this.cmdUcitajRaspored.Text = "Ucitaj raspored";
            this.cmdUcitajRaspored.UseVisualStyleBackColor = true;
            this.cmdUcitajRaspored.Click += new System.EventHandler(this.cmdUcitajRaspored_Click);
            // 
            // cmdDodajBicikl
            // 
            this.cmdDodajBicikl.Location = new System.Drawing.Point(53, 342);
            this.cmdDodajBicikl.Name = "cmdDodajBicikl";
            this.cmdDodajBicikl.Size = new System.Drawing.Size(132, 28);
            this.cmdDodajBicikl.TabIndex = 1;
            this.cmdDodajBicikl.Text = "Dodaj bicikl";
            this.cmdDodajBicikl.UseVisualStyleBackColor = true;
            this.cmdDodajBicikl.Click += new System.EventHandler(this.cmdDodajBicikl_Click);
            // 
            // cmdDodajAutomobil
            // 
            this.cmdDodajAutomobil.Location = new System.Drawing.Point(53, 308);
            this.cmdDodajAutomobil.Name = "cmdDodajAutomobil";
            this.cmdDodajAutomobil.Size = new System.Drawing.Size(132, 28);
            this.cmdDodajAutomobil.TabIndex = 2;
            this.cmdDodajAutomobil.Text = "Dodaj automobil";
            this.cmdDodajAutomobil.UseVisualStyleBackColor = true;
            this.cmdDodajAutomobil.Click += new System.EventHandler(this.cmdDodajAutomobil_Click);
            // 
            // cmdPoruciPicu
            // 
            this.cmdPoruciPicu.Location = new System.Drawing.Point(50, 185);
            this.cmdPoruciPicu.Name = "cmdPoruciPicu";
            this.cmdPoruciPicu.Size = new System.Drawing.Size(132, 29);
            this.cmdPoruciPicu.TabIndex = 3;
            this.cmdPoruciPicu.Text = "Poruci picu";
            this.cmdPoruciPicu.UseVisualStyleBackColor = true;
            this.cmdPoruciPicu.Click += new System.EventHandler(this.cmdPoruciPicu_Click);
            // 
            // cmdDodajKupca
            // 
            this.cmdDodajKupca.Location = new System.Drawing.Point(328, 47);
            this.cmdDodajKupca.Name = "cmdDodajKupca";
            this.cmdDodajKupca.Size = new System.Drawing.Size(132, 31);
            this.cmdDodajKupca.TabIndex = 4;
            this.cmdDodajKupca.Text = "Dodaj kupca";
            this.cmdDodajKupca.UseVisualStyleBackColor = true;
            this.cmdDodajKupca.Click += new System.EventHandler(this.cmdDodajKupca_Click);
            // 
            // cmdDodajZaposlenog
            // 
            this.cmdDodajZaposlenog.Location = new System.Drawing.Point(328, 84);
            this.cmdDodajZaposlenog.Name = "cmdDodajZaposlenog";
            this.cmdDodajZaposlenog.Size = new System.Drawing.Size(132, 31);
            this.cmdDodajZaposlenog.TabIndex = 5;
            this.cmdDodajZaposlenog.Text = "Dodaj zaposlenog";
            this.cmdDodajZaposlenog.UseVisualStyleBackColor = true;
            this.cmdDodajZaposlenog.Click += new System.EventHandler(this.cmdDodajZaposlenog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Table-per-concrete-class inheritance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Table-per-class-hierarchy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Table-per-class-inheritance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ucitavanje rasporeda";
            // 
            // cmdDodajSkuter
            // 
            this.cmdDodajSkuter.Location = new System.Drawing.Point(53, 376);
            this.cmdDodajSkuter.Name = "cmdDodajSkuter";
            this.cmdDodajSkuter.Size = new System.Drawing.Size(132, 30);
            this.cmdDodajSkuter.TabIndex = 10;
            this.cmdDodajSkuter.Text = "Dodaj skuter";
            this.cmdDodajSkuter.UseVisualStyleBackColor = true;
            this.cmdDodajSkuter.Click += new System.EventHandler(this.cmdDodajSkuter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Veze";
            // 
            // cmdManyToOne
            // 
            this.cmdManyToOne.Location = new System.Drawing.Point(328, 188);
            this.cmdManyToOne.Name = "cmdManyToOne";
            this.cmdManyToOne.Size = new System.Drawing.Size(132, 26);
            this.cmdManyToOne.TabIndex = 12;
            this.cmdManyToOne.Text = "ManyToOne";
            this.cmdManyToOne.UseVisualStyleBackColor = true;
            this.cmdManyToOne.Click += new System.EventHandler(this.cmdManyToOne_Click);
            // 
            // cmdmany
            // 
            this.cmdmany.Location = new System.Drawing.Point(328, 234);
            this.cmdmany.Name = "cmdmany";
            this.cmdmany.Size = new System.Drawing.Size(132, 27);
            this.cmdmany.TabIndex = 13;
            this.cmdmany.Text = "OneToMany";
            this.cmdmany.UseVisualStyleBackColor = true;
            this.cmdmany.Click += new System.EventHandler(this.cmdmany_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdmany);
            this.Controls.Add(this.cmdManyToOne);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdDodajSkuter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdDodajZaposlenog);
            this.Controls.Add(this.cmdDodajKupca);
            this.Controls.Add(this.cmdPoruciPicu);
            this.Controls.Add(this.cmdDodajAutomobil);
            this.Controls.Add(this.cmdDodajBicikl);
            this.Controls.Add(this.cmdUcitajRaspored);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdUcitajRaspored;
        private System.Windows.Forms.Button cmdDodajBicikl;
        private System.Windows.Forms.Button cmdDodajAutomobil;
        private System.Windows.Forms.Button cmdPoruciPicu;
        private System.Windows.Forms.Button cmdDodajKupca;
        private System.Windows.Forms.Button cmdDodajZaposlenog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdDodajSkuter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdManyToOne;
        private System.Windows.Forms.Button cmdmany;
    }
}

