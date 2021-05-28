namespace TSP_GA_WINF
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtboxPopulacija = new System.Windows.Forms.TextBox();
            this.lblPopulacija = new System.Windows.Forms.Label();
            this.lblBrojKlijenata = new System.Windows.Forms.Label();
            this.txtboxBrojKlijenata = new System.Windows.Forms.TextBox();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.txtboxKordinate = new System.Windows.Forms.TextBox();
            this.txtboxBrojCiklusa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxProcenatMutacije = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxDuzinaPutanje = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxRezKord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxNajGen = new System.Windows.Forms.TextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBrojacGen = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxPopulacija
            // 
            this.txtboxPopulacija.Location = new System.Drawing.Point(98, 56);
            this.txtboxPopulacija.Name = "txtboxPopulacija";
            this.txtboxPopulacija.Size = new System.Drawing.Size(100, 20);
            this.txtboxPopulacija.TabIndex = 1;
            // 
            // lblPopulacija
            // 
            this.lblPopulacija.AutoSize = true;
            this.lblPopulacija.Location = new System.Drawing.Point(9, 59);
            this.lblPopulacija.Name = "lblPopulacija";
            this.lblPopulacija.Size = new System.Drawing.Size(59, 13);
            this.lblPopulacija.TabIndex = 1;
            this.lblPopulacija.Text = "Populacija:";
            // 
            // lblBrojKlijenata
            // 
            this.lblBrojKlijenata.AutoSize = true;
            this.lblBrojKlijenata.Location = new System.Drawing.Point(9, 18);
            this.lblBrojKlijenata.Name = "lblBrojKlijenata";
            this.lblBrojKlijenata.Size = new System.Drawing.Size(70, 13);
            this.lblBrojKlijenata.TabIndex = 3;
            this.lblBrojKlijenata.Text = "Broj gradova:";
            // 
            // txtboxBrojKlijenata
            // 
            this.txtboxBrojKlijenata.Location = new System.Drawing.Point(98, 15);
            this.txtboxBrojKlijenata.Name = "txtboxBrojKlijenata";
            this.txtboxBrojKlijenata.Size = new System.Drawing.Size(100, 20);
            this.txtboxBrojKlijenata.TabIndex = 0;
            // 
            // btnPokreni
            // 
            this.btnPokreni.Location = new System.Drawing.Point(31, 22);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(75, 23);
            this.btnPokreni.TabIndex = 4;
            this.btnPokreni.Text = "Pokreni";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // txtboxKordinate
            // 
            this.txtboxKordinate.Location = new System.Drawing.Point(15, 198);
            this.txtboxKordinate.Multiline = true;
            this.txtboxKordinate.Name = "txtboxKordinate";
            this.txtboxKordinate.ReadOnly = true;
            this.txtboxKordinate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxKordinate.Size = new System.Drawing.Size(172, 158);
            this.txtboxKordinate.TabIndex = 5;
            this.txtboxKordinate.TabStop = false;
            // 
            // txtboxBrojCiklusa
            // 
            this.txtboxBrojCiklusa.Location = new System.Drawing.Point(98, 138);
            this.txtboxBrojCiklusa.Name = "txtboxBrojCiklusa";
            this.txtboxBrojCiklusa.Size = new System.Drawing.Size(100, 20);
            this.txtboxBrojCiklusa.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Broj ciklusa:";
            // 
            // txtboxProcenatMutacije
            // 
            this.txtboxProcenatMutacije.Location = new System.Drawing.Point(98, 97);
            this.txtboxProcenatMutacije.Name = "txtboxProcenatMutacije";
            this.txtboxProcenatMutacije.Size = new System.Drawing.Size(100, 20);
            this.txtboxProcenatMutacije.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mutacija (u %) :";
            // 
            // txtboxDuzinaPutanje
            // 
            this.txtboxDuzinaPutanje.Location = new System.Drawing.Point(155, 22);
            this.txtboxDuzinaPutanje.Name = "txtboxDuzinaPutanje";
            this.txtboxDuzinaPutanje.ReadOnly = true;
            this.txtboxDuzinaPutanje.Size = new System.Drawing.Size(81, 20);
            this.txtboxDuzinaPutanje.TabIndex = 11;
            this.txtboxDuzinaPutanje.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Duzina putanje (u km)";
            // 
            // txtboxRezKord
            // 
            this.txtboxRezKord.Location = new System.Drawing.Point(107, 125);
            this.txtboxRezKord.Name = "txtboxRezKord";
            this.txtboxRezKord.ReadOnly = true;
            this.txtboxRezKord.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtboxRezKord.Size = new System.Drawing.Size(211, 20);
            this.txtboxRezKord.TabIndex = 13;
            this.txtboxRezKord.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Redosled kordinati";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Najbolja generacija";
            // 
            // txtboxNajGen
            // 
            this.txtboxNajGen.Location = new System.Drawing.Point(166, 75);
            this.txtboxNajGen.Name = "txtboxNajGen";
            this.txtboxNajGen.ReadOnly = true;
            this.txtboxNajGen.Size = new System.Drawing.Size(53, 20);
            this.txtboxNajGen.TabIndex = 16;
            this.txtboxNajGen.TabStop = false;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Enabled = false;
            this.btnObrisi.Location = new System.Drawing.Point(31, 75);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Trenutna generacija:";
            // 
            // lblBrojacGen
            // 
            this.lblBrojacGen.AutoSize = true;
            this.lblBrojacGen.Location = new System.Drawing.Point(118, 125);
            this.lblBrojacGen.Name = "lblBrojacGen";
            this.lblBrojacGen.Size = new System.Drawing.Size(13, 13);
            this.lblBrojacGen.TabIndex = 20;
            this.lblBrojacGen.Text = "0";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(213, 184);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Putanja";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(539, 269);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtboxBrojCiklusa);
            this.groupBox1.Controls.Add(this.txtboxPopulacija);
            this.groupBox1.Controls.Add(this.lblPopulacija);
            this.groupBox1.Controls.Add(this.txtboxBrojKlijenata);
            this.groupBox1.Controls.Add(this.lblBrojKlijenata);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtboxProcenatMutacije);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 168);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtboxNajGen);
            this.groupBox2.Controls.Add(this.txtboxDuzinaPutanje);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtboxRezKord);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(237, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 158);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rezultat";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnPokreni);
            this.groupBox3.Controls.Add(this.btnObrisi);
            this.groupBox3.Controls.Add(this.lblBrojacGen);
            this.groupBox3.Location = new System.Drawing.Point(590, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(162, 158);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kontrole";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Kordinate tacaka:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Student: Mihailo Petrovic IN 13/17";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Mentor: prof. dr Milovan Milivojevic";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 362);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 50);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 460);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.txtboxKordinate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ASSZS Najkraca putanja - Genetski algoritmi ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxPopulacija;
        private System.Windows.Forms.Label lblPopulacija;
        private System.Windows.Forms.Label lblBrojKlijenata;
        private System.Windows.Forms.TextBox txtboxBrojKlijenata;
        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.TextBox txtboxKordinate;
        private System.Windows.Forms.TextBox txtboxBrojCiklusa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxProcenatMutacije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxDuzinaPutanje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxRezKord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxNajGen;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBrojacGen;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

