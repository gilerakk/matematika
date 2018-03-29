namespace Matematika
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
            this.components = new System.ComponentModel.Container();
            this.btnSpocitej = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSpravne = new System.Windows.Forms.Label();
            this.lblSpatne = new System.Windows.Forms.Label();
            this.tbPrvniCislo = new System.Windows.Forms.TextBox();
            this.tbDruheCislo = new System.Windows.Forms.TextBox();
            this.tbVysledek = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblZnamenko = new System.Windows.Forms.Label();
            this.lblMaxCislo = new System.Windows.Forms.Label();
            this.chlbMatematickaOperace = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudMaxHodnota = new System.Windows.Forms.NumericUpDown();
            this.pbObrazek = new System.Windows.Forms.PictureBox();
            this.rtbVysledky = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPocitadlo = new System.Windows.Forms.Label();
            this.cbZapornyVysledek = new System.Windows.Forms.CheckBox();
            this.cbDeleniCeleCislo = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxHodnota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObrazek)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpocitej
            // 
            this.btnSpocitej.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpocitej.Location = new System.Drawing.Point(420, 106);
            this.btnSpocitej.Name = "btnSpocitej";
            this.btnSpocitej.Size = new System.Drawing.Size(75, 23);
            this.btnSpocitej.TabIndex = 9;
            this.btnSpocitej.Text = "SPOČÍTEJ";
            this.btnSpocitej.UseVisualStyleBackColor = true;
            this.btnSpocitej.Click += new System.EventHandler(this.btnSpocitej_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(576, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "SPRÁVNĚ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(576, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ŠPATNĚ";
            // 
            // lblSpravne
            // 
            this.lblSpravne.AutoSize = true;
            this.lblSpravne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSpravne.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSpravne.Location = new System.Drawing.Point(692, 27);
            this.lblSpravne.Name = "lblSpravne";
            this.lblSpravne.Size = new System.Drawing.Size(19, 20);
            this.lblSpravne.TabIndex = 4;
            this.lblSpravne.Text = "0";
            // 
            // lblSpatne
            // 
            this.lblSpatne.AutoSize = true;
            this.lblSpatne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSpatne.ForeColor = System.Drawing.Color.Crimson;
            this.lblSpatne.Location = new System.Drawing.Point(692, 66);
            this.lblSpatne.Name = "lblSpatne";
            this.lblSpatne.Size = new System.Drawing.Size(19, 20);
            this.lblSpatne.TabIndex = 5;
            this.lblSpatne.Text = "0";
            // 
            // tbPrvniCislo
            // 
            this.tbPrvniCislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPrvniCislo.Location = new System.Drawing.Point(6, 19);
            this.tbPrvniCislo.Name = "tbPrvniCislo";
            this.tbPrvniCislo.ReadOnly = true;
            this.tbPrvniCislo.Size = new System.Drawing.Size(100, 26);
            this.tbPrvniCislo.TabIndex = 6;
            // 
            // tbDruheCislo
            // 
            this.tbDruheCislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDruheCislo.Location = new System.Drawing.Point(137, 19);
            this.tbDruheCislo.Name = "tbDruheCislo";
            this.tbDruheCislo.ReadOnly = true;
            this.tbDruheCislo.Size = new System.Drawing.Size(100, 26);
            this.tbDruheCislo.TabIndex = 7;
            // 
            // tbVysledek
            // 
            this.tbVysledek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbVysledek.Location = new System.Drawing.Point(268, 19);
            this.tbVysledek.Name = "tbVysledek";
            this.tbVysledek.Size = new System.Drawing.Size(100, 26);
            this.tbVysledek.TabIndex = 8;
            this.tbVysledek.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbVysledek_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(243, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "=";
            // 
            // lblZnamenko
            // 
            this.lblZnamenko.AutoSize = true;
            this.lblZnamenko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZnamenko.Location = new System.Drawing.Point(112, 22);
            this.lblZnamenko.Name = "lblZnamenko";
            this.lblZnamenko.Size = new System.Drawing.Size(19, 20);
            this.lblZnamenko.TabIndex = 10;
            this.lblZnamenko.Text = "+";
            // 
            // lblMaxCislo
            // 
            this.lblMaxCislo.AutoSize = true;
            this.lblMaxCislo.Location = new System.Drawing.Point(13, 10);
            this.lblMaxCislo.Name = "lblMaxCislo";
            this.lblMaxCislo.Size = new System.Drawing.Size(97, 13);
            this.lblMaxCislo.TabIndex = 12;
            this.lblMaxCislo.Text = "Maximální hodnota";
            // 
            // chlbMatematickaOperace
            // 
            this.chlbMatematickaOperace.FormattingEnabled = true;
            this.chlbMatematickaOperace.Items.AddRange(new object[] {
            "Sčítání",
            "Odčítání",
            "Násobení",
            "Dělení"});
            this.chlbMatematickaOperace.Location = new System.Drawing.Point(128, 12);
            this.chlbMatematickaOperace.Name = "chlbMatematickaOperace";
            this.chlbMatematickaOperace.Size = new System.Drawing.Size(80, 64);
            this.chlbMatematickaOperace.TabIndex = 13;
            this.chlbMatematickaOperace.SelectedIndexChanged += new System.EventHandler(this.chlbMatematickaOperace_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPrvniCislo);
            this.groupBox1.Controls.Add(this.lblZnamenko);
            this.groupBox1.Controls.Add(this.tbDruheCislo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbVysledek);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 61);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Výpočet";
            // 
            // nudMaxHodnota
            // 
            this.nudMaxHodnota.Location = new System.Drawing.Point(16, 30);
            this.nudMaxHodnota.Name = "nudMaxHodnota";
            this.nudMaxHodnota.Size = new System.Drawing.Size(45, 20);
            this.nudMaxHodnota.TabIndex = 15;
            this.nudMaxHodnota.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMaxHodnota.ValueChanged += new System.EventHandler(this.nudMaxHodnota_ValueChanged);
            // 
            // pbObrazek
            // 
            this.pbObrazek.Location = new System.Drawing.Point(513, 154);
            this.pbObrazek.Name = "pbObrazek";
            this.pbObrazek.Size = new System.Drawing.Size(272, 252);
            this.pbObrazek.TabIndex = 16;
            this.pbObrazek.TabStop = false;
            // 
            // rtbVysledky
            // 
            this.rtbVysledky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbVysledky.Location = new System.Drawing.Point(12, 154);
            this.rtbVysledky.Name = "rtbVysledky";
            this.rtbVysledky.ReadOnly = true;
            this.rtbVysledky.Size = new System.Drawing.Size(387, 252);
            this.rtbVysledky.TabIndex = 17;
            this.rtbVysledky.Text = "";
            this.rtbVysledky.TextChanged += new System.EventHandler(this.rtbVysledky_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPocitadlo
            // 
            this.lblPocitadlo.AutoSize = true;
            this.lblPocitadlo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPocitadlo.Location = new System.Drawing.Point(14, 56);
            this.lblPocitadlo.Name = "lblPocitadlo";
            this.lblPocitadlo.Size = new System.Drawing.Size(73, 20);
            this.lblPocitadlo.TabIndex = 18;
            this.lblPocitadlo.Text = "pocitadlo";
            // 
            // cbZapornyVysledek
            // 
            this.cbZapornyVysledek.AutoSize = true;
            this.cbZapornyVysledek.Location = new System.Drawing.Point(215, 13);
            this.cbZapornyVysledek.Name = "cbZapornyVysledek";
            this.cbZapornyVysledek.Size = new System.Drawing.Size(202, 17);
            this.cbZapornyVysledek.TabIndex = 19;
            this.cbZapornyVysledek.Text = "Povolit záporný výsledek při odčítání";
            this.cbZapornyVysledek.UseVisualStyleBackColor = true;
            this.cbZapornyVysledek.CheckedChanged += new System.EventHandler(this.cbZapornyVysledek_CheckedChanged);
            // 
            // cbDeleniCeleCislo
            // 
            this.cbDeleniCeleCislo.AutoSize = true;
            this.cbDeleniCeleCislo.Checked = true;
            this.cbDeleniCeleCislo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDeleniCeleCislo.Location = new System.Drawing.Point(214, 33);
            this.cbDeleniCeleCislo.Name = "cbDeleniCeleCislo";
            this.cbDeleniCeleCislo.Size = new System.Drawing.Size(206, 17);
            this.cbDeleniCeleCislo.TabIndex = 20;
            this.cbDeleniCeleCislo.Text = "Pouze celočíselný výsledek při dělení";
            this.cbDeleniCeleCislo.UseVisualStyleBackColor = true;
            this.cbDeleniCeleCislo.CheckedChanged += new System.EventHandler(this.cbDeleniCeleCislo_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 418);
            this.Controls.Add(this.cbDeleniCeleCislo);
            this.Controls.Add(this.cbZapornyVysledek);
            this.Controls.Add(this.lblPocitadlo);
            this.Controls.Add(this.rtbVysledky);
            this.Controls.Add(this.pbObrazek);
            this.Controls.Add(this.nudMaxHodnota);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chlbMatematickaOperace);
            this.Controls.Add(this.lblMaxCislo);
            this.Controls.Add(this.lblSpatne);
            this.Controls.Add(this.lblSpravne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpocitej);
            this.Name = "Form1";
            this.Text = "Matematika";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxHodnota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObrazek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpocitej;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSpravne;
        private System.Windows.Forms.Label lblSpatne;
        private System.Windows.Forms.TextBox tbVysledek;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbPrvniCislo;
        public System.Windows.Forms.TextBox tbDruheCislo;
        public System.Windows.Forms.Label lblZnamenko;
        private System.Windows.Forms.Label lblMaxCislo;
        private System.Windows.Forms.CheckedListBox chlbMatematickaOperace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudMaxHodnota;
        private System.Windows.Forms.PictureBox pbObrazek;
        private System.Windows.Forms.RichTextBox rtbVysledky;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPocitadlo;
        private System.Windows.Forms.CheckBox cbZapornyVysledek;
        private System.Windows.Forms.CheckBox cbDeleniCeleCislo;
    }
}

