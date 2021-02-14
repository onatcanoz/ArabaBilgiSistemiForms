
namespace ArabaBilgiSistemiForms
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
            this.lMarka = new System.Windows.Forms.Label();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.lModel = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.lKapiSayisi = new System.Windows.Forms.Label();
            this.ddlKapiSayisi = new System.Windows.Forms.ComboBox();
            this.lBeygirGucu = new System.Windows.Forms.Label();
            this.nupBeygir = new System.Windows.Forms.NumericUpDown();
            this.lArabaTuru = new System.Windows.Forms.Label();
            this.rbBinek = new System.Windows.Forms.RadioButton();
            this.rbTicari = new System.Windows.Forms.RadioButton();
            this.lMaksimumHiz = new System.Windows.Forms.Label();
            this.nupMax = new System.Windows.Forms.NumericUpDown();
            this.lCekis = new System.Windows.Forms.Label();
            this.lbCekis = new System.Windows.Forms.ListBox();
            this.lSifirdanYuzeHizlanma = new System.Windows.Forms.Label();
            this.nupSıfıryuz = new System.Windows.Forms.NumericUpDown();
            this.lAgirlik = new System.Windows.Forms.Label();
            this.nupAgırlık = new System.Windows.Forms.NumericUpDown();
            this.lMotorHacmi = new System.Windows.Forms.Label();
            this.nupMotorHacmi = new System.Windows.Forms.NumericUpDown();
            this.lBaslik = new System.Windows.Forms.Label();
            this.lsonuc = new System.Windows.Forms.Label();
            this.bKaydet = new System.Windows.Forms.Button();
            this.bTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupBeygir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSıfıryuz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAgırlık)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMotorHacmi)).BeginInit();
            this.SuspendLayout();
            // 
            // lMarka
            // 
            this.lMarka.AutoSize = true;
            this.lMarka.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lMarka.Location = new System.Drawing.Point(9, 149);
            this.lMarka.Name = "lMarka";
            this.lMarka.Size = new System.Drawing.Size(68, 20);
            this.lMarka.TabIndex = 0;
            this.lMarka.Text = "Marka";
            // 
            // tbMarka
            // 
            this.tbMarka.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMarka.Location = new System.Drawing.Point(179, 144);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(159, 28);
            this.tbMarka.TabIndex = 1;
            // 
            // lModel
            // 
            this.lModel.AutoSize = true;
            this.lModel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lModel.Location = new System.Drawing.Point(11, 195);
            this.lModel.Name = "lModel";
            this.lModel.Size = new System.Drawing.Size(65, 20);
            this.lModel.TabIndex = 2;
            this.lModel.Text = "Model";
            // 
            // tbModel
            // 
            this.tbModel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbModel.Location = new System.Drawing.Point(179, 195);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(159, 28);
            this.tbModel.TabIndex = 3;
            // 
            // lKapiSayisi
            // 
            this.lKapiSayisi.AutoSize = true;
            this.lKapiSayisi.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lKapiSayisi.Location = new System.Drawing.Point(11, 364);
            this.lKapiSayisi.Name = "lKapiSayisi";
            this.lKapiSayisi.Size = new System.Drawing.Size(109, 20);
            this.lKapiSayisi.TabIndex = 4;
            this.lKapiSayisi.Text = "Kapı Sayısı";
            // 
            // ddlKapiSayisi
            // 
            this.ddlKapiSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ddlKapiSayisi.FormattingEnabled = true;
            this.ddlKapiSayisi.Items.AddRange(new object[] {
            "2 Kapılı",
            "4 Kapılı",
            "5 Kapılı"});
            this.ddlKapiSayisi.Location = new System.Drawing.Point(179, 364);
            this.ddlKapiSayisi.Name = "ddlKapiSayisi";
            this.ddlKapiSayisi.Size = new System.Drawing.Size(159, 25);
            this.ddlKapiSayisi.TabIndex = 5;
            // 
            // lBeygirGucu
            // 
            this.lBeygirGucu.AutoSize = true;
            this.lBeygirGucu.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lBeygirGucu.Location = new System.Drawing.Point(12, 419);
            this.lBeygirGucu.Name = "lBeygirGucu";
            this.lBeygirGucu.Size = new System.Drawing.Size(120, 20);
            this.lBeygirGucu.TabIndex = 6;
            this.lBeygirGucu.Text = "Beygir Gücü";
            // 
            // nupBeygir
            // 
            this.nupBeygir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nupBeygir.Location = new System.Drawing.Point(179, 419);
            this.nupBeygir.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nupBeygir.Name = "nupBeygir";
            this.nupBeygir.Size = new System.Drawing.Size(120, 27);
            this.nupBeygir.TabIndex = 7;
            this.nupBeygir.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // lArabaTuru
            // 
            this.lArabaTuru.AutoSize = true;
            this.lArabaTuru.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lArabaTuru.Location = new System.Drawing.Point(11, 238);
            this.lArabaTuru.Name = "lArabaTuru";
            this.lArabaTuru.Size = new System.Drawing.Size(112, 20);
            this.lArabaTuru.TabIndex = 6;
            this.lArabaTuru.Text = "ArabaTürü";
            // 
            // rbBinek
            // 
            this.rbBinek.AutoSize = true;
            this.rbBinek.Checked = true;
            this.rbBinek.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbBinek.Location = new System.Drawing.Point(179, 238);
            this.rbBinek.Name = "rbBinek";
            this.rbBinek.Size = new System.Drawing.Size(69, 24);
            this.rbBinek.TabIndex = 8;
            this.rbBinek.TabStop = true;
            this.rbBinek.Text = "Binek";
            this.rbBinek.UseVisualStyleBackColor = true;
            // 
            // rbTicari
            // 
            this.rbTicari.AutoSize = true;
            this.rbTicari.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTicari.Location = new System.Drawing.Point(249, 238);
            this.rbTicari.Name = "rbTicari";
            this.rbTicari.Size = new System.Drawing.Size(69, 24);
            this.rbTicari.TabIndex = 9;
            this.rbTicari.Text = "Ticari";
            this.rbTicari.UseVisualStyleBackColor = true;
            // 
            // lMaksimumHiz
            // 
            this.lMaksimumHiz.AutoSize = true;
            this.lMaksimumHiz.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lMaksimumHiz.Location = new System.Drawing.Point(12, 474);
            this.lMaksimumHiz.Name = "lMaksimumHiz";
            this.lMaksimumHiz.Size = new System.Drawing.Size(145, 20);
            this.lMaksimumHiz.TabIndex = 10;
            this.lMaksimumHiz.Text = "Maksimum Hız";
            // 
            // nupMax
            // 
            this.nupMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nupMax.Location = new System.Drawing.Point(179, 474);
            this.nupMax.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nupMax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nupMax.Name = "nupMax";
            this.nupMax.Size = new System.Drawing.Size(120, 27);
            this.nupMax.TabIndex = 11;
            this.nupMax.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // lCekis
            // 
            this.lCekis.AutoSize = true;
            this.lCekis.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lCekis.Location = new System.Drawing.Point(11, 278);
            this.lCekis.Name = "lCekis";
            this.lCekis.Size = new System.Drawing.Size(57, 20);
            this.lCekis.TabIndex = 12;
            this.lCekis.Text = "Çekiş";
            // 
            // lbCekis
            // 
            this.lbCekis.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbCekis.FormattingEnabled = true;
            this.lbCekis.ItemHeight = 20;
            this.lbCekis.Items.AddRange(new object[] {
            "Önden çekiş",
            "Arkadan itiş",
            "Dört çeker"});
            this.lbCekis.Location = new System.Drawing.Point(179, 278);
            this.lbCekis.Name = "lbCekis";
            this.lbCekis.Size = new System.Drawing.Size(120, 84);
            this.lbCekis.TabIndex = 13;
            // 
            // lSifirdanYuzeHizlanma
            // 
            this.lSifirdanYuzeHizlanma.AutoSize = true;
            this.lSifirdanYuzeHizlanma.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSifirdanYuzeHizlanma.Location = new System.Drawing.Point(9, 520);
            this.lSifirdanYuzeHizlanma.Name = "lSifirdanYuzeHizlanma";
            this.lSifirdanYuzeHizlanma.Size = new System.Drawing.Size(59, 20);
            this.lSifirdanYuzeHizlanma.TabIndex = 14;
            this.lSifirdanYuzeHizlanma.Text = "0-100";
            // 
            // nupSıfıryuz
            // 
            this.nupSıfıryuz.DecimalPlaces = 1;
            this.nupSıfıryuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nupSıfıryuz.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nupSıfıryuz.Location = new System.Drawing.Point(179, 520);
            this.nupSıfıryuz.Name = "nupSıfıryuz";
            this.nupSıfıryuz.Size = new System.Drawing.Size(120, 27);
            this.nupSıfıryuz.TabIndex = 15;
            this.nupSıfıryuz.Value = new decimal(new int[] {
            80,
            0,
            0,
            65536});
            // 
            // lAgirlik
            // 
            this.lAgirlik.AutoSize = true;
            this.lAgirlik.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lAgirlik.Location = new System.Drawing.Point(9, 571);
            this.lAgirlik.Name = "lAgirlik";
            this.lAgirlik.Size = new System.Drawing.Size(70, 20);
            this.lAgirlik.TabIndex = 16;
            this.lAgirlik.Text = "Ağırlık";
            // 
            // nupAgırlık
            // 
            this.nupAgırlık.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nupAgırlık.Location = new System.Drawing.Point(179, 571);
            this.nupAgırlık.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nupAgırlık.Minimum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.nupAgırlık.Name = "nupAgırlık";
            this.nupAgırlık.Size = new System.Drawing.Size(120, 27);
            this.nupAgırlık.TabIndex = 17;
            this.nupAgırlık.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lMotorHacmi
            // 
            this.lMotorHacmi.AutoSize = true;
            this.lMotorHacmi.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lMotorHacmi.Location = new System.Drawing.Point(9, 622);
            this.lMotorHacmi.Name = "lMotorHacmi";
            this.lMotorHacmi.Size = new System.Drawing.Size(127, 20);
            this.lMotorHacmi.TabIndex = 18;
            this.lMotorHacmi.Text = "Motor Hacmi";
            // 
            // nupMotorHacmi
            // 
            this.nupMotorHacmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nupMotorHacmi.Location = new System.Drawing.Point(179, 622);
            this.nupMotorHacmi.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nupMotorHacmi.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupMotorHacmi.Name = "nupMotorHacmi";
            this.nupMotorHacmi.Size = new System.Drawing.Size(120, 27);
            this.nupMotorHacmi.TabIndex = 19;
            this.nupMotorHacmi.Value = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            // 
            // lBaslik
            // 
            this.lBaslik.BackColor = System.Drawing.Color.Khaki;
            this.lBaslik.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lBaslik.Location = new System.Drawing.Point(0, 0);
            this.lBaslik.Name = "lBaslik";
            this.lBaslik.Size = new System.Drawing.Size(800, 126);
            this.lBaslik.TabIndex = 21;
            this.lBaslik.Text = "ARABA BİLGİ SİSTEMİ";
            this.lBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsonuc
            // 
            this.lsonuc.BackColor = System.Drawing.Color.Khaki;
            this.lsonuc.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lsonuc.Location = new System.Drawing.Point(445, 144);
            this.lsonuc.Name = "lsonuc";
            this.lsonuc.Size = new System.Drawing.Size(217, 505);
            this.lsonuc.TabIndex = 22;
            this.lsonuc.Text = "Sonuc";
            // 
            // bKaydet
            // 
            this.bKaydet.BackColor = System.Drawing.Color.Red;
            this.bKaydet.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bKaydet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bKaydet.Location = new System.Drawing.Point(72, 681);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(148, 41);
            this.bKaydet.TabIndex = 23;
            this.bKaydet.Text = "Kaydet";
            this.bKaydet.UseVisualStyleBackColor = false;
            this.bKaydet.Click += new System.EventHandler(this.bKaydet_Click);
            // 
            // bTemizle
            // 
            this.bTemizle.BackColor = System.Drawing.Color.Black;
            this.bTemizle.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTemizle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bTemizle.Location = new System.Drawing.Point(459, 681);
            this.bTemizle.Name = "bTemizle";
            this.bTemizle.Size = new System.Drawing.Size(152, 41);
            this.bTemizle.TabIndex = 24;
            this.bTemizle.Text = "Temizle";
            this.bTemizle.UseVisualStyleBackColor = false;
            this.bTemizle.Click += new System.EventHandler(this.bTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 734);
            this.Controls.Add(this.bTemizle);
            this.Controls.Add(this.bKaydet);
            this.Controls.Add(this.lsonuc);
            this.Controls.Add(this.rbTicari);
            this.Controls.Add(this.rbBinek);
            this.Controls.Add(this.lArabaTuru);
            this.Controls.Add(this.lBaslik);
            this.Controls.Add(this.nupMotorHacmi);
            this.Controls.Add(this.lMotorHacmi);
            this.Controls.Add(this.nupAgırlık);
            this.Controls.Add(this.lAgirlik);
            this.Controls.Add(this.nupSıfıryuz);
            this.Controls.Add(this.lSifirdanYuzeHizlanma);
            this.Controls.Add(this.lbCekis);
            this.Controls.Add(this.lCekis);
            this.Controls.Add(this.nupMax);
            this.Controls.Add(this.lMaksimumHiz);
            this.Controls.Add(this.nupBeygir);
            this.Controls.Add(this.lBeygirGucu);
            this.Controls.Add(this.ddlKapiSayisi);
            this.Controls.Add(this.lKapiSayisi);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.lModel);
            this.Controls.Add(this.tbMarka);
            this.Controls.Add(this.lMarka);
            this.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupBeygir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSıfıryuz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAgırlık)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMotorHacmi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lMarka;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.Label lModel;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label lKapiSayisi;
        private System.Windows.Forms.ComboBox ddlKapiSayisi;
        private System.Windows.Forms.Label lBeygirGucu;
        private System.Windows.Forms.NumericUpDown nupBeygir;
        private System.Windows.Forms.Label lArabaTuru;
        private System.Windows.Forms.RadioButton rbBinek;
        private System.Windows.Forms.RadioButton rbTicari;
        private System.Windows.Forms.Label lMaksimumHiz;
        private System.Windows.Forms.NumericUpDown nupMax;
        private System.Windows.Forms.Label lCekis;
        private System.Windows.Forms.ListBox lbCekis;
        private System.Windows.Forms.Label lSifirdanYuzeHizlanma;
        private System.Windows.Forms.NumericUpDown nupSıfıryuz;
        private System.Windows.Forms.Label lAgirlik;
        private System.Windows.Forms.NumericUpDown nupAgırlık;
        private System.Windows.Forms.Label lMotorHacmi;
        private System.Windows.Forms.NumericUpDown nupMotorHacmi;
        private System.Windows.Forms.Label lBaslik;
        private System.Windows.Forms.Label lsonuc;
        private System.Windows.Forms.Button bKaydet;
        private System.Windows.Forms.Button bTemizle;
    }
}

